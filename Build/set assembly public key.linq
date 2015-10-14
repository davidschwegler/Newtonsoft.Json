<Query Kind="Program">
  <NuGetReference>Mono.Cecil</NuGetReference>
  <Namespace>Mono.Cecil</Namespace>
</Query>

void Main(string[] args)
{
	//var module = ModuleDefinition.ReadModule(@"C:\Code\Utility\packages\Newtonsoft.Json.6.0.5\lib\portable-net45+wp80+win8+wpa81\Newtonsoft.Json.dll");
	//var assemblyName = module.Assembly.Name;
	//string.Join(", ", assemblyName.PublicKey.Select(x => x.ToString()).ToArray()).Dump();
	//string.Join(", ", assemblyName.PublicKeyToken.Select(x => x.ToString()).ToArray()).Dump();

	foreach (var fileName in args)
	{
		var module = ModuleDefinition.ReadModule(fileName);
		var assemblyName = module.Assembly.Name;
		assemblyName.HasPublicKey = true;
		assemblyName.PublicKey = new byte[] { 0, 36, 0, 0, 4, 128, 0, 0, 148, 0, 0, 0, 6, 2, 0, 0, 0, 36, 0, 0, 82, 83, 65, 49, 0, 4, 0, 0, 1, 0, 1, 0, 245, 97, 223, 39, 124, 108, 11, 73, 125, 98, 144, 50, 180, 16, 205, 207, 40, 110, 83, 124, 5, 71, 36, 247, 255, 160, 22, 67, 69, 246, 43, 62, 100, 32, 41, 215, 168, 12, 195, 81, 145, 137, 85, 50, 140, 74, 220, 138, 4, 136, 35, 239, 144, 176, 207, 56, 234, 125, 176, 215, 41, 202, 242, 182, 51, 195, 186, 190, 8, 176, 49, 1, 152, 193, 8, 25, 149, 193, 144, 41, 188, 103, 81, 147, 116, 78, 171, 157, 115, 69, 184, 166, 114, 88, 236, 23, 209, 18, 206, 189, 187, 178, 162, 129, 72, 125, 206, 234, 251, 157, 131, 170, 147, 15, 50, 16, 63, 190, 29, 41, 17, 66, 91, 197, 116, 64, 2, 199 };
		assemblyName.PublicKeyToken = new byte[] { 48, 173, 79, 230, 178, 166, 174, 237 };
		module.Write(fileName);
	}	
}

// Define other methods and classes here
