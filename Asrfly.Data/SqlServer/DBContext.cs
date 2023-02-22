using Asrfly.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asrfly.Data.SqlServer
{
    public class DBContext:DbContext
    {
        public DBContext()
        {

        }

        //Set Connection String
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var sqlCon = @"Server=.\\SQLEXPRESS;Database=AsrflyDataBase;Trusted_Connection=True;"; // for test 
            optionsBuilder.UseSqlServer(sqlCon);

           
    }
        //Tables
        public DbSet<Categories> Categories { get; set; }
    }
}
    