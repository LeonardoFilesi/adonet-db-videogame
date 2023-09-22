using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame
{
    public static class VideogameManager
    {
        private static string connectionString = "Data Source=localhost;Integrated Security=True";

        // CREATE VIDEOGAME

        public static bool AddVideogame(Videogame videogame)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO videogames (name, overview, release_date, software_house_id) VALUES (@name, @overview, @releaseDate, @softwareHouseId);";

                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@name", videogame.Name);
                    cmd.Parameters.AddWithValue("@overview", videogame.Overview);
                    cmd.Parameters.AddWithValue("@releaseDate", videogame.Release_date);
                    cmd.Parameters.AddWithValue("@softwareHouseId", videogame.Software_house_id);

                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        return true;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return false;
            }
        }

        // VIDEOGAME BY ID
        public static List<Videogame> GetVideogamesById()
        {
            List<Videogame> videogames = new List<Videogame>();
            using (SqlConnection connection = new SqlConnection(connectionString)) 
            { 
                try
                {   
                    connection.Open();

                    string query = "SELECT id, name, overview, release_date, created_at, updated_at, software_house_id FROM videogames WHERE id = @id;";
                    
                    using(SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", videogame.id);

                        using(SqlDataReader data = cmd.ExecuteReader())
                        {
                            // if (reader.Read())
                            //    {
                            //        long Id = reader.GetInt64(0);
                            //        string name = reader.GetString(1);
                            //        string overview = reader.GetString(2);
                            //        DateTime releaseDate = reader.GetDateTime(3);
                            //        long softwareHouseId = reader.GetInt64(4);
                            //
                            //        Videogame videogame = new Videogame(Id, name, overview, releaseDate, softwareHouseId);
                            //
                            //        return videogame;
                           
                                while (data.Read())
                            {
                                Videogame videogameReaded = new Videogame(data.GetInt32(0), data.GetString(1), data.GetString(2), data.GetDateTime(3), data.GetDateTime(4), data.GetDateTime(5), data.GetInt32(6));
                                videogames.Add(videogameReaded);
                            }
                        }
                    }
                } catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return videogames;
            }
        }

        // VIDEOGAME BY STRING

    }
}
