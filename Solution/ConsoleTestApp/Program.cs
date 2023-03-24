using Domain;

namespace ConsoleTestApp {
  internal class Program {
    private static void Main(string[] args) {
      Console.WriteLine("Hello, world!");

      byte[] bytes = File.ReadAllBytes(@"D:\GitHub\GitHubTests\Solution\PackagedTestApp\PackagedTestApp (Package)\PackagedTestApp (Package)_TemporaryKey.pfx");
      using (StreamWriter writer = new(new FileStream(@"C:\Temporary\SigningCertificate_Encoded.txt", FileMode.Create))) {
        writer.Write(System.Convert.ToBase64String(bytes));
        writer.Flush();
      }
    }
  }
}