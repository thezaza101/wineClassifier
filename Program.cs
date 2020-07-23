using System;
using MLHelpers;

namespace wineClassifier
{
    class Program
    {
        static void Main(string[] args)
        {
            IMLTrainer wineModel = new WineModel();
            wineModel.LoadData();
            wineModel.BuildPipeline();
            wineModel.BuildAndTrainModel();
            wineModel.EvaluateModel();
            wineModel.SaveModelToFile(WineModel._modelPath);  

            WinePredictor wineModelPred = new WinePredictor(WineModel._modelPath);


        }
    }
}
