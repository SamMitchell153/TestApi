using WebAPI.Objects;

namespace WebAPI.Interfaces
{
    public interface IExcerciseDatastore
    {
        public IEnumerable<Excercise> GetAllExcercises();
    }
}