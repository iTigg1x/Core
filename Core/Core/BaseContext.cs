using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        { 
        }
    }
}
