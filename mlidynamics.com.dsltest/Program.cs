using mlidynamics.com.schedulingdsl;
using Rhino.DSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mlidynamics.com.dsltest
{
    class Program
    {
        static void Main(string[] args)
        {
            DslFactory factory = new DslFactory();
            factory.Register<BaseScheduler>(new SchedulingDslEngine());
            BaseScheduler scheduler = factory.Create<BaseScheduler>(@"dsl/ValidateWebSiteDown.boo");
            scheduler.Prepare();
            scheduler.Run();

        }
    }
}
