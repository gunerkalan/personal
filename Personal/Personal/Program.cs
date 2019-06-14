using Personal.PersonalManageras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Personal
{
    class Program
    {

        static void Main(string[] args)
        {
            PersonalManager personalManager = new PersonalManager();
            personalManager.CalculatePermiisionPermisiion(new Entities.Personals
            {
                PersonalId=1,
                Name = "Güner",
                Surname = "Kalan",
                PermiisionYear = 2019,
                PermissionType ="Daily",
                TotalPermission = 28,
                UsedPermiision =5
            });

            Console.ReadKey();
        }
    }
}
