using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal.Entities
{
    public class Personals
    {
        public int PersonalId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PermissionYear { get; set; }
        public double PermiisionYear { get; set; }
        public double UsedPermiision { get; set; }
        public double TotalPermission { get; set; }
        public double RemainingPermission { get; set; }
        public string PermissionType { get; set; }
    }
}
