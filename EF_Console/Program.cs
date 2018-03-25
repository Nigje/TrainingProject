using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db=new DB())
            {
                var a = db.Adresses;
                var q = db.Parents.Include(x => x.Adress).ToList();
                Parent parent = new Parent() {ParentName = "Test"};
                parent.Child=new List<Child>();
                parent.Child.Add(new Child() {ChildName = "Bache 1"});
                parent.Child.Add(new Child() {ChildName = "Bache 2" });
                parent.Child.Add(new Child() {ChildName = "Bache 3" });
                
                parent.Adress=new Adress() {Name = "Tehran"};
                db.Parents.Add(parent);
                //db.Temps.Add(new Temp() {Name = "Alef"});
                db.SaveChanges();
                Parent g = db.Childs.ToList().Last().Parent;
                var assres = g.Adress;
                var df = db.Parents.ToList();

            }
        }
    }

    public class DB : DbContext
    {
        public DB() : base("DBContext")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DB>());
        }

        public DbSet<Parent> Parents { get; set; }
        public DbSet<Child> Childs { get; set; }
        public DbSet<Temp> Temps { get; set; }
        public DbSet<Adress> Adresses { get; set; }
    }
    //*****************************************************************************
    public class Parent

    {
        public Parent()
        {
        }
        public int Id { get; set; }
        public string ParentName { get; set; }
        public virtual ICollection<Child> Child { get; set; }
        public virtual Adress Adress { get; set; }
    }
    //*****************************************************************************
    public class Child
    {
        public Child()
        {
        }
        public int Id { get; set; }
        public string ChildName { get; set; }
        public virtual Parent Parent { get; set; }
       
    }
    //*****************************************************************************
    public class Adress
    {
        public Adress()
        {
        }
        [ForeignKey("Parent")]
        public int Id { get; set; }
        public string Name { get; set; }
        
        //public string ParentId { get; set; }

        public virtual Parent Parent { get; set; }
    }

    //*****************************************************************************
    public class Temp
    {
        public Temp()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
