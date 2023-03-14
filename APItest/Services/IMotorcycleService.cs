using APItest.Models;

namespace APItest.Services
{
    public interface IMotorcycleService
    {
        public IEnumerable<Motorcycle> GetAllMotorcycle();
        public Motorcycle? Get(int id);

    }
}
