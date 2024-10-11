using PROJECT_OOAD.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;


namespace PROJECT_OOAD.DAL
{
    public class SaleDAL
    {
        private SqlConnection oSqlCon;
        private SqlCommand oSqlCmd;
        //private SqlDataReader oReader;
        public SaleDAL()
        {
            oSqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["IntranetCon"].ToString());
            oSqlCmd = new SqlCommand();
        }
        //public List<Sale> SalesList()
        //{
        //    oSqlCon.Open();
        //    oSqlCmd = new SqlCommand("[SAL].[SALE_LIST]", oSqlCon);
        //    oSqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
        //    List<Sale> SLobj = new List<Sale>();
        //    oReader = oSqlCmd.ExecuteReader();
        //    while (oReader.Read())
        //    {
        //        SLobj.Add(new Sale(
        //            (int)oReader["SID"],
        //            (int)oReader["PID"],
        //            (int)oReader["CID"],
        //            oReader["Quantity"].ToString(),
        //            oReader["Amount"].ToString()
        //            ));
        //        oSqlCon.Close();
        //        return SLobj;
                                                                      
        //    }

        }
 
    }

