using System;
using System.IO;

namespace LemmaSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Out.WriteLine("Training is started.");
            StreamReader sr = new StreamReader(args[0]);
            StreamWriter sw = new StreamWriter(File.OpenWrite(args[1]));
            Lemmatizer lemmatizer = new Lemmatizer(new LemmatizerSettings());
            lemmatizer.AddMultextFile(sr, "WLM");
            lemmatizer.BuildModel();
            lemmatizer.SerializeModel(sw, 0, false );
            Console.Out.WriteLine("Training is finished.");
        }
        
        
    }
}