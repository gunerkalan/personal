using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal.Entities
{
    public class Permission
    {
        public int PermissionID { get; set; }
        public int PersonelID { get; set; }
        public int PermissionTypeID { get; set; }
        public double UsedPermiision { get; set; }
        public double TotalPermission { get; set; }
        public double RemainingPermission { get; set; }
        public int PermissionYear { get; set; }
    }
}
