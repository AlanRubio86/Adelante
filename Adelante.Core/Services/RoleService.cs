using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adelante.Core.AutoMapper;
using Adelante.Core.Entities;
using Adelante.Core.Models;
using AutoMapper;

namespace Adelante.Core.Services
{
    public class RoleService
    {
        readonly IMapper mapper = AutoMapperConfiguration._mapper;
        public List<RoleModel> Get()
        {
            try
            {
                using (adelanteContext db = new adelanteContext())
                {

                    var roles = db.Roles;

                    return mapper.Map<List<RoleModel>>(roles);
                }

            }
            catch (DbEntityValidationException e)
            {
                throw e;
            }
        }

        public List<RolePermissionsModel> GetPermissionByRole(int roleId)
        {
            try
            {
                using (adelanteContext db = new adelanteContext())
                {

                    var permissions = db.RolePermissions.Where(x=>x.IdRole==roleId);

                    return mapper.Map<List<RolePermissionsModel>>(permissions);
                }

            }
            catch (DbEntityValidationException e)
            {
                throw e;
            }
        }
    }
}
