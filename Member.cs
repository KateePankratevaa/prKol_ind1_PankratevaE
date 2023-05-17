using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ИЗ2
{
    class Member
    {
       
        public string surname { get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }
        public string pol { get; set; }
        public string age { get; set; }
        public string salary { get; set; }
        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}",
                surname,
                name,
                patronymic,
                pol,
                age,
                salary);
        }
    }
}
