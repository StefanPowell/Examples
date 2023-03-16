using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OCCAPP.Models
{
    public class StudentRequest
    {
            [Required(ErrorMessage = " * This is a Required Field.")]
            public string Firstname { get; set; }

            [Required(ErrorMessage = " * This is a Required Field.")]
            public string Lastname { get; set; }

            [Required(ErrorMessage = " * This is a Required Field.")]
            [RegularExpression("^\\(?([0-9]{3})\\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$", ErrorMessage = "* Invalid Phone Number or Format")]
            public string Phone { get; set; }

            [Required(ErrorMessage = " * This is a Required Field.")]
            [RegularExpression("^[^@\\s]+@[^@\\s]+\\.(com|net|org|gov)$", ErrorMessage = " * Invalid Email Format")]  
            public string Email { get; set; }
    }
}