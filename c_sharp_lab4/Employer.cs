using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_lab4
{
    public class Employer : IValidatable
    { /// <summary>
      /// Имя
      /// </summary>
        public string Name { get; set; } = "Tim";

        /// <summary>
        /// Адресс
        /// </summary>
        public string Adress { get; set; } = "Bryansk";
        /// <summary>
        /// Номер телефона
        /// </summary>
        public string PhoneNumber { get; set; } = "+79142145143";
        /// <summary>
        /// Вид деятельности
        /// </summary>
        public string Activity { get; set; } = "Programming";

        public bool IsValid
        {
            get
            {
                return !String.IsNullOrEmpty(Name) && !String.IsNullOrEmpty(Activity) && !String.IsNullOrEmpty(Adress) && !String.IsNullOrEmpty(PhoneNumber);
            }
        }

        public Employer() { }
         
        public Employer(string name, string adress, string phoneNumber, string activity)
        {
            Name = name;
            Adress = adress;
            PhoneNumber = phoneNumber;
            Activity = activity;
        }

        public override string ToString()
        {
            return $"Employer: {Name},{Adress},{PhoneNumber},{Activity}";
        }
    }
}
