using Unity.GraphToolkit.Editor;
using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    public class CurveNode : Node, IOperatorNode
    {
        const string k_aInputName = "A";

        const string k_curveInputName = "Curve";

        const string k_outputName = "Output";

        protected override void OnDefinePorts(IPortDefinitionContext context)
        {
            // Input
            context.AddInputPort<float>(k_aInputName).Build();

            context.AddInputPort<AnimationCurve>(k_curveInputName).Build();

            // Output
            context.AddOutputPort<float>(k_outputName).Build();
        }

        public float Calculate()
        {
            float a = RuleTextureMakerGraph.ResolvePortValue<float>(GetInputPortByName(k_aInputName));
            var curve = RuleTextureMakerGraph.ResolvePortValue<AnimationCurve>(GetInputPortByName(k_curveInputName));

            return curve.Evaluate(a);
        }
    }
}
