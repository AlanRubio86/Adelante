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
    public class ClientService
    {
        readonly IMapper mapper = AutoMapperConfiguration._mapper;
        public List<ClientModel> Get()
        {
            try
            {
                using (adelanteContext db = new adelanteContext())
                {

                    var clients = db.Clients;

                    return mapper.Map<List<ClientModel>>(clients);
                }

            }
            catch (DbEntityValidationException e)
            {
                throw e;
            }

        }

        public ClientModel GetById(int Id)
        {
            try
            {
                using (adelanteContext db = new adelanteContext())
                {
                    var client = db.Clients.Include("ClientNeighborhoods").FirstOrDefault(find => find.Id == Id);
                    return mapper.Map<ClientModel>(client);
                }

            }
            catch (DbEntityValidationException e)
            {
                throw e;
            }

        }

        public ClientModel Add(ClientModel clientModel)
        {
            try
            {
                var client = mapper.Map<Client>(clientModel);
                using (adelanteContext db = new adelanteContext())
                {
                    db.Clients.Add(client);
                    db.SaveChanges();

                }

                return mapper.Map<ClientModel>(client);
            }
            catch (DbEntityValidationException e)
            {
                throw e;
            }
        }

        public ClientModel Update(ClientModel clientModel)
        {
            try
            {
                var client = mapper.Map<Client>(clientModel);
                using (adelanteContext db = new adelanteContext())
                {
                    db.Clients.AddOrUpdate(client);
                    db.SaveChanges();
                }

                return mapper.Map<ClientModel>(client);
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
                    var client = db.Clients.Find(userId);
                    db.Clients.Remove(client);
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
