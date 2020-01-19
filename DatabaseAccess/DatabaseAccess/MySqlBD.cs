using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DatabaseAccess
{
    public class MySqlBD : DbAccess
    {
        public override void OpenConnection()
        {
            DbConnection = new MySqlConnection(ConnectionString);
            DbConnection.Open();
        }
        public override void CloseConnection()
        {
            if (DbConnection != null)
            {
                DbConnection.Close();
            }

        }
        public override DataTable QuerySQL(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable result = new DataTable();
            adapter.SelectCommand = new MySqlCommand(query, DbConnection);
            adapter.Fill(result);
            return result;

        }
        public override long EjectSQL(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query,DbConnection);
            return cmd.ExecuteNonQuery();
        }
        public override bool IsTransaction()
        {
            return (IsTransaction() != true);
        }
        public override void CommitTransaction()
        {
            if (IsTransaction())
            {
                DbTransaction.Commit();
            }
        }
        public override void RollbackTransaction()
        {
            if (IsTransaction()) {
                DbTransaction.Rollback();
            }
        }
        public override void BeginTransaction()
        {
            DbTransaction = DbConnection.BeginTransaction();
        }



    }
}