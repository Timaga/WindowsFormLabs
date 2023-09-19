using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace c_sharp_lab4
{
    public class Offers
    {
        /// <summary>
        /// Работодатель
        /// </summary>
        public string Employer { get; set; } = "Tim";
        /// <summary>
        /// Соискатель
        /// </summary>
        public string Aspirante { get; set; } = "Tim";
        /// <summary>
        /// Должность
        /// </summary>
        public string post { get; set; } = "Senior";
        /// <summary>
        /// Комиссионные
        /// </summary>
        public int Commission { get; set; } = 5355;

        public bool IsValid
        {
            get
            {
                return !String.IsNullOrEmpty(Employer) && !String.IsNullOrEmpty(Aspirante) && !String.IsNullOrEmpty(post) ;
            }
        }

        public Offers() { }

        public Offers(string name, string adress, int phoneNumber, string activity)
        {
            Employer = name;
            post = adress;
            Commission = phoneNumber;
            Aspirante = activity;
        }

        public override string ToString()
        {
            return $"Offers: {Employer},{post},{Commission},{Aspirante}";
        }
    }
}
