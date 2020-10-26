using Sitecore.XA.Foundation.Presentation.Pipelines.ResolveAvailableRenderingsNodeTemplate;

namespace Feature.AMP.AvailableRenderings.Pipelines
{
    public class ResolveAMPAvailableRenderings
    {
        public void Process(ResolveAvailableRenderingsTemplateArgs args)
        {
            if (!args.CurrentItem.Visualization.GetLayout(args.Device).ID.Equals(Items.AMPLayout))
                return;
            args.TemplateId = Feature.AMP.AvailableRenderings.Templates.AvailableAMPRenderings.ID;
            args.AbortPipeline();
        }
    }
}

