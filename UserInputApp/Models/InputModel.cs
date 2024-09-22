
using System.ComponentModel.DataAnnotations;
namespace UserInputApp.Models
{
    public class InputModel
    {
        [Required(ErrorMessage = "Please enter a value")]
        public string InputValue { get; set; }

        public string InputResult { get; set; }
    }
}
