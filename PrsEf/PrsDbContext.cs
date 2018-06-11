using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrsEf {
	public class PrsDbContext : DbContext {

	public PrsDbContext() : base() {   //this is calling creating the default constructor for PrsDbContext and DbContext

		}
		public DbSet<User> Users { get; set; }//protip: make the variable the plural of your class name
		public DbSet<Vendor> Vendors { get; set; }
		public DbSet<Product> Products { get; set; }
	}
}
