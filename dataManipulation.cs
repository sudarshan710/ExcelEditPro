using ExcelEditPro;
using System.Data;
using System.Data.OleDb;

public class dataManipulation : IExcelDataAccess
{

    public DataTable Display(DataTable dt, string filePath)
    {
        OleDbConnection conn = new OleDbConnection(filePath);
        return dt;
    }
}