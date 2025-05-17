
namespace BicepAsCode.UnitTests;

public class VerifyBicepOutputTests
{
    [Fact]
    public Task OutputMatchesPrevious()
    {
	    var infrastructure = Bicep.GetInfrastructureWithResources("prod");
	    var provisioningPlan = infrastructure.Build();
	    var compiled = provisioningPlan.Compile();
	    var bicepString = compiled.Single().Value;
	    return Verify(bicepString);
    }
}
