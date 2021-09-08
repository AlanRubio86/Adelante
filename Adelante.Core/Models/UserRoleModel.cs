﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adelante.Core.Models
{
    public class UserRoleModel
    {
        public RoleModel Role { get; set; }

    }

    public class RoleModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<RolePermissionsModel> RolePermissions { get; set; }
    }
}
