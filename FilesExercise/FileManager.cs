using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FilesExercise
{
    internal class FileManager
    {

        public class WordListNotFoundException : Exception
        {
            public WordListNotFoundException(string message) : base(message)
            {

            }
        }

        private string filePath;

        // Constructor
        public FileManager()
        {
            this.filePath = string.Empty;
        }

        // Constructor
        public FileManager(string filePathValue)
        {
            this.filePath = filePathValue;
        }

        public string ReadWords()
        {
            string content = string.Empty;


            try
            {
                content = ReadFile();
            }

            catch (Exception ex)
            {
                Console.WriteLine("File manager ei saa tiedosto polkua " + ex.Message);
            }


            return content;
        }

        /* Method reads file from a local 
         * directory path.
         */
        private string ReadFile()
        {
            if (!File.Exists(filePath))
            {
                // Throw exception if file does not exists
                throw new FileNotFoundException("File not available");
            }

            string directoryName = Path.GetDirectoryName(filePath);
            string fileName = Path.GetFileName(filePath);
            string fileExtension = Path.GetExtension(filePath);

            Console.WriteLine("directoryName: " + directoryName);
            Console.WriteLine("fileName: " + fileName);
            Console.WriteLine("fileExtension: " + fileExtension);

            string fileContent = File.ReadAllText(filePath, Encoding.UTF8);
            return fileContent;
        }
    }
}

