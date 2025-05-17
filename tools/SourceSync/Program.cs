using SourceSync;

Console.WriteLine("Starting Source Sync...");

// provide a link to the sdk/provisioning folder
var sdkProvisioningPath = @"C:\Users\Matthew\Documents\Git\azure-sdk-for-net\sdk\provisioning";
var rootDestinationPath = @"C:\Users\Matthew\Documents\Git\AzureProvisioningGeneratorClone\src\Meta.Azure.Provisioning\Generated";

// get folder names starting with Azure.
var folderPaths = Directory.EnumerateDirectories(sdkProvisioningPath, "Azure.*", SearchOption.TopDirectoryOnly)
	.ToList();

;
foreach (var folderPath in folderPaths)
{
	var folderName = Path.GetFileName(folderPath);
	var destinationPath = Path.Combine(rootDestinationPath, folderName);
	Copy.CopyDirectory(folderPath, destinationPath, true, ["api", "tests"], [".csproj"], ["assets.json"]);
}
