using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Adelante.Core.AutoMapper;
using Adelante.Core.Entities;
using Adelante.Core.Helpers;
using Adelante.Core.Models;
using AutoMapper;

namespace Adelante.Core.Services
{
    public class SessionService
    {
        readonly IMapper mapper = AutoMapperConfiguration._mapper;
        public UserModel Login(string username, string userPassword)
        {
            try
            {
                UserModel result = null;
                using (adelanteContext db = new adelanteContext())
                {

                    var user = db.Users.Include("UserRoles.Role.RolePermissions").FirstOrDefault(find => find.UserName == username); 
                    if (user == null)
                    {
                        throw new Exception("User doesn't exists");
                    }

                    if (AuthenticationHelper.ValidateCredentials(user, userPassword))
                    {
                        result = mapper.Map<UserModel>(user);
                    }

                }

                return result;
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
           
        }
    }
}
