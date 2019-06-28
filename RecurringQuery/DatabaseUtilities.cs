using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecurringQuery
{
    public class DatabaseUtilities
    {
        public static DataSet GetDataSet(string ConnectionString, string sSQL)
        {
            SqlConnection cnnDBDT;
            cnnDBDT = new SqlConnection(ConnectionString);


            try
            {
                SqlDataAdapter dtaDA;
                DataSet dtsDS;

                // Setup SQL
                SqlCommand cmdSelect = new SqlCommand();
                cmdSelect.Connection = cnnDBDT;
                cmdSelect.CommandText = sSQL;

                cnnDBDT.Open();

                dtaDA = new SqlDataAdapter(cmdSelect);
                dtsDS = new DataSet("DTRecords");
                dtaDA.Fill(dtsDS);

                cnnDBDT.Close();

                return dtsDS;
            }
            catch (Exception ex)
            {
                return null;
            }

            finally
            {
                if (cnnDBDT.State == ConnectionState.Open)
                    cnnDBDT.Close();
            }
        }

    }
}
