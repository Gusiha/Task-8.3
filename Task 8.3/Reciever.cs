using System.IO;

namespace Task_8._3
{
    class Reciever
    {
        public string Path { get; set; }

        public void WriteInFile(string text)
        {

            if (!File.Exists(Path))
            {
                using (StreamWriter sw = File.CreateText(Path))
                {
                    sw.Write(text);
                }

            }

        }

        public Reciever(string path)
        {
            Path = path;
        }
    }
}
