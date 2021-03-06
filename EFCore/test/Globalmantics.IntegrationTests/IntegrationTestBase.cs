﻿using Globalmantics.DAL;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace Globalmantics.IntegrationTests
{
    public class IntegrationTestBase
    {
        protected static GlobalmanticsContext GivenGlobalmanticsContext()
        {
            var options = new DbContextOptionsBuilder()
                .UseSqlServer(Globalmantics.ConnectionString)
                .Options;
            var context = new GlobalmanticsContext(options);
            return context;
        }

        private static SqlConnectionStringBuilder Globalmantics =>
            new SqlConnectionStringBuilder
            {
                DataSource = @"(LocalDB)\MSSQLLocalDB",
                InitialCatalog = "Globalmantics",
                IntegratedSecurity = true
            };
    }
}