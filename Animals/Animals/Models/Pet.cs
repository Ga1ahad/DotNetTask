using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models
{
    public  class Pet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idPet { get; set; }

        [Required]
        [MaxLength(200)]
        public string PetName { get; set; }


        public int idClient { get; set; }

        public Animal animals { get; set; }
    }
}
