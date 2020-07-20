using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShinaMashina.Data.Postgres.Test.Integration
{
    [TestClass]
    public class DataStructure_Should
    {
        [TestInitialize]
        public void Initialize()
        {

        }

        [TestMethod]
        public void OnCreatingDatabase()
        {
            var dataContextFactory = new DataContextFactory("Host=localhost;Port=5432;Database=shm1;Username=postgres;Password=qwerty1");
            var dataContext = dataContextFactory.Create();
        }
    }
}
