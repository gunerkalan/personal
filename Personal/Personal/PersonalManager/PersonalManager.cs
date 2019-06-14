using Personal.Entities;
using Personal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal.PersonalManageras
{
    public class PersonalManager : IPersonal
    {
        public int CalculatePermiisionPermisiion(Personals personal)
        {
            if (personal.PermissionType == "Daily")
                return Convert.ToInt32(personal.RemainingPermission = personal.TotalPermission - personal.UsedPermiision);
                 //Console.WriteLine("Kalan izni veri tabanına double olarak kaydet")
               /*
                * İzin tipi günlük ise toplam izinden kullanılan izni çıkarıp bir kalan izne atıyoruz, kalan izni veritabanında double olarak kayededip
                * personele int olarak veriyoruz
                */
            else if (personal.PermissionType == "Horly")
                return Convert.ToInt32(Math.Floor(personal.RemainingPermission = personal.TotalPermission - personal.UsedPermiision / 24));
               /*
                *İzin tipi günlük ise toplam izinden kulanılan izni güne çevirip çıkarıyoruz
                * Kalan izni veritabanına double olarak kaydediyoruz
                * Kullanıcıya kalan izni görünülemek için double sayıyı bir alt int sayıya çevirip veriyoruz
                */
            else
                Console.WriteLine("Permission Type is not found !");
                return 0;

        }

        internal void CalculatePersonalPermission()
        {
            CalculatePermiisionPermisiion(new Personals
            {
                PersonalId = 1,
                Name = "Güner",
                Surname = "Kalan",
                    
            });
        }
    }
}
