using Microsoft.Owin;
using Owin;
using Tracker.WebAPIClient;

[assembly: OwinStartupAttribute(typeof(Week12MVCHealthApp2223.S00214383.Startup))]
namespace Week12MVCHealthApp2223.S00214383
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ActivityAPIClient.Track(StudentID: "S00214383",
StudentName: "Rudgery Lopes", activityName: "Rad301 2223 Week 12 Lab",
Task: "Starting Week 12 Lab");
        }
    }
}
