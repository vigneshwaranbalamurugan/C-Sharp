using System;
using System.IO;

class FileHandling{
    public static void Main(){
        string inputFile = "students.csv";
        string outputFile = "result.txt";
        try{
            if(!File.Exists(inputFile)){
                throw new FileNotFoundException("Input file not found.");
            }
            string[] lines=File.ReadAllLines(inputFile);
            int line = lines.Length;
            int word = 0;
            foreach (string l in lines)
            {
                string[] words = l.Split(',');
                word += words.Length;
            }
            File.WriteAllText(outputFile, $"Total Words {word}\n");
            File.AppendAllText(outputFile, $"Total Lines {line}");
        }catch(FileNotFoundException e){
            Console.WriteLine("File Not Found");
        }catch(IOException e){
            Console.WriteLine(e.Message);
        }
    }
}