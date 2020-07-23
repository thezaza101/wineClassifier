using System;
using System.IO;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Transforms;

using Microsoft.ML.Data;

namespace wineClassifier
{
    public class WinePredictor
    {
        ITransformer _model;
        private MLContext _mlContext; 
        private PredictionEngine<WineData, WinePrediction> _predEngine;

        public WinePredictor(string pathToModel)
        {

        }

        public void Predict(WineData iris)
        {

        }
    }
}