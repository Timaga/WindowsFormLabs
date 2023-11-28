using Microsoft.AspNetCore.Mvc;
using Npgsql;
using Lab_14_s_chasrp.Models;
using System.Xml.Linq;

namespace Lab_14_s_chasrp.Controllers
{
    public class CountryController : Controller
    {
        public IActionResult Index()
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.Development.json").Build();
            List<CountryModel> countryes = new List<CountryModel>();
            List<ContinentModel> continents = new List<ContinentModel>();
            using (var connection = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var firstCommand = new NpgsqlCommand("select * from country", connection);
                var firstReader = firstCommand.ExecuteReader();
                while (firstReader.Read())
                {
                    var country = new CountryModel
                    {
                        id = firstReader.GetInt32(0),
                        Capital = firstReader.GetString(1),
                        title = firstReader.GetString(2),
                        ContinentId = firstReader.GetInt32(3),
                        photo = firstReader.IsDBNull(4) ? null : firstReader.GetFieldValue<byte[]>(4),


                    };
                    countryes.Add(country);
                }
                firstReader.Close();
                var secondCommand = new NpgsqlCommand("select * from continent", connection);
                var secondReader = secondCommand.ExecuteReader();
                while (secondReader.Read())
                {
                    var continent = new ContinentModel
                    {
                        id = secondReader.GetInt32(0),
                        title = secondReader.GetString(1),
                        date_create = secondReader.GetTimeSpan(2)
                };
                    continents.Add(continent);
                }
                secondReader.Close();
                connection.Close();
            }
            Models.Models models = new Models.Models(countryes, continents);
            return View(models);
        }

        [HttpPost]
        public IActionResult Insert(IFormFile photo, string capital, string title, int continent_id)
        {
            byte[] imageBytes;
            using (var memoryStream = new MemoryStream())
            {
                photo.CopyTo(memoryStream);
                imageBytes = memoryStream.ToArray();
            }
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.Development.json").Build();
            using (var connection = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var command = new NpgsqlCommand("insert into country (capital, title, continent_id, photo) values (@capital, @title, @continent_id, @photo)", connection);
                command.Parameters.AddWithValue("capital", capital);
                command.Parameters.AddWithValue("title", title);
                command.Parameters.AddWithValue("continent_id", continent_id);
                command.Parameters.AddWithValue("photo", imageBytes);               
                command.ExecuteNonQuery();
                connection.Close();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Update(int id, IFormFile photo, string title, string capital, int continent_id)
        {
            byte[] imageBytes;
            using (var memoryStream = new MemoryStream())
            {
                photo.CopyTo(memoryStream);
                imageBytes = memoryStream.ToArray();
            }
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.Development.json").Build();
            using (var connection = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var command = new NpgsqlCommand("update country set capital = @capital, title = @title, continent_id = @continent_id, photo = @photo where id = @id", connection);
                command.Parameters.AddWithValue("id", id);
                command.Parameters.AddWithValue("capital", capital);
                command.Parameters.AddWithValue("title", title);
                command.Parameters.AddWithValue("continent_id", continent_id);
                command.Parameters.AddWithValue("photo", imageBytes);
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
                var command = new NpgsqlCommand("delete from country where id = @id", connection);
                command.Parameters.AddWithValue("id", id);
                command.ExecuteNonQuery();
                connection.Close();
            }
            return RedirectToAction("Index");
        }
    
}
}
