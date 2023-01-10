using DogGo.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace DogGo.Repositories
{
    public interface IDogRepository
    {
        public List<Dog> GetAllDogs();
        public Dog GetDogById(int id);
        public void AddDog(Dog dog);
        public void DeleteDog(int dogId);
        public void UpdateDog(Dog dog);
        List<Dog> GetDogsByOwnerId(int ownerId);
    }
}
