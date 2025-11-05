using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing; // For Resize()
using System;
using System.IO;
using System.Threading.Tasks;

namespace ImageProcessingParallel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define folders
            string inputDir = Path.Combine(Environment.CurrentDirectory, "input");
            string outputDir = Path.Combine(Environment.CurrentDirectory, "output");

            // Create output folder if it doesn't exist
            Directory.CreateDirectory(outputDir);

            // Get all image files
            var imageFiles = Directory.GetFiles(inputDir, "*.*", SearchOption.TopDirectoryOnly);
            Console.WriteLine($"Found {imageFiles.Length} image(s) in {inputDir}");

            // Process each image in parallel
            Parallel.ForEach(imageFiles, (filePath) =>
            {
                try
                {
                    using var image = Image.Load(filePath);

                    // Resize to thumbnail (e.g. 150x150)
                    image.Mutate(x => x
      .Resize(150, 150)
      .Grayscale()
      
  );
                    // Save thumbnail to output folder
                    string fileName = Path.GetFileNameWithoutExtension(filePath);
                    string outputPath = Path.Combine(outputDir, $"{fileName}_thumb.jpg");

                    image.SaveAsJpeg(outputPath);
                    Console.WriteLine($"Processed: {fileName}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error processing {filePath}: {ex.Message}");
                }
            });

            Console.WriteLine("All images processed!");
        }
    }
}
