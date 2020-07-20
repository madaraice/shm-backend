using System;

namespace ShinaMashina.Data.Postgres
{
    public class DataContextFactory
    {
        private readonly string _connectionString;

        public DataContextFactory(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString)) throw new ArgumentNullException(nameof(connectionString));

            _connectionString = connectionString;
        }

        public DataContext Create()
        {
            return new DataContext(_connectionString);
        }
    }
}
