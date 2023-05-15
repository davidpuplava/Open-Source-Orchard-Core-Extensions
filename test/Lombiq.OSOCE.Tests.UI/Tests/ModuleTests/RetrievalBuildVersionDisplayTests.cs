using Lombiq.Hosting.BuildVersionDisplay.Tests.UI.Extensions;
using Lombiq.Tests.UI.Attributes;
using Lombiq.Tests.UI.Services;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Lombiq.OSOCE.Tests.UI.Tests.ModuleTests;

public class RetrievalBuildVersionDisplayTests : UITestBase
{
    public RetrievalBuildVersionDisplayTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper)
    {
    }

    [Theory(Skip = "Not needed for troubleshooting."), Chrome]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "xUnit1004:Test methods should not be skipped", Justification = "I'm debugging.")]
    public Task BuildVersionShouldBeBeDisplayedCorrectly(Browser browser) =>
        ExecuteTestAfterSetupAsync(
            context => context.TestBuildVersionDisplayAsync(),
            browser);
}
