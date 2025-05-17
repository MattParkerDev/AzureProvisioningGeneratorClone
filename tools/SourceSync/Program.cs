using SourceSync;

Console.WriteLine("Starting Source Sync...");

// provide a link to the sdk/provisioning folder
var sdkProvisioningPath = @"C:\Users\Matthew\Documents\Git\azure-sdk-for-net\sdk\provisioning";
var destinationPath = @"C:\Users\Matthew\Documents\Git\AzureProvisioningGeneratorClone\src\Meta.Azure.Provisioning\Generated";

// get folder names starting with Azure.
var folderNames2 = Directory.EnumerateDirectories(sdkProvisioningPath, "TestFolder*", SearchOption.TopDirectoryOnly)
	//.Select(Path.GetFileName)
	.ToList();

;
Copy.CopyDirectory(folderNames2[0], destinationPath, true);
