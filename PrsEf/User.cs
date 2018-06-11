using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrsEf { //we added this from another solution. We had to change the namespace to SqlLibrary so we could use this.
					   //We could use a using statement instead
					   //This is a COPY, or a CLONE of this class.  Any changes we make will not affect the origin class. 

    public class User {//mark the class as public if the data is going to public
    
		public int Id { get; set; }

		[Required] //This  attribute is saying null isn't allowed
		[StringLength(30)]  //this is an attribute.  the StringLength attribute is setting the max amount of characters allowed
		[Index(IsUnique = true)] //this attribute makes it so there are no duplicate usernames. 
								 //Before running, make sure you don't have any duplicate usernames, or else you'll get an error
								 //You can check in SQL by looking under indexes (not columns)
		public string Username { get; set; }

		[Required]
		[StringLength(30)]
		public string Password { get; set; }

		[Required]
		[StringLength(30)]
		public string Firstname { get; set; }

		[Required]
		[StringLength(30)]
		public string Lastname { get; set; }

		[Required]
		[StringLength(12)]
		public string Phone { get; set; }

		[Required]
		[StringLength(255)]
		public string Email { get; set; } //remember, booleans are not allowed to be null unless you put a question mark after bool

		public bool IsReviewer { get; set; }
		public bool IsAdmin { get; set; }
		public bool Active { get; set; }
		
	
		public User() { }
	}
}
