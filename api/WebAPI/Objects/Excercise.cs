using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Objects
{
    public class Excercise
    {
        public string Name {get;}
        public int Sets {get;}
        public int Reps {get;}

        public Excercise(string name, int sets, int reps)
        {
            Name = name;
            Sets = sets;
            Reps = reps;
        }


    }
}