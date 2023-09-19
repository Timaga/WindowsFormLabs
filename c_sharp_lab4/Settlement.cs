using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_lab4
{
    public class Settlement : IValidatable
    {
        /// <summary>
        /// Клиент
        /// </summary>
        public Employer Employer { get; set; }
        /// <summary>
        /// Номер
        /// </summary>
        public Aspirante Aspirante { get; set; }
        /// <summary>
        /// Дата начала проживания
        /// </summary>
          public string post { get; set; } = "Senior";
        /// <summary>
        /// Комиссионные
        /// </summary>
        public int Commission { get; set; } = 5355;
        public DateTime StartDate { get; set; } = DateTime.Now;
        /// <summary>
        /// Дата окончания проживания
        /// </summary>
        public DateTime EndDate { get; set; } = DateTime.Now;

        public bool IsValid
        {
            get
            {
                if (Employer == null) return false;
                if (Aspirante == null) return false;
                if (EndDate <= StartDate) return false;
                return true;
            }
        }

        public Settlement()
        {

        }

        public Settlement(Employer employer, Aspirante aspirante, DateTime startDate, DateTime endDate)
        {
            Employer = employer;
            Aspirante = aspirante;
            StartDate = startDate;
            EndDate = endDate;
        }

        public override string ToString()
        {
            return "fad";
          //  return $"Клиент - {Client}\r\nНомер - {Room}\r\nПериод: {StartDate}-{EndDate}\r\n";
        }
    }
}
