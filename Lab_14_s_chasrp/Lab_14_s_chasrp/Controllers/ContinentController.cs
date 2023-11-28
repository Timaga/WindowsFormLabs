using Microsoft.AspNetCore.Mvc;
using Npgsql;
using Lab_14_s_chasrp.Models;

namespace Lab_14_s_chasrp.Controllers
{
    public class ContinentController : Controller
    {
        public IActionResult Index()
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.Development.json").Build();
            List<ContinentModel> continents = new List<ContinentModel>();
            using (var connection = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var command = new NpgsqlCommand("select * from continent", connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var continent = new ContinentModel
                    {
                        id = reader.GetInt32(0),
                        title = reader.GetString(1),
                        date_create =  reader.GetTimeSpan(2)

                    };
                    continents.Add(continent);
                }
                connection.Close();
            }

            return View(continents);
        }

        public IActionResult Insert(string title, TimeSpan date_create)
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.Development.json").Build();
            using (var connection = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var command = new NpgsqlCommand("insert into continent (title, date_create) values (@title, @date_create)", connection);
                command.Parameters.AddWithValue("title", title);
                command.Parameters.AddWithValue("date_create", date_create);               
                command.ExecuteNonQuery();
                connection.Close();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id, string title, TimeSpan date_create)
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.Development.json").Build();
            using (var connection = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var command = new NpgsqlCommand("update continent set title = @title, date_create = @date_create where id = @id", connection);
                command.Parameters.AddWithValue("id", id);
                command.Parameters.AddWithValue("title", title);
                command.Parameters.AddWithValue("date_create", date_create);
                command.ExecuteNonQuery();
                connection.Close();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.Development.json").Build();
            using (var connection = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var command = new NpgsqlCommand("delete from continent where id = @id", connection);
                command.Parameters.AddWithValue("id", id);
                command.ExecuteNonQuery();
                connection.Close();
            }
            return RedirectToAction("Index");
        
    }
    }
}
