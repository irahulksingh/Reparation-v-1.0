using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using HgWorkflow.Models;

namespace HgWorkflow.DAL
{
    public class OurDbContext : DbContext
    {
        public DbSet<UserAccount> userAccounts { get; set; }   

        public DbSet<WorkOrder> workOrders { get; set; }
    }
}