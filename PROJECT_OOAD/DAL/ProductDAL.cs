using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using PROJECT_OOAD.Models;

namespace PROJECT_OOAD.DAL
{
    public class ProductDAL
    {
        private SqlConnection oSqlCon;
        private SqlCommand oSqlCmd;
        private SqlDataReader oReader;
        public ProductDAL()
        {
            oSqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["IntranetCon"].ToString());
            oSqlCmd = new SqlCommand();
        }
        //public List<Product> GetProduct()
        //{
        //    oSqlCon.Open();
        //    oSqlCmd = new SqlCommand("[dbo].[PRODUCT_GET]", oSqlCon);

        //    oSqlCmd.CommandType = CommandType.StoredProcedure;
        //    oSqlCmd.Parameters.Add("@Name", SqlDbType.NVarChar, 250).Value = name;
        //    List<Product> Rqobj = new List<Product>();
        //    oReader = oSqlCmd.ExecuteReader();
        //    while (oReader.Read())
        //    {
        //        Rqobj.Add(new Product(
        //            (int)oReader["ProductID"],
        //            oReader["name"].ToString(),
        //            oReader["Price"].ToString(),
        //            oReader["StockQuantity"].ToString()
        //        ));
        //    }

        //}
        public List<Product> ListProduts()
        {
            oSqlCon.Open();
            oSqlCmd = new SqlCommand("[PR].[PRODUCT_LIST]", oSqlCon);
            oSqlCmd.CommandType = CommandType.StoredProcedure;
            List<Product> Rqobj = new List<Product>();
            oReader = oSqlCmd.ExecuteReader();
            while (oReader.Read())
            {
                Rqobj.Add(new Product(
                    (int)oReader["P_ID"],
                    oReader["Name"].ToString(),
                    oReader["Price"].ToString(),
                    oReader["StockQuantity"].ToString()
                ));
            }
            oSqlCon.Close();
            return Rqobj;
        }
        public string CreateProduct(Product products)
        {
            oSqlCon.Open();
            oSqlCmd = new SqlCommand("[PR].[PRODUCT_CREATE]", oSqlCon);

            oSqlCmd.Parameters.Add("@NAME", SqlDbType.NVarChar, 50).Value = products.Name;
            oSqlCmd.Parameters.Add("@PRICE", SqlDbType.NVarChar, 50).Value = products.Price;
            oSqlCmd.Parameters.Add("@STOCK_QUANTITY", SqlDbType.NVarChar, 50).Value = products.StockQuantity;
            oSqlCmd.CommandType = CommandType.StoredProcedure;
            string rowAffected = oSqlCmd.ExecuteNonQuery().ToString();

            oSqlCon.Close();
            return rowAffected;
        }
        public Product EditProduct(int Id)
        {
            oSqlCon.Open();
            oSqlCmd = new SqlCommand("[PR].[PRODUCT_EDIT]", oSqlCon);
            oSqlCmd.Parameters.Add("@Id", SqlDbType.NVarChar).Value = Id;
            oSqlCmd.CommandType = CommandType.StoredProcedure;
            Product Rqobj = new Product();
            oReader = oSqlCmd.ExecuteReader();
            while (oReader.Read())
            {
                Rqobj = (new Product(
                    (int)oReader["ID"],
                    oReader["Name"].ToString(),
                    oReader["Price"].ToString(),
                    oReader["StockQuantity"].ToString()
                    ));
            }
            oSqlCon.Close();
            return Rqobj;
        }
        public string UpdateProduct(Product product)
        {
            oSqlCon.Open();
            oSqlCmd = new SqlCommand("[PR].[PRODUCT_UPDATE]", oSqlCon);
            oSqlCmd.Parameters.Add("@Id", SqlDbType.NVarChar).Value = product.ID;
            oSqlCmd.Parameters.Add("@NAME", SqlDbType.NVarChar).Value = product.Name;
            oSqlCmd.Parameters.Add("@PRICE", SqlDbType.NVarChar).Value = product.Price;
            oSqlCmd.Parameters.Add("@STOCK_QUANTITY", SqlDbType.NVarChar).Value = product.StockQuantity;
            oSqlCmd.CommandType = CommandType.StoredProcedure;
            string rowAffected = oSqlCmd.ExecuteNonQuery().ToString();

            oSqlCon.Close();
            return rowAffected;
        }

        public string DeleteProduct(string Id)
        {
            oSqlCon.Open();
            oSqlCmd = new SqlCommand("[PR].[PRODUCT_DELETE]", oSqlCon);
            oSqlCmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = Id;
            oSqlCmd.CommandType = CommandType.StoredProcedure;
            string rowAffected = oSqlCmd.ExecuteNonQuery().ToString();

            oSqlCon.Close();
            return rowAffected;
        }



    }
}