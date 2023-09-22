using System;
using System.Collections.Generic;
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
    }          
   
}
