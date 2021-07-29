using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.ML;
using static Microsoft.ML.DataOperationsCatalog;
using Microsoft.ML.Vision;

namespace MVClient
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string user_opt = "continue";
            MLContext mlContext = new MLContext();

            //Define DataViewSchema for data preparation pipeline and trained model
            DataViewSchema modelSchema;

            string ModelPath = MVSettings.Default.ModelPath;

            while ((File.Exists(ModelPath) != true) && user_opt != "exit")
            {
                Console.WriteLine("ERROR. There is no Model Available at the selected Path:");
                Console.WriteLine(ModelPath);

                try
                {
                    if (args[0] == "manual")
                    {
                        Console.WriteLine("Type [settings] to select a new path for the Model. Type [exit] to finish Execution:");
                        user_opt = Console.ReadLine();
                        if (user_opt == "settings")
                        {
                            SettingsForm SF = new SettingsForm();
                            SF.ShowDialog();
                        }
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Exit Software Now");
                    return;
                }
            }

            try
            {
                // Load trained model
                ITransformer trainedModel = mlContext.Model.Load(ModelPath, out modelSchema);
                // Model Loaded
                Console.WriteLine("--- Model Loaded. Type Classify to Test an Image ---");


            string img_path;

            while (user_opt != "exit")
            {
                Console.WriteLine("Classifier Ready. Type [help] for Available Options");
                user_opt = Console.ReadLine();
                user_opt = user_opt.ToLower();
                img_path = MVSettings.Default.DefaultTestPath;
                    switch (user_opt)
                {
                    case "classify":
                            bool DirectoryAvailable = Directory.Exists(img_path);
                            int FilesInDir = Directory.GetFiles(img_path).Length;

                            if (DirectoryAvailable && FilesInDir > 0)
                            {
                                // Read the images on the path set by user:
                                try
                                {
                                    IDataView ImgToTest_Prepared = PrepImageData(mlContext, img_path);
                                    ClassifySingleImage(mlContext, ImgToTest_Prepared, trainedModel);
                                }
                                catch
                                {
                                    Console.WriteLine("ERROR During Classification Stage");
                                }
                            }
                            else
                            {
                                Console.WriteLine("ERROR: Test Folder does not Exist or is Empty");
                            }
                        break;
                    case "settings":
                        SettingsForm SF = new SettingsForm();
                        SF.ShowDialog();
                        Console.WriteLine("===  [Settings Saved] ====");
                        break;
                     case "help":
                            Console.WriteLine("Type [classify] to classify the image copied at:");
                            Console.WriteLine(img_path);
                            Console.WriteLine("Type [settings] to set up the default paths for the ML model and Test Path");
                            break;
                   
                }



            }
            }
            catch
            {
                Console.WriteLine("ERROR: Triggered at Model Loading. Verify the Model Path");
                try
                {
                    if (args[0] == "manual")
                    {
                        SettingsForm SF = new SettingsForm();
                        SF.ShowDialog();
                        Console.WriteLine("New Settings loaded. Restart the Software");
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Exit the Software Now");
                }
                Console.WriteLine("Exit the Software Now");
            }

        }

        public static IDataView PrepImageData(MLContext mlContext, string testBenchPath)
        {

            // var testBenchPath = "C:\\Working\\MotoVision\\tests";
            // Single image will be at tests folder
            IEnumerable<ImageData> TestImages = LoadImagesFromDirectory(folder: testBenchPath, useFolderNameAsLabel: true);
            IDataView TestImagesData = mlContext.Data.LoadFromEnumerable(TestImages);
         
            var PPTestImage = mlContext.Transforms.Conversion.MapValueToKey(
                  inputColumnName: "Label",
                  outputColumnName: "LabelAsKey")
                  .Append(mlContext.Transforms.LoadRawImageBytes(
                   outputColumnName: "Image",
                   imageFolder: testBenchPath,
                   inputColumnName: "ImagePath"));

            IDataView PPImageData = PPTestImage.Fit(TestImagesData).Transform(TestImagesData);
            return PPImageData;
        }



        public static IEnumerable<ImageData> LoadImagesFromDirectory(string folder, bool useFolderNameAsLabel = true)
        {
            var files = Directory.GetFiles(folder, "*", searchOption: SearchOption.AllDirectories);

            foreach (var file in files)
            {
                if ((Path.GetExtension(file) != ".jpeg") && (Path.GetExtension(file) != ".png"))
                    continue;
                var label = Path.GetFileName(file);

                if (useFolderNameAsLabel)
                    label = Directory.GetParent(file).Name;
                else
                {
                    for (int index = 0; index < label.Length; index++)
                    {
                        if (!char.IsLetter(label[index]))
                        {
                            label = label.Substring(0, index);
                            break;
                        }
                    }
                }

                yield return new ImageData()
                {
                    ImagePath = file,
                    Label = label
                };

            }

        }

        private static void OutputPrediction(ModelOutput prediction)
        {
            string imageName = Path.GetFileName(prediction.ImagePath);
            Console.WriteLine($"Image: {imageName} | Predicted Value: {prediction.PredictedLabel}");

        }

        public static void ClassifySingleImage(MLContext mlContext, IDataView data, ITransformer trainedModel)
        {
            PredictionEngine<ModelInput, ModelOutput> predictionEngine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(trainedModel);
            ModelInput image = mlContext.Data.CreateEnumerable<ModelInput>(data, reuseRowObject: true).First();
            ModelOutput prediction = predictionEngine.Predict(image);
            Console.WriteLine("Classifying single image");
            OutputPrediction(prediction);
        }



    }


   



}
