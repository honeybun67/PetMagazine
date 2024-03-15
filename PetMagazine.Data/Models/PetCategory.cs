namespace PetMagazine.Data.Models
{
    using Microsoft.EntityFrameworkCore;

    [PrimaryKey(nameof(PetId),nameof(CategoryId))]
    public class PetCategory
    {
        public int PetId { get; set; }

        public virtual Pet Pet { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
