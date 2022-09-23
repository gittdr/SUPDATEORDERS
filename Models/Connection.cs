using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace TLIVERDED.Models
{
    public sealed class Connection
    {
        private const string database = "miConexion";
        public string connectionString;

        public string ConnectionString
        {
            get
            {
                return this.connectionString;
            }
            private set
            {
                this.connectionString = value;
            }
        }

        public Connection()
        {
            this.ConnectionString = WebConfigurationManager.ConnectionStrings["miConexion"].ConnectionString;
        }
    }
}
