using Boo.Lang.Compiler;
using Rhino.DSL;

namespace mlidynamics.com.schedulingdsl
{
    public class SchedulingDslEngine : DslEngine
    {
        protected override void CustomizeCompiler(BooCompiler compiler, CompilerPipeline pipeline, string[] urls)
        {
            pipeline.Insert(1, new ImplicitBaseClassCompilerStep(typeof(BaseScheduler), "Prepare",
                                                                  "Rhino.DSL.Tests.SchedulingDSL"));
        }
    }

}
