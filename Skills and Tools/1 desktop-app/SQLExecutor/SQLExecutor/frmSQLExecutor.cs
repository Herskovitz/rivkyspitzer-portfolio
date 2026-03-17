using System.Data;
using System.Data.SqlClient;

namespace SQLExecutor
{
    public partial class frmSQLExecutor : Form
    {
        private enum ServerTypeEnum { Local, Azure }
        private enum DatabaseEnum { RecordKeeperDB, RecipeDB }

        ServerTypeEnum server = ServerTypeEnum.Local;
        DatabaseEnum database = DatabaseEnum.RecordKeeperDB;



        public frmSQLExecutor()
        {
            InitializeComponent();
            btnRun.Click += BtnRun_Click;
        }



        private string GetConnectionString(DatabaseEnum db = DatabaseEnum.RecordKeeperDB)
        {
            var s = "Server=.\\SQLExpress;Database=" + db + ";Trusted_Connection=true";

            if (optAzure.Checked == true)
            {
                s = "Server=tcp:rherskovitz.database.windows.net,1433;Initial Catalog=" + db + ";Persist Security Info=False;User ID=RH-Admin;Password=Git4607!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            }

            return s;
        }



        private DataTable GetDataTable(string sqlstatement)
        {

            DataTable dt = new();
            SqlConnection conn = new();
            if (optRecipe.Checked == true)
            {
                conn.ConnectionString = GetConnectionString(DatabaseEnum.RecipeDB);
            }
            else
                conn.ConnectionString = GetConnectionString();
            conn.Open();
            SqlCommand cmd = new();
            cmd.Connection = conn;
            cmd.CommandText = sqlstatement;
            var dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }


        private void BtnRun_Click(object? sender, EventArgs e)
        {
            //SM do this as 2 seperate if else statements, one for server and one for db.
            //Because now you might unnecessarily update variables.
            //if (optRecipe.Checked && optLocal.Checked)
            //{
            //    server = ServerTypeEnum.Local;
            //    database = DatabaseEnum.RecipeDB;
            //}
            //else if (optRecipe.Checked && optAzure.Checked)
            //{
            //    server = ServerTypeEnum.Azure;
            //    database = DatabaseEnum.RecipeDB;
            //}
            //else if (optRecordKeeper.Checked && optLocal.Checked)
            //{
            //    server = ServerTypeEnum.Local;
            //    database = DatabaseEnum.RecordKeeperDB;
            //}
            //else if (optRecordKeeper.Checked && optAzure.Checked)
            //{
            //    server = ServerTypeEnum.Azure;
            //    database = DatabaseEnum.RecordKeeperDB;
            //}


            /////////
            ///

            if (optLocal.Checked)
            {
                server = ServerTypeEnum.Local;

                if (optRecordKeeper.Checked)
                {
                    database = DatabaseEnum.RecordKeeperDB;
                }
                else if (optRecipe.Checked)
                {
                    database = DatabaseEnum.RecipeDB;
                }
            }
            if (optAzure.Checked)
            {
                server = ServerTypeEnum.Azure;

                if (optRecordKeeper.Checked)
                {
                    database = DatabaseEnum.RecordKeeperDB;
                }
                else if (optRecipe.Checked)
                {
                    database = DatabaseEnum.RecipeDB;
                }
            }



            var name = "Query #" + (tabMain.TabPages.Count + 1).ToString() + " - " + server + " " + database;

            TabPage p = new(name);
            tabMain.TabPages.Add(p);
            DataGridView g = new() { Dock = DockStyle.Fill };
            DataTable dt = GetDataTable(txtQuery.Text);
            g.DataSource = dt;
            p.Controls.Add(g);
            tabMain.SelectedTab = p;
        }

    }
}

