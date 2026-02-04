using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Interfaces;
using WebAPI.Objects;

namespace WebAPI.Controllers
{
    public class ApiController
    {
        private IExcerciseDatastore _excerciseDatastore;

        public ApiController(IExcerciseDatastore excerciseDatastore)
        {
            _excerciseDatastore = excerciseDatastore;
        }

        
        public IEnumerable<Excercise> GetAllExcercises()
        {
            return _excerciseDatastore.GetAllExcercises();
        }
        public Excercise GetRandomExcercise()
        {
            IEnumerable<Excercise> allExcercises = _excerciseDatastore.GetAllExcercises();
            int numOfExcercises = allExcercises.Count();
            int randExcerciseIndex = Random.Shared.Next(numOfExcercises);
            return allExcercises.ToList()[randExcerciseIndex];
        }
        public IEnumerable<Excercise> GetRandomSchedule()
        {
            List<Excercise> scheduleExcercises = new List<Excercise>();
            List<Excercise> availableExcercises = _excerciseDatastore.GetAllExcercises().ToList();

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