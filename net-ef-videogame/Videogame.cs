using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame
{
    public class Videogame
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Overview { get; set; }
        public DateTime Release_date { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set;}
        public long Software_house_id { get; set; }

        public Videogame(long id, string name, string overview, DateTime release_date, DateTime created_at, DateTime updated_at, long software_house_id)
        {
            Id = id;
            Name = name;
            Overview = overview;
            Release_date = release_date;
            Created_at = created_at;
            Updated_at = updated_at;
            Software_house_id = software_house_id;
        }

        public override string ToString()
        {
            return $"ID: {Id}, {Name} -- {Overview} -- {Release_date}";
        }
    }          
   
}
