using APW.Models;

namespace APW.Global;

    public class LingProcessor
    {
        public List<Car> Cars = [];

        public List<Car> TransformCars(){
            return Cars.Where(c =>c != null).ToList();
            }
    }

