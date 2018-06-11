using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrsEf;

namespace PrsWithEf {
	class Program {

		private static PrsDbContext db = new PrsDbContext();  //make this static because main is static

		static void Main(string[] args) {

			var pEchoDot = new Product {
				Name = "Echo Dot",
				PartNumber = "ED.3",
				Price = 39.99M,
				Unit = "Each",
				PhotoPath = "blahblahblah",
				VendorId = 2,
				Vendor = null
			};

			db.Products.Add(pEchoDot);
			db.SaveChanges();

			var products = db.Products.ToList();
			var product = products[0]; //this is selecting the product with the id of 0
			var vendorName = product.Vendor.Name; //this will give us the name of the vendor

			List<User> users = db.Users.ToList(); //this will return a list of type of user
												  // could use var is generic type.  we're using this in place of List<User>
												  // when you use var as your data type you have to initalize it first (so VS knows what type of data it's storing)
												  //saves on keystrokes
			User user = db.Users.Find(2);  //this is pulling by the primary key in the table
			User nouser = db.Users.Find(111); //we don't have a row 111, so the value of this should be null

			//User adduser = new User {
			//	Username = "gdoud",
			//	Password = "password",
			//	Firstname = "Greg",
			//	Lastname = "Doud",
			//	Phone = "555-555-1212",
			//	Email = "gpdoud@gmail.com",
			//	Active = true,
			//	IsAdmin  = false,
			//	IsReviewer = false
			//}; // using a curly brace and semi colon in EF, VS will know what values are in user

			//User addedUser = db.Users.Add(adduser); //this is staging the changes
			//db.SaveChanges(); // this is saving/commiting the changes - you don't have to do this for every single addition/change, but it will save the changes for every thing aove it

			//db.Users.Remove(addedUser);
			//db.SaveChanges();

			//User u1 = db.Users.SingleOrDefault(u => u.Email == "gpdoud@gmail.com"); //this is just selecting a row from the db
			//																		//Single or Default will help you find one row of any column.  Will tell you null if it doesn't have what you're looking for
			//																		//Find only works on primary key
			//u1.IsAdmin = true; //this is changing the IsAdmin value of the row with the email address gpdoud@gmail.com
			//db.SaveChanges();
		}
	}
}
