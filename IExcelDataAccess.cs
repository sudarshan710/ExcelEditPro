using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelEditPro
{
    internal interface IExcelDataAccess
    {
        DataTable Display(DataTable dt, string filePath);
    }
}
