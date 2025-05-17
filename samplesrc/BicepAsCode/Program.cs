using BicepAsCode;

Console.WriteLine("Creating Bicep");

var infrastructure = Bicep.GetInfrastructureWithResources("prod");
var provisioningPlan = infrastructure.Build();
var gitRoot = GetGitRoot.GetGitRootPath();
var savePath = Path.Combine(gitRoot, "iac", nameof(BicepAsCode));
provisioningPlan.Save(savePath);

Console.WriteLine("Bicep created");
