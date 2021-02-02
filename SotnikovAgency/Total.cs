using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SotnikovAgency
{
    class Total
    {
        static public string connectionString = @"Data Source = sql.vm; Initial Catalog = sotnikov383; User ID = iam09; Password = password";
        static public string commandText = "SELECT * FROM [Users] WHERE [Login]=@Log AND [Password]=@Pas";
        static public int ID_role;
    }
}
