using System.Collections.Generic;

namespace ClassLibrary2
{
    public class BaseSidebar:BasePageObject
    {
        public List<WebElementWrapper> sidebar;

        public override void Init(DriverWrapper driver)
        {
            sidebar = new List<WebElementWrapper>();
            sidebar = driver.GetElementsByXpath("//ul[@class='nav side-menu']/li");
            base.Init(driver);
        }
    }
}