using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutodDB_Orlenko.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Новые поля для времени работы услуги
        public TimeSpan StartTime { get; set; }    // Когда начинается работа над этой услугой
        public TimeSpan Duration { get; set; }     // Сколько времени занимает эта услуга

        public ICollection<CarService> CarServices { get; set; }
    }
}