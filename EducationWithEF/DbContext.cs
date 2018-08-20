using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationWithEF {
	public class MyDbContext : DbContext {

		public MyDbContext() : base("Name=EducationWithEFConnection") {
		}

		//public virtual DbSet<Student> Students { get; set; }
	}
}
