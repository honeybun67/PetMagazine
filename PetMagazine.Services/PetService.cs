namespace PetMagazine.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using PetMagazine.Common;
    using PetMagazine.Data;
    using PetMagazine.Data.Models;
    using PetMagazine.Services.ENums;

    public class PetService
    {
        private AppDbContext context = new AppDbContext();
        public PetService()
        {
            context = new AppDbContext();
        }
        public PetService(AppDbContext context)
        {
            this.context = context;
        }


        //Adding a pet 
        public int Add(Pet pet)
        {
            ValidatePet(pet);

            this.context.Add(pet);
            this.context.SaveChanges();
            return pet.Id;
        }

        public Pet? GetPetById(int id)
        {
            return this.context.Pets.Find(id);
        }

        //sort by criterion
        public List<Pet> GetPets(int page = 1, int itemsPerPage = 10, bool ascSort = true, PetSortBy sortBy = PetSortBy.Breed)
        {
            IQueryable<Pet> result = null;

            if (ascSort)
            {
                switch (sortBy)
                {
                    case PetSortBy.Breed:
                        result = context.Pets.OrderBy(x => x.Breed);
                        break;
                    case PetSortBy.Age:
                        result = context.Pets.OrderBy(x => x.Age);
                        break;
                    case PetSortBy.Owner:
                        result = context.Pets.OrderBy(x => x.Owner);
                        break;
                    case PetSortBy.KindOfPet:
                        result = context.Pets.OrderBy(x => x.KindOfPet);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (sortBy)
                {
                    case PetSortBy.Breed:
                        result = context.Pets.OrderByDescending(x => x.Breed);
                        break;
                    case PetSortBy.Age:
                        result = context.Pets.OrderByDescending(x => x.Age);
                        break;
                    case PetSortBy.Owner:
                        result = context.Pets.OrderByDescending(x => x.Owner);
                        break;
                    case PetSortBy.KindOfPet:
                        result = context.Pets.OrderByDescending(x => x.KindOfPet);
                        break;
                    default:
                        break;
                }
            }

            return result
                  .Skip((page - 1) * itemsPerPage)
                  .Take(itemsPerPage)
                  .ToList();
        }

        //Pets count
        public int GetPetsCount()
        {
            return context.Pets.Count();
        }

        //Editing a pet by id
        public int EditPet(Pet pet)
        {
            Pet? editPet = this.GetPetById(pet.Id);
            if (editPet == null)
            {
                throw new ArgumentException(ExceptionMessages.PetNotFound);
            }

            ValidatePet(pet);

            context.Pets.Update(pet);
            context.SaveChanges();
            return pet.Id;
        }

        //Removing a pet
        public int DeletePet(int id)
        {
            Pet? pet = this.GetPetById(id);
            if (pet == null)
            {
                throw new ArgumentException(ExceptionMessages.PetNotFound);
            }
            context.Pets.Remove(pet);
            context.SaveChanges();
            return pet.Id;
        }

        //Adopt a pet
        public int AdoptPet(int id)
        {
            Pet? pet = context.Pets.Find(id);
            if (pet == null)
            {
                throw new ArgumentException(ExceptionMessages.PetNotFound);
            }
            if (!string.IsNullOrWhiteSpace(pet.Owner))
            {
                throw new ArgumentException(ExceptionMessages.CannotAdoptPet);
            }
            context.Remove(pet);
            context.SaveChanges();
            return pet.Id;
            
        }

        //Validation
        private void ValidatePet(Pet pet)
        {
            if (string.IsNullOrWhiteSpace(pet.Name))
            {
                throw new ArgumentException(ExceptionMessages.InvalidPetName);
            }
            if (context.Pets.Any(x => x.Name == pet.Name))
            {
                throw new ArgumentException(ExceptionMessages.PetAlreadyExist);
            }
            if (pet.Age <= 0)
            {
                throw new ArgumentException(ExceptionMessages.InvalidAge);
            }
        }

        public string[] GetBreedsList()
        {
            return context.Pets.Select(x => x.Breed)
                .Distinct()
                .ToArray();
        }

        public int EditPetCategories(Pet pet)
        {
            context.Pets.Update(pet);
            context.SaveChanges();
            return pet.Id;
        }
    }
}
