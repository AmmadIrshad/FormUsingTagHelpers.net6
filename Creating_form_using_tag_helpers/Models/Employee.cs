using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace Creating_form_using_tag_helpers.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Name is a must")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Name must be within 3 to 15 characters")]
        //[MaxLength(15)]
        //[MinLength(3,ErrorMessage ="more than 2")]
        public string? Name  { get; set; }

        [Required (ErrorMessage = "Email is a must")]
        //email is not recommended use regular expression
        //[EmailAddress]
        [RegularExpression("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$", ErrorMessage ="Invalid Email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Age is a must")]
        [Range(10,50,ErrorMessage ="Age must be between 10 to 50")]
        public int? Age { get; set; }

        [Required(ErrorMessage = "Password is a must")]
        //@verbatim litteral sequence m escape sequence to ignore kar k 1 hi string coniider kary
        [RegularExpression("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*\\W)(?!.*[\\n.])(?!.*\\s).{8,}$",ErrorMessage ="strong password")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Password is a must")]
        [Compare("Password",ErrorMessage ="both passwords must be Identical")]
        [Display(Name ="Confirm Password:")]
        public string? ConfirmPassword { get; set; }

        [Required(ErrorMessage = "phone number is a must")]
        [RegularExpression("^((\\+92)|(0092))-?(\\d{3})-?(\\d{7})$|^\\d{11}$|^\\d{4}-\\d{7}$", ErrorMessage ="Invalid number")]
        public string? PNumber { get; set; }
        [Required(ErrorMessage = "Url number is a must")]
        [Url(ErrorMessage ="Invalid Url")]
        public string? WebsiteUrl { get; set; }

        //public Gender Gender { get; set; }

        //public string? designation { get; set; }
        //public int salary { get; set; }
        //public string? Married { get; set; }
        //public string? Description { get; set; }
    }

    public enum Gender
    {
        MALE,Female
    }
//CNIC
//^ [0 - 9]{ 5}
//- [0 - 9]{ 7}
//- [0 - 9]$

}
