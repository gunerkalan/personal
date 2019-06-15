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
        public double CalculatePermission(Personals personal, Permission permission, PermissionType permissionType)
        {
            if (permissionType.PermissionTypeID == 1) //Mazeret İzni
            {
                if (permission.PermissionYear == DateTime.Now.Year)
                {
                    Console.WriteLine("You arent allowed to hourly permission previous year");
                    return permission.RemainingPermission;
                }
                else
                {
                    if (permission.RemainingPermission == 0)
                    {
                        Console.WriteLine("Dear" + personal.Name + personal.Surname + "you dont have enough excuse permission, but you can use yearly permiison instead of excuse permiision ");
                        return permission.RemainingPermission;
                    }
                    else
                    {
                        //Mazeret izni 22,5  saat ama değişebilir TotalPermission =22,5
                        permission.RemainingPermission = permission.TotalPermission - permission.UsedPermiision;
                        // Dataase e kalan izni remaininPermission u yaz (kalan izni), UsedPermissionu database yaz (kullanılan izin)
                        Console.WriteLine("Dear" + personal.Name + personal.Surname + "your remaining excuse permision is" + permission.RemainingPermission);
                        return permission.RemainingPermission;

                    }
                }
            }
        
             else if (permission.PermissionTypeID==2) //Yıllık İzin Günlük
            {
                permission.RemainingPermission = permission.TotalPermission - permission.UsedPermiision;
                // Dataase e kalan izni remaininPermission u yaz (kalan izni), UsedPermissionu database yaz (kullanılan izin)
                int showremaingpermission = Convert.ToInt32(Math.Floor(permission.RemainingPermission));
                //Kullanıcıya ondalıklı sayı yerine sayıyı bir alt tam sayıya yuvarlıyarak integer tam sayı gösterdik
                Console.WriteLine("Dear" + personal.Name + personal.Surname + "your remaining yearly permision is" + showremaingpermission );
                return permission.RemainingPermission;
            }

            else if (permissionType.PermissionTypeID==3) // Yıllık İzin Saatlik
            {
                //Yıllık İzin saatlikte total permiison =0 
                if (permission.UsedPermiision<4)
                {
                    Console.WriteLine("Dear" + personal.Name + personal.Surname + "you can use least four hours for yearly daily permiision");
                    // Used permissionu database e yaz
                    //Bu izin tipi için total ve remaining permiison hesabı yok 0 verilebilir
                    return permission.UsedPermiision;
                }
                else
                {
                    //Database de PermiisonType 2 ye git //Yllık İzin Günlüğe

                    permission.RemainingPermission = permission.TotalPermission - (permission.UsedPermiision/8);
                    // Dataase e kalan izni remaininPermission u yaz (kalan izni), UsedPermissionu database yaz (kullanılan izin)
                    int showremaingpermission = Convert.ToInt32(Math.Floor(permission.RemainingPermission));
                    //Kullanıcıya ondalıklı sayı yerine sayıyı bir alt tam sayıya yuvarlıyarak integer tam sayı gösterdik
                    Console.WriteLine("Dear" + personal.Name + personal.Surname + "your remaining yearly permision is" + showremaingpermission);
                    return permission.RemainingPermission;
                }
            }

            else
            {
                Console.WriteLine("Permission Type is not found !");
                return 0;
            }
        }
    }
}
