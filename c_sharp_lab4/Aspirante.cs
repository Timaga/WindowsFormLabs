using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace c_sharp_lab4
{
    public class Aspirante : IValidatable


    {
        public int AspiranteId { get; }
        private static int _newAspiranteId;
        private static int NewAspiranteId
        {
            get
            {
                _newAspiranteId++;
                return _newAspiranteId;
            }
        }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string SecondName { get; set; } = "Buglaev";
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; } = "Tim";
        /// <summary>
        /// Отчество
        /// </summary>
        public string LastName { get; set; } = "Alekseevich";
        /// <summary>
        /// Квалификация
        /// </summary>
        public string Qualification { get; set; } = "Junior";
        /// <summary>
        /// Вид деятельности
        /// </summary>
        public string Activity { get; set; } = "Programming";
        /// <summary>
        /// Иные данные
        /// </summary>
        public string OthereData { get; set; } = "Swimming";
        /// <summary>
        /// ЗП
        /// </summary>
        public int  Wage { get; set; } = 0;

        public bool IsValid
        {
            get
            {
                return !String.IsNullOrEmpty(SecondName) && !String.IsNullOrEmpty(Activity) && !String.IsNullOrEmpty(FirstName) && !String.IsNullOrEmpty(LastName)
                    && !String.IsNullOrEmpty(Qualification) && !String.IsNullOrEmpty(OthereData);
            }
        }

        public Aspirante()
        {
            AspiranteId = NewAspiranteId;
        }

        Aspirante(string secondName, string firstName, string lastName, string qualification, string activity, string othereData, int wage)
        {
            AspiranteId = NewAspiranteId;
            SecondName = secondName;
            FirstName = firstName;
            LastName = lastName;
            Qualification = qualification;
            Activity = activity;
            OthereData = othereData;
            Wage = wage;
        }

        public override string ToString()
        {
            return $"Aspirante: {FirstName},{SecondName},{LastName},{Activity},{Qualification},{OthereData},{Wage}";
        }

    }
}
