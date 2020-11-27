using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Models
{
    public class Admin
    {
        //public class Admin
       
         
            public int ID { get; set; }
            [DisplayName("Student ID")]
            public string StudentID { get; set; }

            [DisplayName("Last Name")]
            public string Last_Name { get; set;}
            [DisplayName("First Name")]
            public string First_Name { get; set; }          
            
            [DataType(DataType.Date)]
            public DateTime Birthdate { get; set; }
            public int Age { get; set; }
            public string Address { get; set; }
       
    }
}
