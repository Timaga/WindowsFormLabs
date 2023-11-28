using Microsoft.AspNetCore.Mvc;
using Npgsql;
using c_sharp_lab_15_1.Models;

namespace c_sharp_lab_15_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        [HttpGet]
        [Route("select")]
        public IActionResult Select()
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.Development.json").Build();
            List<CountryModel> departments = new List<CountryModel>();
            using (var connection = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var command = new NpgsqlCommand("select * from country", connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var department = new CountryModel
                    {
                        id = reader.GetInt32(0),
                        Capital = reader.GetString(1),
                        title = reader.GetString(2),
                        ContinentId = reader.GetInt32(3),
                        photo = reader.IsDBNull(4) ? null : reader.GetFieldValue<byte[]>(4),
                    };
                    departments.Add(department);
                }
                connection.Close();
            }
            return Ok(departments);
        }

        [HttpPost]
        [Route("insert")]
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
            return Ok(true);
        }

        [HttpPut]
        [Route("update")]
        public IActionResult Update(int id, IFormFile photo, string title, string capital, int continent_id)
        {
            try
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
                return Ok(true);
            }
            catch
            {
                return Ok(false);
            }
        }

        [HttpDelete]
        [Route("delete")]
        public IActionResult Delete(int id)
        {
            try
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
                return Ok(true);
            }
            catch
            {
                return Ok(false);
            }
        }
    }
}
