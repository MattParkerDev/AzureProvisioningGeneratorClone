// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var rootPath = @"C:\Users\Matthew\Documents\Git\AzureProvisioningGeneratorClone\src\Meta.Azure.Provisioning\Generated";

var directories = Directory.EnumerateDirectories(rootPath, "*", SearchOption.TopDirectoryOnly).ToList();

var directoriesToRemove = directories.Select(s => Path.Combine(s, "src", "Generated")).ToList();

foreach (var directory in directoriesToRemove)
{
	if (Directory.Exists(directory))
	{
		Console.WriteLine($"Removing directory: {directory}");
		//Directory.Delete(directory, true);
	}
	else
	{
		Console.WriteLine($"Directory does not exist: {directory}");
	}
}
