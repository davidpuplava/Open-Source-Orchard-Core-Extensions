using Lombiq.Hosting.Tenants.MediaStorageManagement.Tests.UI.Extensions;
using Lombiq.Tests.UI.Attributes;
using Lombiq.Tests.UI.Services;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Lombiq.OSOCE.Tests.UI.Tests.ModuleTests;

public class BehaviorMediaStorageManagementTests : UITestBase
{
    public BehaviorMediaStorageManagementTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper)
    {
    }

    [Theory(Skip = "Not needed for troubleshooting."), Chrome]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "xUnit1004:Test methods should not be skipped", Justification = "I'm debugging.")]
    public Task MediaQuotaShouldWork(Browser browser) =>
        ExecuteTestAfterSetupAsync(
            async context => await context.TestMediaStorageManagementBehaviorAsync(),
            browser,
            // Setting maximum storage quota for 50 000 bytes to see if it fails with the sample png file.
            configuration => configuration.SetMediaStorageManagementOptionsForUITest(50_000));
}
