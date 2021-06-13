using System;
using System.Threading.Tasks;
using CopyLib;
namespace CopyDirectory
{
    class Program
    {
        public static ICore copyUtil;

        static async Task Main(string[] args)
        {
            Console.WriteLine("Please provide the path of source folder :");
            String sourcePath = Console.ReadLine();
            Console.WriteLine("Please provide the path of target folder :");
            String destinationPath = Console.ReadLine();
            copyUtil = new Core();
            string result = await copyUtil.copyDirAsync(sourcePath, destinationPath);
            Console.WriteLine(result);
        }
    }
}
