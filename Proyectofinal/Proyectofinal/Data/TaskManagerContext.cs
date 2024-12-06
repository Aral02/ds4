using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Proyectofinal.Models;

namespace Proyectofinal.Data
{
    public class TaskManagerContext : DbContext
    {
        public TaskManagerContext() : base("TaskManagerDB") { }
        public DbSet<Task> Tasks { get; set; }
    }
}