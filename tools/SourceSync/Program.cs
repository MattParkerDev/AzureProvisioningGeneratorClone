using SourceSync;

Console.WriteLine("Starting Source Sync...");

// provide a link to the sdk/provisioning folder
var sdkProvisioningPath = @"C:\Users\Matthew\Documents\Git\azure-sdk-for-net\sdk\provisioning";
var destinationPath = @"C:\Users\Matthew\Documents\Git\AzureProvisioningGeneratorClone\src\Meta.Azure.Provisioning\Generated";

// get folder names starting with Azure.
var folderNames = Directory.EnumerateDirectories(sdkProvisioningPath, "Azure.*", SearchOption.TopDirectoryOnly)
	.ToList();

;
foreach (var folderName in folderNames)
{
	Copy.CopyDirectory(folderName, destinationPath, true);
}
