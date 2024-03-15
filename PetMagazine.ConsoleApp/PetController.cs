namespace PetMagazine.ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using PetMagazine.Common;
    using PetMagazine.Data.Models;
    using PetMagazine.Services;

    public class PetController
    {
        private PetService service = new PetService();

        //Pagination variables
        private int currentPage = 1;
        private int petsPerPage = 10;
        private int pageCount = 0;
        private int totalPets = 0;
        private bool ascSort = true;

       
    }
}
