using System.ComponentModel.DataAnnotations;

namespace DapperCRUD.ViewModels
{
    public class CompanyVM
    {
        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Adresse is required")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Country is required")]
        public string? Country { get; set; }
    }
}
