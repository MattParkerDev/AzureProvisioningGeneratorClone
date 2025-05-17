using Azure.Provisioning;
using Azure.Provisioning.OperationalInsights;

namespace Meta.Azure.Provisioning.Generated.Azure.Provisioning.OperationalInsights.src;

internal class EnsureDailyQuotaType
{
	private void Test()
	{
		var workspaceCapping = new OperationalInsightsWorkspaceCapping();
		// This line will break when re-generating the code, as the generated code mistakenly uses double as the type for DailyQuotaInGB. Just change it back
		// This has been fixed by https://github.com/Azure/azure-sdk-for-net/issues/48249
		workspaceCapping.DailyQuotaInGB = new BicepValue<double>(30d);
	}
}
