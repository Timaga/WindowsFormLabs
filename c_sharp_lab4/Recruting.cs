using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_lab4
{
    public class Recruting
    {
        /// <summary>
        /// Словарь клиентов
        /// </summary>
        public static Dictionary<int, Aspirante> Aspirants { get; } = new Dictionary<int, Aspirante>();
        /// <summary>
        /// Словарь комнат
        /// </summary>
        public static Dictionary<int, Employer> EmployersMap { get; } = new Dictionary<int, Employer>();
        /// <summary>
        /// Спосок поселений
        /// </summary>
        public static List<Settlement> Settlements { get; } = new List<Settlement>();
    }
}
