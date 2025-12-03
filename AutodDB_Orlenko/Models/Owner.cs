using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutodDB_Orlenko.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}