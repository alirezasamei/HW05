string sourcePath = Directory.GetCurrentDirectory();
File.WriteAllText(sourcePath + "\\Source.txt", string.Empty);
try
{
    File.Copy(sourcePath + "\\Source.txt", sourcePath + "\\Archive\\Copy.txt");
    Console.WriteLine("Done!");
}
catch (FileNotFoundException ex)
{
    Console.WriteLine(ex.Message);
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine(ex.Message);
}
catch (IOException ex)
{
    Console.WriteLine(ex.Message);
}
catch(UnauthorizedAccessException ex)
{
    Console.WriteLine(ex.Message);
}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
Console.ReadKey();