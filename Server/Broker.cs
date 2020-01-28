using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Broker
    {
        private SqlConnection connection;
        private SqlTransaction transaction;
        private static Broker instance;

        private Broker()
        {
            //promeni bazu
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProSoft-Jul2019;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public static Broker Instance
        {
            get
            {
                if (instance == null) instance = new Broker();
                return instance;
            }
        }
    }
}
