using WebAPI.Objects;

namespace WebAPI.Interfaces
{
    public interface IExcerciseDatastore
    {
        public IEnumerable<Excercise> GetAllExcercises();
        public Excercise GetRandomExcercise();
        public IEnumerable<Excercise> GetRandomSchedule();
    }
}