using c_sharp_lab_15_1.Models;
using Microsoft.AspNetCore.Mvc;
using Npgsql;

namespace c_sharp_lab_15_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContinentController : ControllerBase
    {
        [HttpGet]
        [Route("select")]
        public IActionResult Select()
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.Development.json").Build();
            List<ContinentModel> faculties = new List<ContinentModel>();
            using (var connection = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var command = new NpgsqlCommand("select * from continent", connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var faculty = new ContinentModel
                    {
                        id = reader.GetInt32(0),
                        title = reader.GetString(1),
                        date_create = reader.GetTimeSpan(2)
                    };
                    faculties.Add(faculty);
                }
                connection.Close();
            }
            return Ok(faculties);
        }

        [HttpPost]
        [Route("insert")]
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
            return Ok(true);
        }

        [HttpPut]
        [Route("update")]
        public IActionResult Update(int id, string title, TimeSpan date_create)
        {
            try
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
                    var command = new NpgsqlCommand("delete from continent where id = @id", connection);
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
