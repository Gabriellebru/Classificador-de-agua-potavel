// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML.Data;

namespace Classificador_de_agua_potavelML.Model
{
    public class ModelInput
    {
        [ColumnName("ph"), LoadColumn(0)]
        public float Ph { get; set; }


        [ColumnName("Hardness"), LoadColumn(1)]
        public float Hardness { get; set; }


        [ColumnName("Solids"), LoadColumn(2)]
        public float Solids { get; set; }


        [ColumnName("Chloramines"), LoadColumn(3)]
        public float Chloramines { get; set; }


        [ColumnName("Sulfate"), LoadColumn(4)]
        public float Sulfate { get; set; }


        [ColumnName("Conductivity"), LoadColumn(5)]
        public float Conductivity { get; set; }


        [ColumnName("Organic_carbon"), LoadColumn(6)]
        public float Organic_carbon { get; set; }


        [ColumnName("Trihalomethanes"), LoadColumn(7)]
        public float Trihalomethanes { get; set; }


        [ColumnName("Turbidity"), LoadColumn(8)]
        public float Turbidity { get; set; }


        [ColumnName("Potability"), LoadColumn(9)]
        public string Potability { get; set; }


    }
}
