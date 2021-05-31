using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CRUD.Models
{
    public class User
    {
        [Key]
        public int StudentCode { get; set; }

        [Required(ErrorMessage = "First Name is Required")]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "Middle Name is Required")]
        public String MiddleName { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        public String LastName { get; set; }

        [Required(ErrorMessage = "Please fill your Age"),Range(15,99)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Address is Required")]
        public String Address { get; set; }

        [Required (ErrorMessage = "Please fill your Citizenship Info")]
        public String Citizenship { get; set; }

        [Required(ErrorMessage = "Please add your contact number")]
        public int Contact { get; set; }
      
        [Required(ErrorMessage = "Please write your course")]
        public String Course { get; set; }

        [Required(ErrorMessage = "Please fill the Year Level")]
        public int Year { get; set; }

        [Required(ErrorMessage = "What campus are you from? (Main, METC,Lapu-Lapu Mandaue,Banilad)")]
        public String Campus { get; set; }


    }
}
