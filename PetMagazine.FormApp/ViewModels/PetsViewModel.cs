using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMagazine.FormApp.ViewModels
{
    public class PetsViewModel
    {
        public List<PetViewModel> Pets { get; set; } = new List<PetViewModel>();
    }
}
