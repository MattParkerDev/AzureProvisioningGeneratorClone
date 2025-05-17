namespace SourceSync;

public class Copy
{
	// https://learn.microsoft.com/en-us/dotnet/standard/io/how-to-copy-directories
	public static void CopyDirectory(string sourceDir, string destinationDir, bool recursive, string[]? ignoredTopLevelDirectoryNames = null,
		string[]? ignoredFileExtensions = null, string[]? ignoredFiles = null)
	{
		// Get information about the source directory
		var dir = new DirectoryInfo(sourceDir);

		// Check if the source directory exists
		if (!dir.Exists)
			throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

		// Cache directories before we start copying
		DirectoryInfo[] dirs = dir.GetDirectories();
		if (ignoredTopLevelDirectoryNames is not null)
		{
			dirs = dirs.Where(s => ignoredTopLevelDirectoryNames.Contains(s.Name) is false).ToArray();
		}
		// Create the destination directory
		Directory.CreateDirectory(destinationDir);

		// Get the files in the source directory and copy to the destination directory
		var files = dir.GetFiles();
		if (ignoredFileExtensions is not null)
		{
			files = files.Where(s => ignoredFileExtensions.Contains(s.Extension) is false).ToArray();
		}
		if (ignoredFiles is not null)
		{
			files = files.Where(s => ignoredFiles.Contains(s.Name) is false).ToArray();
		}
		foreach (FileInfo file in files)
		{
			string targetFilePath = Path.Combine(destinationDir, file.Name);
			file.CopyTo(targetFilePath, true);
		}

		// If recursive and copying subdirectories, recursively call this method
		if (recursive)
		{
			foreach (DirectoryInfo subDir in dirs)
			{
				string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
				CopyDirectory(subDir.FullName, newDestinationDir, true, null, ignoredFileExtensions, ignoredFiles);
			}
		}
	}
}
