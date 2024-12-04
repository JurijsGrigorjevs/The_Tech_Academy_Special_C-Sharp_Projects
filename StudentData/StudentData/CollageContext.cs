using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData
{
    public class CollageContext: DbContext
    {

        public CollageContext() : base("CollageDataDB")
        {

        }
        // Define a `DbSet<Student>` property, which represents the collection of `Student` entities in the database.
        public DbSet<Student> Students { get; set; }
        // Define a `DbSet<Grade>` property, which represents the collection of `Grade` entities in the database.
        public DbSet<Grade> Grades { get; set; }
    }
}
