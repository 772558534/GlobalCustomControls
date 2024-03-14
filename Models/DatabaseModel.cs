using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalCustomControls
{
    public class DatabaseModel
    {
        string? sql { get; set; }

        SqlConnection? sqlCon { get; set; }
    }
}
