using WebAPI.Interfaces;
using WebAPI.Objects;
using WebAPI.WebApi.Test.DataHelpers;

namespace WebAPI.WebApi.Test
{
    public class TestExcerciseDatastore : IExcerciseDatastore
    {

        public IEnumerable<Excercise> GetAllExcercises()
        {
            return ExcerciseDataHelper.AllExcercises;
        }
        public Excercise GetRandomExcercise()
        {
            int numOfExcercises = ExcerciseDataHelper.AllExcercises.Count;
            int randExcerciseIndex = Random.Shared.Next(numOfExcercises);
            return ExcerciseDataHelper.AllExcercises[randExcerciseIndex];
        }
        public IEnumerable<Excercise> GetRandomSchedule()
        {
            List<Excercise> scheduleExcercises = new List<Excercise>();
            List<Excercise> availableExcercises = ExcerciseDataHelper.AllExcercises.Select(x => x).ToList();

            for(int i = 0; i < 3; i++)
            {
                int numOfExcercises = availableExcercises.Count();
                int randExcerciseIndex = Random.Shared.Next(numOfExcercises);
                Excercise selectedExcercise = availableExcercises[randExcerciseIndex];
                availableExcercises.Remove(selectedExcercise);
                scheduleExcercises.Add(selectedExcercise);
            }

            return scheduleExcercises;
        }
    }
}