using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Objects;

namespace WebAPI.WebApi.Test.DataHelpers
{
    public static class ExcerciseDataHelper
    {
        public static readonly List<Excercise> AllExcercises = new List<Excercise>
        {
            new Excercise("Bicep Curls", 5, 8),
            new Excercise("Squats", 5, 5),
            new Excercise("Bench Press", 5, 5),
            new Excercise("Overhead Press", 3, 12),
            new Excercise("Deadlift", 1, 5),
            new Excercise("Tricep Pulldowns", 3, 12)
        };
    }
}