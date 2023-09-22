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
        public int Id { get; set; }
        public string Name { get; set; }
        public string Overview { get; set; }
        public DateTime release_date { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set;}
        public int software_house_id { get; set; }

        public Videogame(int id, string name, string overview, DateTime release_date, DateTime created_at, DateTime updated_at, int software_house_id)
        {
            Id = id;
            Name = name;
            Overview = overview;
            this.release_date = release_date;
            this.created_at = created_at;
            this.updated_at = updated_at;
            this.software_house_id = software_house_id;
        }
    }          
   
}
