using System.Collections.Generic;
using DemoApi.Models;

namespace DemoApi.Data
{
    public class MockDemoRepo : IDemoRepo
    {
        public IEnumerable<DemoApp> GetAppDemos()
        {
            var DemoApps = new List<DemoApp>
            {
                new DemoApp {id = 0, HowTo="BuiLd web Api using Postman", Line ="Worry Less about it ", Platform ="Visual Studio Code" },
                new DemoApp {id = 1, HowTo="Be a better Person", Line ="I can't bother  ", Platform ="Azure DevOps" },
                new DemoApp {id = 2, HowTo="Control the universe in a split second", Line ="I can explain this later", Platform ="Visual Studio" }
            };
            return DemoApps;
        }

        public DemoApp GetDemoAppById(int id)
        {
            return new DemoApp {id = 0, HowTo="BuiLd web Api using Postman", Line ="Worry Less about it ", Platform ="Visual Studio Code" };

        }
    }
}