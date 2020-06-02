using System.ComponentModel.DataAnnotations;

namespace Markets.Models
{
    public class EmailModel
    {
        [Required]
        public string EmailName { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string EmailSubject { get; set; }
        [Required]
        public string EmailBody { get; set; }
    }

}
