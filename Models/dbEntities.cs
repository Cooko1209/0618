using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace mvcdemopj.Models
{
    public partial class dbEntities : Microsoft.EntityFrameworkCore.DbContext
    {
        public dbEntities()
        {

        }
        public dbEntities(DbContextOptions<dbEntities> options) : base(options)
        {

        }
    }
}
