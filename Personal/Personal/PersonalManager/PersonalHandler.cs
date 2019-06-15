using Personal.Entities;
using Personal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal.PersonalManager
{
    public class PersonalHandler : IPersonalHandler
    {
        public void PersonalBirthDate(Personals personal)
        {
            if (personal.BirthDate == DateTime.Now)
            {
                Console.WriteLine("Happy BirthDate Dear" + personal.Name + personal.Surname);
            }
        }
    }
}
