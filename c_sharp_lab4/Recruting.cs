using c_sharp_lab4.Exeptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_lab4
{
    public class Recruting
    {
        private static Recruting _instance;
        /// <summary>
        /// Единственный экземпляр класса Отель
        /// </summary>
        public static Recruting Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Recruting();
                }
                return _instance;
            }
        }
        /// <summary>
        /// Словарь клиентов
        /// </summary>
        public static Dictionary<int, Aspirante> _aspirants = new Dictionary<int, Aspirante>();
        /// <summary>
        /// Словарь комнат
        /// </summary>
        public static Dictionary<int, Employer> _employersMap = new Dictionary<int, Employer>();
        /// <summary>
        /// Спосок поселений
        /// </summary>
        public static List<Settlement> _settlements = new List<Settlement>();
        private Recruting()
        {

        }

        public IEnumerable<Aspirante> Aspirantes
        {
            get { return _aspirants.Values.AsEnumerable(); }
        }

        /// <summary>
        /// Коллекция номеров
        /// </summary>
        public IEnumerable<Employer> Employers
        {
            get
            {
                return _employersMap.Values.AsEnumerable();
            }
        }
        /// <summary>
        /// Коллекция поселений
        /// </summary>
        /// 

        public IEnumerable<Settlement> Settlements
        {
            get
            {
                return _settlements;
            }
        }

        public event EventHandler AspiranteAdded;
        public event EventHandler EmployerAdded;
        public event EventHandler SettlementAdded;
        public event EventHandler AspiranteRemoved;
        public event EventHandler EmployerRemoved;
        public event EventHandler SettlementRemoved;
        /// <summary>
        /// Добавление клиента
        /// </summary>
        /// <param name="aspirante">Информация о соискателе</param>
        /// 
        public void AddAspirante(Aspirante aspirante)
        {
            if (!aspirante.IsValid)
            {
                throw new InvalidAspiranteException("Информация о соискателе заполнена некорректно");
            }
            try
            {
                _aspirants.Add(aspirante.AspiranteId, aspirante);
                //Герерируем событие о том, что клиент добавлен
                AspiranteAdded?.Invoke(aspirante, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new InvalidAspiranteException("При добавлении соискателя произошла ошибка", exception);
            }

        }
        /// <summary>
        /// Добавление работодателя
        /// </summary>
        /// <param name="employer">Информация о работодателе</param>
        public void AddEmployer(Employer employer)
        {
            if (!employer.IsValid)
            {
                throw new InvalidEmployerException("Информация о работодателе заполнена некорректно");
            }
            try
            {
                _employersMap.Add(employer.EmployerId, employer);
                //Герерируем событие о том, что номер добавлен
                EmployerAdded?.Invoke(employer, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new InvalidEmployerException("При добавлении Работодателя произошла ошибка", exception);
            }
        }

        /// <summary>
        /// Информация о сделке
        /// </summary>
        /// <param name="settlement"></param>
        public void AddSettlement(Settlement settlement)
        {
            if (!settlement.IsValid)
            {
                throw new InvalidSettlementException("Информация о сделке заполнена некорректно");
            }
            try
            {
                _settlements.Add(settlement);
                //Герерируем событие о том, что информация о сделке добавлена
                SettlementAdded?.Invoke(settlement, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new InvalidSettlementException("При сделке произошла ошибка", exception);
            }
        }

        /// <summary>
        /// Удалить cоискателя по идентификатору
        /// </summary>
        /// <param name="AspiranteKey">Идентификатор соискателя</param>
        public void RemoveAspirante(int AspiranteKey)
        {
            _aspirants.Remove(AspiranteKey);
            //Генерируем событие о том, что клиент удалён
            AspiranteRemoved?.Invoke(AspiranteKey, EventArgs.Empty);
            //Получаем список сведений о поселении клиента
                var settlementsForClient = Settlements.Where(s => s.Aspirante.AspiranteId == AspiranteKey).ToList();
            for (int i = 0; i < settlementsForClient.Count; i++)
            {
                //Удаляем сведения о поселении клиента
                RemoveSettlement(settlementsForClient[i]);
            }
        }
        /// <summary>
        /// Удалить работодателя по идентификатору
        /// </summary>
        /// <param name="EmployerKey"></param>
        public void RemoveEmployer(int EmployerKey)
        {
            _employersMap.Remove(EmployerKey);
            //Генерируем событие о том, что номер удалён
            EmployerRemoved?.Invoke(EmployerKey, EventArgs.Empty);
            //Получаем список сведений о поселении в номер
            var settlementsForRoom = Settlements.Where(s => s.Employer.EmployerId == EmployerKey).ToList();
            for (int i = 0; i < settlementsForRoom.Count; i++)
            {
                //Удаляем сведения о поселении в номер
                RemoveSettlement(settlementsForRoom[i]);
            }
        }
        /// <summary>
        /// Удалить информацию о поселении
        /// </summary>
        /// <param name="settlement">Информация о поселении</param>
        public void RemoveSettlement(Settlement settlement)
        {
            _settlements.Remove(settlement);
            //Генерируем событие о том, что информация о поселении удалена
            SettlementRemoved?.Invoke(settlement, EventArgs.Empty);
        }
    }
}
