using System;
using System.IO;

namespace Hexalize
{
	class Program
	{
		static void Main(string[] args)
		{
			int n;
			var b = new byte[50];

			using(var writer = new StreamWriter(args[0] + ".txt", false))
			using(var fs = File.OpenRead(args[0]))
				while((n = fs.Read(b, 0, b.Length)) > 0)
					writer.WriteLine(BitConverter.ToString(b, 0, n).Replace("-", ""));


			/*			using(var writer = new StreamWriter(args[0] + ".txt", false))
						using (var fs = File.OpenRead(args[0]))
						{
							var b = new byte[fs.Length];
							fs.Read(b, 0, b.Length);
							writer.WriteLine(BitConverter.ToString(b).Replace("-", ""));
						}
						*/
		}
	}
}
