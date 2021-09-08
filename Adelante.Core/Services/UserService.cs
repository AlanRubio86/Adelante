using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using Adelante.Core.AutoMapper;
using Adelante.Core.Entities;
using Adelante.Core.Helpers;
using Adelante.Core.Models;
using AutoMapper;

namespace Adelante.Core.Services
{
    public class UserService
    {
        readonly IMapper mapper = AutoMapperConfiguration._mapper;


        public int MaxId()
        {
            try
            {
                using (adelanteContext db = new adelanteContext())
                {

                    return db.Users.Max(p=> p.Id) + 1;

                }

            }
            catch (DbEntityValidationException e)
            {
                throw e;
            }

        }

        public List<UserModel> Get()
        {
            try
            {
                using (adelanteContext db = new adelanteContext())
                {
                 
                    var users = db.Users;

                    return mapper.Map<List<UserModel>>(users);
                }

            }
            catch (DbEntityValidationException e)
            {
                throw e;
            }

        }

        public UserModel GetById(int Id)
        {
            try
            {
                using (adelanteContext db = new adelanteContext())
                {
                    var user = db.Users.Include("UserRoles.Role.RolePermissions").FirstOrDefault(find => find.Id ==Id);
                    if (user == null)
                    {
                        throw new Exception("User doesn't exists");
                    }

                    return mapper.Map<UserModel>(user);
                }

            }
            catch (DbEntityValidationException e)
            {
                throw e;
            }

        }

        public UserModel Add(UserModel userModel)
        {
            try
            {
                var user = mapper.Map<User>(userModel);
                using (adelanteContext db = new adelanteContext())
                {
                    user.Password = AuthenticationHelper.Encrypt(userModel.Password);
                    UserRole userRole = new UserRole
                    {
                        RoleId = userModel.RoleId
                    };

                    user.UserRoles.Add(userRole);
                    db.Users.Add(user);
                    db.SaveChanges();

                }

                return mapper.Map<UserModel>(user);
            }
            catch (DbEntityValidationException e)
            {
                throw e;
            }
        }

        public UserModel Update(UserModel userModel)
        {
            try
            {
                var user = mapper.Map<User>(userModel);
                using (adelanteContext db = new adelanteContext())
                {
                    user.Password = AuthenticationHelper.Encrypt(userModel.Password);
                    db.Users.AddOrUpdate(user);
                    db.SaveChanges();
                }

                return mapper.Map<UserModel>(user);
            }
            catch (DbEntityValidationException e)
            {
                throw e;
            }
        }

        public bool Delete(int userId)
        {
            try
            {
                using (adelanteContext db = new adelanteContext())
                {
                    var user = db.Users.Find(userId);
                    db.Users.Remove(user);
                    db.SaveChanges();
                }

                return true;
            }
            catch (DbEntityValidationException e)
            {
                throw e;
            }
        }

    }
}
