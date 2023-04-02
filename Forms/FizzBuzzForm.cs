using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.ComponentModel.DataAnnotations;


namespace FizzBuzz.Forms
{
    public class FizzBuzzForm
    {
       
        [Display(Name = "Twój szczęśliwy numerek")]
        [Required]
        [Range(1, 1000, ErrorMessage = "Oczekiwana wartość {0} z zakredu {1} i {2}.")]
        public int Number { get; set; }

    }
}
