using DetermineIfPublishNecessary;
using Microsoft.Build.Definition;
using Microsoft.Build.Evaluation;
using Microsoft.Build.Locator;
using NuGet.Versioning;

MSBuildLocator.RegisterDefaults();
Run(); // https://learn.microsoft.com/en-us/visualstudio/msbuild/find-and-use-msbuild-versions?view=vs-2022#register-instance-before-calling-msbuild

return;

void Run()
{
	var gitRootDirectory = GitRoot.GetGitRootPath();
	var packageProjectFilePath = Path.Combine(gitRootDirectory, "src", "Meta.Azure.Provisioning", "Meta.Azure.Provisioning.csproj");

	var fileInfo = new FileInfo(packageProjectFilePath);
	if (fileInfo.Exists is false)
	{
		throw new FileNotFoundException(packageProjectFilePath);
	}

	Console.WriteLine($"Found project file at: {packageProjectFilePath}");

	var project = Project.FromFile(packageProjectFilePath, new ProjectOptions());
	var packageVersionString = project.GetProperty("PackageVersion").EvaluatedValue;
	var packageVersion = SemanticVersion.Parse(packageVersionString);
	;
}
