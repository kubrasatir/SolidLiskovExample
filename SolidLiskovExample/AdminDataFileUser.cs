namespace SolidLiskovExample
{
    public class AdminDataFileUser : AccessDataFile
    {
        public override void ReadFile()
        {
            // Read File logic  
            Console.WriteLine($"Admin File {FilePath} has been read");
        }

        public override void WriteFile()
        {
            //Write File Logic  
            Console.WriteLine($"Admin File {FilePath} has been written");
        }
    }
}
