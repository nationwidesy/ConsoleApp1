using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ManyToManyEfSample2
    {
        public ManyToManyEfSample2()
        {
            Database.SetInitializer<SchoolContext>(null);
            using (SchoolContext db = new SchoolContext())
            {
                Course CS = new Course();
                Course IT = new Course();
                CS.Title = "Computer Science";
                IT.Title = "Information Technology";

                db.Courses.Add(CS);
                db.Courses.Add(IT);

                Person P1 = new Person();
                P1.FirstName = "Sophy";
                P1.LastName = "Yang";
                P1.Courses.Add(CS);
                P1.Courses.Add(IT);

                db.People.Add(P1);
                db.SaveChanges();
            }
        }

        public class Person
        {
            public int PersonId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public virtual ICollection<Course> Courses { get; set; }

            public Person()
            {
                Courses = new HashSet<Course>();
            }
        }
        public class Course
        {
            public int CourseId { get; set; }
            public string Title { get; set; }
            
            public virtual ICollection<Person> Students { get; set; }

            public Course()
            {
                Students = new HashSet<Person>();
            }
        }

        public class SchoolContext: DbContext
        {
            public DbSet<Course> Courses { get; set; }
            public DbSet<Person> People { get; set; }

            public SchoolContext (): base("name=ConsoleApp1.Properties.Settings.sophyTest1_1ConnectionString")
            {

            }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

                modelBuilder.Entity<Course>().
                    HasMany(c => c.Students).
                    WithMany(p => p.Courses).
                    Map(m =>
                  {
                      m.MapLeftKey("CourseId");
                      m.MapRightKey("PersonId");
                      m.ToTable("PersonCourses");
                  });



            }
        }
    }
}
