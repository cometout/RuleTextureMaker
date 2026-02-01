using System;
using Unity.GraphToolkit.Editor;
using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    [Serializable]
    public class Int2FloatNode : Node, IOperatorNode
    {
        const string k_intInputName = "Int";

        const string k_floatOutputName = "Output";

        protected override void OnDefinePorts(IPortDefinitionContext context)
        {
            // Input
            context.AddInputPort<int>(k_intInputName).Build();

            // Output
            context.AddOutputPort<float>(k_floatOutputName).Build();
        }

        public float Calculate()
        {
            float input = RuleTextureMakerGraph.ResolvePortValue<int>(GetInputPortByName(k_intInputName));
            return input;
        }
    }
}
