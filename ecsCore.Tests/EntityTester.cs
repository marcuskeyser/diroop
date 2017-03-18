using ecsCore.Data;
using ecsCore.Domain.POCO;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Xunit.Abstractions;
using ecsCore.Data.Repositories;

namespace ecsCore.Tests
{
    public partial class EntityTester : _TesterMethods
    {
        #region METHODS  

        //Interfaces
        private readonly ITestOutputHelper _output;
        //Constructor
        public EntityTester(ITestOutputHelper output)
        {
            _output = output;
        }
        //Methods
        private void SaveEntityChanges(Entity myNewEntity)
        {
            try
            {
                using (var ctx = new DataContext())
                {
                    ctx.GetService<ILoggerFactory>().AddProvider(new ecsLoggerService());
                    ctx.Entities.Add(myNewEntity);
                    ctx.SaveChanges();
                    PassTest();
                }
            }
            catch (Exception ex)
            {
                _output.WriteLine(ex.Message);
                _output.WriteLine(ex.InnerException.ToString());
                FailTest();
            }
        }
        private List<Entity> GetEntity()
        {
            //FromRepo
            try
            {
                EntitiesRepository repo = new EntitiesRepository();
                List<Entity> results = repo.SelectAll();
                PassTest();
                return results;
            }
            catch (Exception ex)
            {
                _output.WriteLine(ex.Message);
                _output.WriteLine(ex.InnerException.ToString());
                FailTest();
                return null;
            }
        }
        private List<Entity> GetEntityFromDbContext()
        {
            List<Entity> results;
            try
            {
                using (var ctx = new DataContext())
                {
                    ctx.GetService<ILoggerFactory>().AddProvider(new ecsLoggerService());
                    results = ctx.Entities.ToList();
                    PassTest();
                    return results;
                }
            }
            catch (Exception ex)
            {
                _output.WriteLine(ex.Message);
                _output.WriteLine(ex.InnerException.ToString());
                FailTest();
                return null;
            }            
        }
        #endregion METHODS
        #region SIMPLE INSERT TESTS
        [Fact]
        public void InsertEntity()
        {
            var debugToken = "InsertEntity()";
            Entity myNewEntity = new Entity { Type = 0, SecurityType = 1, DebugToken = debugToken };
            SaveEntityChanges(myNewEntity);
        }
        [Fact]
        public void InsertEntityAndName()
        {
            var debugToken = "InsertEntityAndName()";
            Entity myNewEntity = new Entity { Type = 0, SecurityType = 1, DebugToken = debugToken };
            EntityName myNewEntityName = new EntityName { First = "joe", Last = "blow", Type = 0, DebugToken = debugToken };
            myNewEntity.Names.Add(myNewEntityName);
            SaveEntityChanges(myNewEntity);
        }
        [Fact]
        public void InsertEntityAndAddress()
        {
            var debugToken = "InsertEntityAndAddress()";
            Entity myNewEntity = new Entity { Type = 0, SecurityType = 1, DebugToken = debugToken };
            EntityAddress myNewEntityAddress = new EntityAddress { Address1 = "addy1", City = "MyCity", State = "MyState", PostalCode = "12345", Country="whoknows", Type = 0 };
            myNewEntity.Addresses.Add(myNewEntityAddress);
            SaveEntityChanges(myNewEntity);
        }
        [Fact]
        public void InsertEntityAndPhone()
        {
            var debugToken = "InsertEntityAndPhone()";
            Entity myNewEntity = new Entity { Type = 0, SecurityType = 1, DebugToken = debugToken };
            EntityPhone myNewEntityPhone = new EntityPhone { Type = 0, Phone = "1112223333" };
            myNewEntity.Phones.Add(myNewEntityPhone);
            SaveEntityChanges(myNewEntity);
        }
        [Fact]
        public void InsertEntityAndEmail()
        {
            var debugToken = "InsertEntityAndEmail()";
            Entity myNewEntity = new Entity { Type = 0, SecurityType = 1, DebugToken = debugToken };
            EntityEmail myNewEntityEmail = new EntityEmail { Type = 0, Email = "my@email.com" };
            myNewEntity.Emails.Add(myNewEntityEmail);
            SaveEntityChanges(myNewEntity);
        }
        [Fact]
        public void InsertEntityAndEntityCreditCard()
        {
            var debugToken = "InsertEntityAndCreditCard()";
            Entity myNewEntity = new Entity { Type = 0, SecurityType = 1, DebugToken = debugToken };
            EntityCreditCard myNewEntityCreditCard = new EntityCreditCard { Type = 0, CC = "123", Code = 123, ExpirationMonth = "2", ExpirationYear = "2017" };
            myNewEntity.CreditCards.Add(myNewEntityCreditCard);
            SaveEntityChanges(myNewEntity);
        }
        [Fact]
        public void InsertEntityAndSocialMedia()
        {
            var debugToken = "InsertEntityAndSocialMedia()";
            Entity myNewEntity = new Entity { Type = 0, SecurityType = 1, DebugToken = debugToken };
            EntitySocialMedia myNewEntitySocialMedia = new EntitySocialMedia { Type = 0, Url="somethingcool.com",Login = "login", PW = "pw" };
            myNewEntity.SocialMedia.Add(myNewEntitySocialMedia);
            SaveEntityChanges(myNewEntity);
        }
        //[Fact]
        //public void InsertEntityAndRelationship()
        //{
        //    var debugToken = "InsertEntityAndRelationship()";
        //    Entity myNewEntity = new Entity { Type = 0, SecurityType = 1, DebugToken = debugToken };
        //    var myNewEntityName = new EntityName { First = "joe", Last = "blow", Type = 0 };
        //    myNewEntity.Names.Add(myNewEntityName);
        //    SaveEntityChanges(myNewEntity);
        //}
        #endregion SIMPLE INSERT TESTS
        #region GRAPH INSERT TESTS
        [Fact]
        public void InsertEntityGraphSingles()
        {
            var debugToken = "InsertEntityGraphSingles()";
            Entity myNewEntity = new Entity { Type = 0, SecurityType = 1, DebugToken = debugToken };
            EntityName myNewEntityName = new EntityName { First = "joe", Last = "blow", Type = 0, DebugToken = debugToken };
            EntityAddress myNewEntityAddress = new EntityAddress { Address1 = "addy1", City = "MyCity", State = "MyState", PostalCode = "12345", Country = "whoknows", Type = 0 };
            EntityPhone myNewEntityPhone = new EntityPhone { Type = 0, Phone = "1112223333" };
            EntityEmail myNewEntityEmail = new EntityEmail { Type = 0, Email = "my@email.com" };
            EntityCreditCard myNewEntityCreditCard = new EntityCreditCard { Type = 0, CC = "123", Code = 123, ExpirationMonth = "2", ExpirationYear = "2017" };
            EntitySocialMedia myNewEntitySocialMedia = new EntitySocialMedia { Type = 0, Url = "somethingcool.com", Login = "login", PW = "pw" };
            myNewEntity.Names.Add(myNewEntityName);
            myNewEntity.Addresses.Add(myNewEntityAddress);
            myNewEntity.Phones.Add(myNewEntityPhone);
            myNewEntity.Emails.Add(myNewEntityEmail);
            myNewEntity.CreditCards.Add(myNewEntityCreditCard);
            myNewEntity.SocialMedia.Add(myNewEntitySocialMedia);
            SaveEntityChanges(myNewEntity);
        }
        [Fact]
        public void InsertEntityGraphBatch()
        {
            var debugToken = "InsertEntityGraphBatch()";
            Entity myNewEntity = new Entity { Type = 0, SecurityType = 1, DebugToken = debugToken };

            List<EntityName> myNewEntityName = new List<EntityName>();
            myNewEntityName.Add(new EntityName { First = "joe", Last = "blow", Type = 0, DebugToken = debugToken });
            myNewEntityName.Add(new EntityName { First = "bob", Last = "bull", Type = 0, DebugToken = debugToken });
            myNewEntityName.Add(new EntityName { First = "cliff", Last = "hanger", Type = 0, DebugToken = debugToken });

            List<EntityAddress> myNewEntityAddress = new List<EntityAddress>();
            myNewEntityAddress.Add(new EntityAddress { Address1 = "addy1", City = "MyCity", State = "MyState", PostalCode = "12345", Country = "whoknows", Type = 0 });
            myNewEntityAddress.Add(new EntityAddress { Address1 = "addy2", City = "MyCity", State = "MyState", PostalCode = "12345", Country = "whoknows", Type = 0 });
            myNewEntityAddress.Add(new EntityAddress { Address1 = "addy3", City = "MyCity", State = "MyState", PostalCode = "12345", Country = "whoknows", Type = 0 });

            List< EntityPhone> myNewEntityPhone = new List<EntityPhone>();
            myNewEntityPhone.Add(new EntityPhone { Type = 0, Phone = "1001001000" });
            myNewEntityPhone.Add(new EntityPhone { Type = 0, Phone = "2002002000" });
            myNewEntityPhone.Add(new EntityPhone { Type = 0, Phone = "3003003000" });

            List< EntityEmail> myNewEntityEmail = new List<EntityEmail>();
            myNewEntityEmail.Add(new EntityEmail { Type = 0, Email = "my1@email.com" });
            myNewEntityEmail.Add(new EntityEmail { Type = 0, Email = "my2@email.com" });
            myNewEntityEmail.Add(new EntityEmail { Type = 0, Email = "my3@email.com" });

            List< EntityCreditCard> myNewEntityCreditCard = new List<EntityCreditCard>();
            myNewEntityCreditCard.Add(new EntityCreditCard { Type = 0, CC = "100", Code = 123, ExpirationMonth = "2", ExpirationYear = "2017" });
            myNewEntityCreditCard.Add(new EntityCreditCard { Type = 0, CC = "200", Code = 123, ExpirationMonth = "2", ExpirationYear = "2017" });
            myNewEntityCreditCard.Add(new EntityCreditCard { Type = 0, CC = "300", Code = 123, ExpirationMonth = "2", ExpirationYear = "2017" });

            List< EntitySocialMedia> myNewEntitySocialMedia = new List<EntitySocialMedia>();
            myNewEntitySocialMedia.Add(new EntitySocialMedia { Type = 0, Url = "1somethingcool.com", Login = "login", PW = "pw" });
            myNewEntitySocialMedia.Add(new EntitySocialMedia { Type = 0, Url = "2somethingcool.com", Login = "login", PW = "pw" });
            myNewEntitySocialMedia.Add(new EntitySocialMedia { Type = 0, Url = "3somethingcool.com", Login = "login", PW = "pw" });

            myNewEntity.Names= myNewEntityName;
            myNewEntity.Addresses= myNewEntityAddress;
            myNewEntity.Phones= myNewEntityPhone;
            myNewEntity.Emails= myNewEntityEmail;
            myNewEntity.CreditCards= myNewEntityCreditCard;
            myNewEntity.SocialMedia= myNewEntitySocialMedia;
            SaveEntityChanges(myNewEntity);
        }
        #endregion GRAPH INSERT TESTS
        #region SELECT TESTS
        [Fact]
        public void SelectEntity()
        {
            List<Entity> myEntities = GetEntity();
            _output.WriteLine("Records Returned: "+ myEntities.Count().ToString());
        }
        #endregion SELECT TESTS
        #region UPDATE TESTS
        #endregion UPDATE TESTS
        #region DELETE TESTS
        #endregion DELETE TESTS

    }
}
