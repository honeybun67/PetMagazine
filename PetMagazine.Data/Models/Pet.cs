
namespace PetMagazine.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using PetMagazine.Common;

    public class Pet
    {
        public int Id { get; set; }

        [MaxLength (150)]
        public string Name { get; set; }

        [MaxLength(150)]
        public string Breed { get; set; }

        public int Age { get; set; }

        [MaxLength(150)]
        public string? Owner { get; set; }

        [MaxLength(150)]
        public string KindOfPet { get; set; }

        public string ImgUrl { get; set; } = GlobalConstants.DefaultImg;

        public virtual ICollection<PetCategory> Categories { get; set; } = new HashSet<PetCategory> (); 
    }
}
