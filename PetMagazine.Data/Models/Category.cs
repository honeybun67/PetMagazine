namespace PetMagazine.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Category
    {
        public int Id { get; set; }
        [MaxLength(150)]
        public string AgeGroup { get; set; }

        [MaxLength(150)]
        public string Medal { get; set; }

        [MaxLength(150)]
        public string Achievements { get; set; }
        public ICollection<PetCategory> Pets { get; set; } = new HashSet<PetCategory>();
    }
}
