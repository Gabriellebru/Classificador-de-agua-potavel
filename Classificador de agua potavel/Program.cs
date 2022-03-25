using System;
using System.Collections.Generic;
using Classificador_de_agua_potavelML.Model;

namespace Classificador_de_agua_potavel
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = new List<ModelInput>()
            {
                new ModelInput()
                {
                    Ph = 0F,
                    Hardness = 204.8905F,
                    Solids = 20791.32F,
                    Chloramines = 7.300212F,
                    Sulfate = 368.5164F,
                    Conductivity = 564.3087F,
                    Organic_carbon = 10.37978F,
                    Trihalomethanes = 86.99097F,
                    Turbidity = 2.963135F,
                },
                new ModelInput()
                {
                    Ph = 9.494242648038439F,
                    Hardness = 274.82836925370225F,
                    Solids = 21879.70420789106F,
                    Chloramines = 5.265718338065395F,
                    Sulfate = 364.682634348411F,
                    Conductivity = 581.0781564148187F,
                    Organic_carbon = 13.636013975087621F,
                    Trihalomethanes = 62.11964302909877F,
                    Turbidity = 3.1890255397078775F,
                },
            };


            // Load model and predict output of sample data
            List<ModelOutput> results = ConsumeModel.Predicts(inputs);
            ConsumeModel.ShowResults(results);
            Console.ReadKey();
        }
    }
}
