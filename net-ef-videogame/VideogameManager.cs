using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame
{
    public static class VideogameManager
    {
        private static string stringConnection = "Data Source=localhost;Integrated Security=True";
        
        public List<Videogame> GetVideogames()
        {
            using(SqlConnection connection = new SqlConnection(connectionString)) { }
        }
    }
}
