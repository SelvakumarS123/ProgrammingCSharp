namespace Logging_Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //File.AppendAllText("logs.txt", DateTime.Now.ToString()+"\n"); //bin->debug->logs.txt

            String directoryPath = @"C:\Logs";
            String filePath = Path.Combine(directoryPath, "log.txt");
            if (!Directory.Exists(directoryPath)) { 
                Directory.CreateDirectory(directoryPath);
            }
            File.AppendAllText(filePath, DateTime.Now.ToString()+"\n");
        }
    }
}
