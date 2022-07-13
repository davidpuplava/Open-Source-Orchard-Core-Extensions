﻿using Lombiq.Tests.UI.Attributes;
using Lombiq.Tests.UI.Services;
using Lombiq.UIKit.Tests.UI.Extensions;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using Lombiq.HelpfulLibraries.OrchardCore.Mvc;
using Lombiq.Tests.UI.Extensions;
using Lombiq.Tests.UI.Services;
using OpenQA.Selenium;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using Atata;
using Lombiq.Tests.UI.Extensions;
using Lombiq.Tests.UI.Services;
using OpenQA.Selenium;
using Shouldly;
using System;
using System.Threading.Tasks;

namespace Lombiq.OSOCE.Tests.UI.Tests;

public class BehaviorUIKitShowcaseTests : UITestBase
{
    public BehaviorUIKitShowcaseTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper)
    {
    }

    [Theory, Chrome]
    public Task UIKitShowcasePageShouldBeCorrect(Browser browser)
        => ExecuteTestAfterSetupAsync(
            context =>
            {
                // Groups are correct
                string[] correctGroupnames =
                {
                    "Textbox:", "Checkbox:", "Custom classes:", "Hint positioning:", "Bootstrap dropdown:", "Bootstrap controls:"
                };

                var groupNames = context.GetAll(By.CssSelector("showcaseContainer__item h1"));

                groupNames.ShouldBeSameAs(correctGroupnames);
            }, browser);
}
