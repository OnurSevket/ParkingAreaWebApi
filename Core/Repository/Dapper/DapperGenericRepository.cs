using Core.Contracts.Entities;
using Core.Contracts.Repository;
using Core.Enum;
using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository.Dapper
{
    public abstract class DapperGenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        public abstract IDbConnection Connection { get; }

        public abstract string TableName { get; }

        public TEntity Add(TEntity entity)
        {
            using (IDbConnection conn = Connection)
            {
                SqlMapperExtensions.TableNameMapper = (type) =>
                {
                    switch (type.Name)
                    {
                        default:
                            return TableName;
                    }
                };

                conn.Open();
                conn.Insert(entity);
                conn.Close();
                return entity;
            }
        }

        public int Delete(TEntity entity)
        {
            using (IDbConnection conn = Connection)
            {
                SqlMapperExtensions.TableNameMapper = (type) =>
                {
                    switch (type.Name)
                    {
                        default:
                            return TableName;
                    }
                };

                conn.Open();
                var result = conn.Delete(entity);
                conn.Close();
                return result == true ? (int)AdoptedEnums.Achievement.success : (int)AdoptedEnums.Achievement.fail;
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            TEntity entity = null;
            DynamicQueryResult result = GenerateDynamicQuery.GetDynamicQuery(TableName, predicate);
            using (IDbConnection conn = Connection)
            {
                conn.Open();
                entity = conn.Query<TEntity>(result.Sql, (object)result.Parameter).FirstOrDefault();
                conn.Close();
                return entity;
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate = null)
        {
            List<TEntity> entityList = null;
            if (predicate == null)
            {
                using (IDbConnection conn = Connection)
                {
                    conn.Open();
                    entityList = conn.Query<TEntity>("SELECT * FROM " + TableName).ToList();
                    conn.Close();
                    return entityList;
                }
            }
            else
            {
                DynamicQueryResult result = GenerateDynamicQuery.GetDynamicQuery(TableName, predicate);
                using (IDbConnection conn = Connection)
                {
                    conn.Open();
                    entityList = conn.Query<TEntity>(result.Sql, (object)result.Parameter).ToList();
                    conn.Close();
                    return entityList;
                }
            }
        }

        public TEntity Update(TEntity entity)
        {
            using (IDbConnection conn = Connection)
            {
                SqlMapperExtensions.TableNameMapper = (type) =>
                {
                    switch (type.Name)
                    {
                        default:
                            return TableName;
                    }
                };

                conn.Open();
                conn.Update(entity);
                conn.Close();
                return entity;
            }
        }
    }
}
