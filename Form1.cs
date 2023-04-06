using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ExcelEditPro

{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        dataManipulation dataManip = new dataManipulation();
        private void uploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Files|*.xlsx;*.xls|All Files|*.*";
            ofd.Title = "Select an Excel file";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileLoc = ofd.FileName;

                // Save filepath to global var
                Program.filePath = fileLoc;

                // Label Check for Filepath
                path.Text = fileLoc;

                DataTable dt = new DataTable();

                dt = dataManip.Display(dt, fileLoc);

                dataGrid.DataSource = dt;
            }
        }
    }
}