using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace GizOzApp
{
    class connection
    {
        public NpgsqlConnection GetCon()
        {
            NpgsqlConnection Conn = new NpgsqlConnection();
            Conn.ConnectionString = "Host=localhost;Port=5432;Username=GizOzGroup;Password=gizozpastibisa;Database=GizOz";
            return Conn;
        }
    }
}
