using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GTT
{
    public partial class GTTForm : Form
    {
        private const string ConnectionPrototype = "SERVER={0}; DATABASE={1}; User={2}; Password={3}; Connect Timeout=30";
        private const string ConnectionTrustedPrototype = "SERVER={0}; DATABASE={1}; Trusted_Connection=True; Connect Timeout=30";
        private const string Query_GetAllTables = "SELECT DISTINCT TABLE_NAME FROM information_schema.tables WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_SCHEMA = 'dbo' ORDER BY 1";
        private const string Query_CheckForTable = "SELECT COUNT(*) FROM information_schema.tables WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_SCHEMA = 'dbo' AND TABLE_NAME = @table";
        private const string Query_FetchTable = "SELECT * FROM {0}";
        private const string Query_EmptyTable = "DELETE FROM {0}";

        public GTTForm()
        {
            InitializeComponent();
        }

        private void SetCurrentStatus(string status)
        {
            CurrentStatus.Text = status;
            CurrentStatus.Invalidate();
            CurrentStatus.Update();
            CurrentStatus.Refresh();
            Refresh();
            Application.DoEvents();
        }

        private void ChangeControls()
        {
            groupBox1.Enabled = !groupBox1.Enabled;
            groupBox2.Enabled = !groupBox2.Enabled;
            GoButton.Enabled = !GoButton.Enabled;
        }




        private void GoButton_Click(object sender, EventArgs e)
        {
            DateTime start = DateTime.Now;
            
            SetCurrentStatus("Initializing connections");
            ChangeControls();
            string s_Host = source_Host.Text;
            string s_User = source_User.Text;
            string s_Pwd = source_Password.Text;
            string s_DB = source_DBName.Text;

            string d_Host = dest_Host.Text;
            string d_User = dest_User.Text;
            string d_Pwd = dest_Password.Text;
            string d_DB = dest_DBName.Text;

            SqlConnection s_Conn = null, d_Conn = null;
            SqlCommand s_Cmd = null, d_Cmd = null;
            SqlDataAdapter s_Adapter = null, d_Adapter = null;
            DataTable s_Table = new DataTable();
            SqlBulkCopy d_Bulk = null;
            try
            {
                s_Conn = source_Trusted.Checked ? new SqlConnection(String.Format(ConnectionTrustedPrototype, s_Host, s_DB)) : new SqlConnection(String.Format(ConnectionPrototype, s_Host, s_DB, s_User, s_Pwd));
                d_Conn = dest_Trusted.Checked ? new SqlConnection(String.Format(ConnectionTrustedPrototype, d_Host, d_DB)) : new SqlConnection(String.Format(ConnectionPrototype, d_Host, d_DB, d_User, d_Pwd));

                s_Conn.Open();
                d_Conn.Open();

                SetCurrentStatus("Retrieving source tables");
                s_Cmd = new SqlCommand(Query_GetAllTables, s_Conn);
                s_Adapter = new SqlDataAdapter(s_Cmd);
                s_Adapter.Fill(s_Table);

                List<string> AllTables = new List<string>();
                foreach(DataRow row in s_Table.Rows)
                {
                    SetCurrentStatus("Checking destination tables");
                    d_Cmd = new SqlCommand(Query_CheckForTable, d_Conn);
                    d_Cmd.Parameters.AddWithValue("table", row[0].ToString());
                    if ((int)d_Cmd.ExecuteScalar() > 0)
                        AllTables.Add(row[0].ToString());
                }

                int fetched = 0;
                int error = 0;
                foreach(string table in AllTables)
                {
                    fetched++;
                    SetCurrentStatus("Fetching table " + fetched + "/" + AllTables.Count);

                    s_Cmd = new SqlCommand(String.Format(Query_FetchTable, table), s_Conn);
                    s_Cmd.CommandTimeout = 300;
                    s_Table.Dispose();
                    s_Table = new DataTable();
                    s_Adapter = new SqlDataAdapter(s_Cmd);
                    s_Adapter.Fill(s_Table);
                    SqlTransaction d_Transaction = d_Conn.BeginTransaction();
                    try
                    {
                        d_Cmd = new SqlCommand(String.Format(Query_EmptyTable, table), d_Conn, d_Transaction);
                        d_Cmd.ExecuteNonQuery();
                        d_Cmd.Dispose();
                        d_Bulk = new SqlBulkCopy(d_Conn, SqlBulkCopyOptions.KeepIdentity | SqlBulkCopyOptions.KeepNulls, d_Transaction);
                        d_Bulk.BulkCopyTimeout = 500;
                        d_Bulk.DestinationTableName = table;
                        d_Bulk.WriteToServer(s_Table);
                        d_Bulk.Close();
                        d_Transaction.Commit();
                        d_Transaction.Dispose();
                    }
                    catch (Exception ex)
                    {
                        error++;
                        d_Transaction.Rollback();
                        MessageBox.Show("TABLE: " + table + "\n" + ex.Message);
                    }
                }

                MessageBox.Show("Operation Completed! Copied " + (fetched - error) + " tables on " + AllTables.Count + ".");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SetCurrentStatus("Welcome to \"Grand Theft Table\"");
                ChangeControls();

                s_Table.Dispose();
                if (s_Cmd != null)
                    s_Cmd.Dispose();
                if (d_Cmd != null)
                    d_Cmd.Dispose();
                if (s_Adapter != null)
                    s_Adapter.Dispose();
                if (d_Adapter != null)
                    d_Adapter.Dispose();
                if ((s_Conn != null) && (s_Conn.State == ConnectionState.Open))
                    s_Conn.Close();
                if ((d_Conn != null) && (d_Conn.State == ConnectionState.Open))
                    d_Conn.Close();
            }
        }

        private void source_Trusted_CheckedChanged(object sender, EventArgs e)
        {
            source_User.Enabled = !source_User.Enabled;
            source_Password.Enabled = !source_Password.Enabled;
        }

        private void dest_Trusted_CheckedChanged(object sender, EventArgs e)
        {
            dest_User.Enabled = !dest_User.Enabled;
            dest_Password.Enabled = !dest_Password.Enabled;
        }
    }
}
