using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelConnector
{
    public class Program
    {
        static void Main(string[] args)
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
                    using (OleDbConnection cn = new OleDbConnection { ConnectionString = ConnectionString(File1, "Yes") })
                    {
                        using (OleDbCommand cmd = new OleDbCommand { CommandText = query, Connection = cn })
                        {
                            cn.Open();

                            OleDbDataReader dr = cmd.ExecuteReader();
                            dt.Load(dr);
                        }
                    }
                }
            }
        }
    }
}
