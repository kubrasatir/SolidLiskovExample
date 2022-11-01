using SolidLiskovExample;
 
AccessDataFile accessDataFile = new AdminDataFileUser();
accessDataFile.FilePath = @"c:\temp\a.txt";

accessDataFile.ReadFile(); 
accessDataFile.WriteFile();

AccessDataFile accessDataFileR = new RegularDataFileUser();
accessDataFileR.FilePath = @"d:\temp\a.txt";
accessDataFileR.ReadFile(); 

Console.ReadKey();
