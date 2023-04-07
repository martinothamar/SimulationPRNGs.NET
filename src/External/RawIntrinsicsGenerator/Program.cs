using System.Reflection;

namespace RawIntrinsicsGenerator
{
    public static class Program
	{
		private async static Task Main(string[] _)
		{
			var savePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "RawIntrinsics");
			
			await Generator.Generate("RawIntrinsics", savePath);
			
			Console.WriteLine($"Done! Generated files were saved to {savePath}");
		}
	}
}