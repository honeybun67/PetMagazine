
namespace PetMagazine.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Pet
    {
        public int id { get; set; }

        [MaxLength (150)]
        public string Name { get; set; }

        [MaxLength(150)]
        public string Breed { get; set; }

        public int Age { get; set; }

        [MaxLength(150)]
        public string Owner { get; set; }

        [MaxLength(150)]
        public string KindOfPet { get; set; }

        public virtual ICollection<PetCategory> categories { get; set; } = new HashSet<PetCategory> (); 
    }
}
