using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ViewModels
{
    public class AddAuthorViewModel
    {
        [Display(Name = "Ім’я автора")]
        [Required(ErrorMessage = "Вкажіть ім’я автора")]
        [StringLength(maximumLength: 500, MinimumLength = 1)]
        public string FirstName { get; set; }

        [Display(Name = "Прізвише автора")]
        [Required(ErrorMessage = "Вкажіть прізвише автора")]
        [StringLength(maximumLength: 500, MinimumLength = 1)]
        public string LastName { get; set; }
    }

    public class AuthorItemViewModel
    {
        public int Id { get; set; }

        [Display(Name ="Ім’я автора")]
        [Required(ErrorMessage ="Вкажіть ім’я автора")]
        [StringLength(maximumLength:500, MinimumLength =1)]
        public string FirstName { get; set; }

        [Display(Name = "Прізвише автора")]
        [Required(ErrorMessage = "Вкажіть прізвише автора")]
        [StringLength(maximumLength: 500, MinimumLength = 1)]
        public string LastName { get; set; }
    }

    public class EditAuthorViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Ім’я автора")]
        [Required(ErrorMessage = "Вкажіть ім’я автора")]
        [StringLength(maximumLength: 500, MinimumLength = 1)]
        public string FirstName { get; set; }

        [Display(Name = "Прізвише автора")]
        [Required(ErrorMessage = "Вкажіть прізвише автора")]
        [StringLength(maximumLength: 500, MinimumLength = 1)]
        public string LastName { get; set; }
    }
}
