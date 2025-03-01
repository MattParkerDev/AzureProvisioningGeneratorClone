using Azure.Provisioning;
using Azure.Provisioning.OperationalInsights;

namespace CustomAzureProvisioning.Generated.Azure.Provisioning.OperationalInsights.src;

internal class EnsureDailyQuotaType
{
	private void Test()
	{
		var workspaceCapping = new OperationalInsightsWorkspaceCapping();
		// This line will break when re-generating the code, as the generated code mistakenly uses double as the type for DailyQuotaInGB. Just change it back
		workspaceCapping.DailyQuotaInGB = new BicepValue<int>(30);
	}
}
