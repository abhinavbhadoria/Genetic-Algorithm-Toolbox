using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    class DataStorage
    {
        public static string[] selectionSchemes = new string[] { "Roulette wheel selection", "Random selection", "Rank selection", "Tournament selection" };
        public static string[] crossoverSchemes = new string[] { "One-point crossover", "Two-point crossover" };
        public static string[] mutationSchemes = new string[] { "One-bit mutation", "Multiple-bit mutation" };

        public static string[] selectionToolTip = new string[] 
        { "The princle of Roulette selection is a linear search through a Roulette wheel with the slots in the wheel weighted in propertion to the individual fitness value.",
          "This technique randomly selects a parent from the population.",
          "Rank selection first ranks the population and then every chromosome receives fitness from this ranking. The worst will have fitness 1, second worst 2 etc. and the best will have fitness N (number of chromosomes in population).",
          "The best individual from the tournament is the one with the heighest fitness, who is the winner. Tournament competitions and the winner are then inserted into the mating pool."
        };

        public static string[] crossoverToolTip = new string[]
        {
            "The two mating chromosomes are cut once at corresponding points and the sections after the cuts are exchanged.",
            "Two crossover points are choosen and the contents between these points are exhanged between two mated parents."
        };

        public static string[] mutationToolTip = new string[] 
        {
            "Only one bit is flipped randomly",
            "Multiple bit are flipped randomly"
        };

        public static string fitnessFunction;
        public static int numOfVar;
        public static int lowerBound, UpperBound;
        public static int initialPopCount;
        public static int generationCount;
        public static string selectionType;
        public static string crossoverType;
        public static string mutationType;
        public static int crossoverRate;
        public static int mutationRate;

        public static void SaveData(string fitnessFunc, string varCount, string lowerLimit, string upperLimit, string popCount, string genCount, string selcType, string crossType, string mutType, int crossRate, int mutRate)
        {
            fitnessFunction = fitnessFunc;

            int temp = 0;
            numOfVar = (int.TryParse(varCount, out temp)) ? temp : 1;

            temp = 0;
            lowerBound = (int.TryParse(lowerLimit, out temp)) ? temp : 0;

            temp = 0;
            UpperBound = (int.TryParse(upperLimit, out temp)) ? temp : 0;

            temp = 0;
            initialPopCount = (int.TryParse(popCount, out temp)) ? temp : 4;

            temp = 0;
            generationCount = (int.TryParse(genCount, out temp)) ? temp : 10;

            selectionType = selcType;
            crossoverType = crossType;
            mutationType = mutType;

            crossoverRate = crossRate;
            mutationRate = mutRate;
        }

        public static string GetCrossoverToolTip()
        {
            for (int i = 0; i < crossoverSchemes.Length; i++)
                if (crossoverSchemes[i] == crossoverType)
                    return crossoverToolTip[i];
            return string.Empty;
        }

        public static string GetMutationToolTip()
        {
            for (int i = 0; i < mutationSchemes.Length; i++)
                if (mutationSchemes[i] == mutationType)
                    return mutationToolTip[i];
            return string.Empty;
        }
    }
}
