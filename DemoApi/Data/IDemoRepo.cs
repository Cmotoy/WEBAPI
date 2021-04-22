using System.Collections.Generic;
using DemoApi.Models;

namespace DemoApi.Data
{
    public interface IDemoRepo
    {
        IEnumerable<DemoApp> GetAppDemos ();
        DemoApp GetDemoAppById (int id);
    }
}