﻿using Personal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal.Interfaces
{
    interface IPersonal
    {
        double CalculatePermission (Personals personal, Permission permission, PermissionType permissionType);
    }
}
