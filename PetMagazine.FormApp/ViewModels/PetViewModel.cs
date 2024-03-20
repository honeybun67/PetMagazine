using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMagazine.FormApp.ViewModels
{
    public class PetViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Breed { get; set; }

        public int Age { get; set; }

        public string? Owner { get; set; }

        public string KindOfPet { get; set; }

        public string Categories { get; set; }
    }
}
