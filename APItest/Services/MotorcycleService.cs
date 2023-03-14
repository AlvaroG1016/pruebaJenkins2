using APItest.Models;

namespace APItest.Services
{
    public class MotorcycleService : IMotorcycleService
    {
        private List<Motorcycle> _motorcycles = new List<Motorcycle>()
        {
            new Motorcycle(){Id=1, Name="Fz25", Brand="Yamaha"},
            new Motorcycle(){Id=2, Name="NS200", Brand="Pulsar"}
        };

        public IEnumerable<Motorcycle> GetAllMotorcycle() => _motorcycles;
        public Motorcycle? Get(int id) => _motorcycles.FirstOrDefault(x => x.Id == id);
    }
}
