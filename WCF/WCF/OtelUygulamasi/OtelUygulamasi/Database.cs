using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelUygulamasi
{
    public class Database
    {
        public SqlConnection baglanti = new SqlConnection(@"Data Source=CASPER_NIRVANA\SQLEXPRESS;Initial Catalog=OtelAutomation;Integrated Security=True;MultipleActiveResultSets=True");
    }
}
