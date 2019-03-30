using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models
{
    public class Animal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idClient { get; set; }

        [Required]
        [MaxLength(200)]
        public string ClientFirstName { get; set; }

        [Required]
        [MaxLength(200)]
        public string ClientLastName { get; set; }

        public DateTime BirthDate { get; set; }

        public ICollection<Pet> Pets { get; set; }
    }
}
