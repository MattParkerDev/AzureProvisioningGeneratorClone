using CliWrap;
using CliWrap.Buffered;
using DetermineIfPublishNecessary;

Console.WriteLine("Building NuGet package");

var gitRootDirectory = GitRoot.GetGitRootPath();

var result = await Cli.Wrap("dotnet")
	.WithArguments("build -c Release")
	.WithWorkingDirectory(Path.Combine(gitRootDirectory, "src", "Meta.Azure.Provisioning"))
	.ExecuteBufferedAsync();

Console.WriteLine(result.StandardOutput);
Console.WriteLine(result.StandardError);

var publishFolderPath = Path.Combine(gitRootDirectory, "artifacts", "package", "release");
var folderInfo = new DirectoryInfo(publishFolderPath);
if (folderInfo.Exists is false) throw new DirectoryNotFoundException(publishFolderPath);

var packageFiles = folderInfo.EnumerateFiles("*.nupkg").ToList();
var packageFile = packageFiles.Single();

Console.WriteLine("Package built and located");
Console.WriteLine("Publishing to Nuget");

var nugetToken = Environment.GetEnvironmentVariable("NUGET_AUTH_TOKEN");
ArgumentException.ThrowIfNullOrWhiteSpace(nugetToken, nameof(nugetToken));

var publishResult = await Cli.Wrap("dotnet")
	.WithArguments($"nuget push {packageFile.FullName} --api-key {nugetToken} --source https://apiint.nugettest.org/v3/index.json")
	.WithValidation(CommandResultValidation.None)
	.ExecuteBufferedAsync();

Console.WriteLine(publishResult.StandardOutput);
Console.WriteLine(publishResult.StandardError);

if (publishResult.ExitCode != 0)
{
	throw new Exception("Failed to publish package to Nuget");
}
