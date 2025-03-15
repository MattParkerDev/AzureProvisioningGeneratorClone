// See https://aka.ms/new-console-template for more information

using DetermineIfPublishNecessary;

var gitRootDirectory = GitRoot.GetGitRootPath();
var packageProjectFilePath = Path.Combine(gitRootDirectory, "src", "Meta.Azure.Provisioning", "Meta.Azure.Provisioning.csproj");
