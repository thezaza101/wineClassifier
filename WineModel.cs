using System;
using System.IO;
using MLHelpers;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Transforms;

namespace wineClassifier
{
    class WineModel : IMLTrainer
    {
        //Base path of the application
        private static string _appPath => Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
        //Path to the data file
        private static string _dataPath => Path.Combine(_appPath, "..", "..", "..", "Data", "Wine.txt");
        //Path to where the model will be saved
        public static string _modelPath => Path.Combine(_appPath, "..", "..", "..", "Models", "wineModel.zip");
        
        //Reference to the MLContext
        private static MLContext _mlContext;
		//Reference to the pipeline of the model
        private static IEstimator<ITransformer> _pipeline;
        //Reference to the model    
        private static ITransformer _model;
        //Training data
        static IDataView _trainData;
        //Testing data
        static IDataView _testData;
		
		//Constructor for the wine model
        public WineModel()
        {
            _mlContext = new MLContext();
        }

        //Loads the data
        public void LoadData()
        {
            
        }

        //Data pre processing 
        public void BuildPipeline()
        {

        }

        //Build and train the model
        public void BuildAndTrainModel()
        {
            
        }

        //Evaluate the performance of the model
        public void EvaluateModel() 
        {

        }

        //Save the model to file
        public void SaveModelToFile(string pathToFile)
        {
            using (var fs = new FileStream(_modelPath, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                _mlContext.Model.Save(_model,_trainData.Schema, fs);
            }
        }
    }
}