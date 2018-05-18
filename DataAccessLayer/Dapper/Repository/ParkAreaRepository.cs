using Core.Repository.Dapper;
using Dapper;
using DataAccessLayer.Contracts;
using DataAccessLayer.Dapper.Helper;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Dapper.Repository
{
    public class ParkAreaRepository : DapperGenericRepository<ParkArea>, IParkAreaRepository
    {
        public override IDbConnection Connection => ConnectionHelper.SqlServerConnection();

        public override string TableName => "ParkArea";

        #region Specific Repository
        //public List<ParkArea> GetAllProductWithCategory()
        //{
        //    using (IDbConnection con = Connection)
        //    {
        //        string sql = "SELECT p.Id " +
        //            "ProductId,p.CategoryId ," +
        //            "p.Name,p.Price," +
        //            "p.StockQuantity," +
        //            "c.Name CategoryName, " +
        //            "p.Details FROM.Products p " +
        //            "INNER JOIN Categories c on p.CategoryId = c.Id";

        //        List<ParkArea> productWithCategory = con.Query<ParkArea>(sql).ToList();

        //        return productWithCategory;
        //    }
        //} 
        #endregion

    }
}
