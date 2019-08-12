

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyLeasing.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Document { get; set; }
        [Required(ErrorMessage ="The field {0} is mandatory")]
        [MaxLength(30,ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [MaxLength(50)]
        [Display(Name = "Fixed Name")]
        public string FixedName { get; set; }
        [MaxLength(20)]
        [Display(Name = "Cell Name")]
        public string CellName { get; set; }
        public string Adress { get; set; }
        //Propiedad de solo lectura, no se mapea a base de datos
        [Display(Name = "Name Owner")]
        public string FullName => $"{FirstName} {LastName}";
        public string FullNameWithDocumento => $"{FirstName}{LastName}-{Document}";
        public ICollection<Property> properties { get; set; }
        public ICollection<Contract> contracts { get; set; }
    }
}
