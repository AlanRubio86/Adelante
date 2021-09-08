using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adelante.Core.Entities;

namespace Adelante.Core.Models
{
    public class RolePermissionsModel
    {
        public PermissionModel Permission { get; set; }
    }

    public class PermissionModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
