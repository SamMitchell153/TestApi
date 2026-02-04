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
    }
}