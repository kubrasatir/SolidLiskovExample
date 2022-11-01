namespace SolidLiskovExample
{
    public class RegularDataFileUser : AccessDataFile
    {
        public override void ReadFile()
        {
            // Read File logic  
            Console.WriteLine($"Regular File {FilePath} has been read");
        }

        public override void WriteFile()
        {
            //Write File Logic  
            throw new NotImplementedException();
        }
    }
}
