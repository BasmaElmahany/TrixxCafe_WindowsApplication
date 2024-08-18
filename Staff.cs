using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trixx_CafeSystem
{
    internal class Staff
    {
        [Key]
        public int Staff_ID { get; set; }
        public string Staff_Name { get; set; }
        [ForeignKey("Login_User")]
        public int User_ID {  get; set; }
        public int NID { get; set; }
        public int Address { get; set; }

        public DateTime Assign_Date { get; set; }
        public string Staff_Phone { get; set; }
        public virtual Login_User Login_User { get; set; }

        // Don't forget to name the table => Salaries when you create it  
        public virtual Salaries Salary { get; set; } // one to one relationship

    }
}
