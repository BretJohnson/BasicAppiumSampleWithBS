using OpenQA.Selenium.Appium;

namespace UITests.Android.Shared;

public abstract class BaseTest
{
    protected AppiumDriver App => AppiumSetup.App;

    protected AppiumElement FindUIElement(string id)
    {
        return App.FindElement(MobileBy.Id(id));
    }
}
