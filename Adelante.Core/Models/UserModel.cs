﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adelante.Core.Models
{
    public class UserModel
    {
        public List<UserRoleModel> UserRoles { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string CellPhone { get; set; }

        public string UserName { get; set; }

        public string Nickname { get; set; }

        public string Password { get; set; }

        public bool Active { get; set; }

        public int RoleId { get; set; }

    }
}
