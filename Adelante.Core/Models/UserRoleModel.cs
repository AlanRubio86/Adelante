using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adelante.Core.Models
{
    public class UserRoleModel
    {
        public string Name { get; set; }
        public List<RolePermissionsModel> Permissions { get; set; }
    }
}
