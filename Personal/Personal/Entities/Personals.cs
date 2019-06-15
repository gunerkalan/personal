using Personal.Interfaces;
using Personal.PersonalManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal.Entities
{
    public class Personals
    {
        public Personals()
        {
            Handler = new PersonalHandler();
        }


        public int PersonalId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }

        public IPersonalHandler Handler { get; set; }
    }
}
