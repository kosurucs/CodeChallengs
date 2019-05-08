using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DataTable dt = new DataTable();

                foreach (string fileName1 in openFileDialog.FileNames)
                {
                    //  Process.Start(fileName1);
                    var File1 = fileName1;
                    var query = "SELECT * from [Sheet1$]";
                    StringBuilder sb = new StringBuilder();
                    using (OleDbConnection cn = new OleDbConnection { ConnectionString = ConnectionString(File1, "Yes") })
                    {
                        using (OleDbCommand cmd = new OleDbCommand { CommandText = query, Connection = cn })
                        {
                            cn.Open();

                            OleDbDataReader dr = cmd.ExecuteReader();
                            dt.Load(dr);
                            sb.Append(dt.Rows[0].ToString());
                        }
                    }
                }
            }
        }

        public string ConnectionString(string FileName, string Header)
        {
            OleDbConnectionStringBuilder Builder = new OleDbConnectionStringBuilder();
            if (Path.GetExtension(FileName).ToUpper() == ".XLSX")
            {
                // Builder.Provider = "Microsoft.Jet.OLEDB.4.0";
                Builder.Provider = "Microsoft.ACE.OLEDB.12.0";
                Builder.Add("Extended Properties", string.Format("Excel 8.0;IMEX=1;HDR={0};", Header));
            }
            else
            {
                Builder.Provider = "Microsoft.ACE.OLEDB.12.0";
                Builder.Add("Extended Properties", string.Format("Excel 12.0;IMEX=1;HDR={0};", Header));
            }

            Builder.DataSource = FileName;

            return Builder.ConnectionString;
        }
    }
}
