using System;
using Unity.GraphToolkit.Editor;
using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    [Serializable]
    public abstract class OperatorNodeBase : Node, IOperatorNode
    {
        const string k_aInputName = "A";

        const string k_outputName = "Output";

        protected override void OnDefinePorts(IPortDefinitionContext context)
        {
            // Input
            context.AddInputPort<float>(k_aInputName).Build();

            // Output
            context.AddOutputPort<float>(k_outputName).Build();
        }

        public float Calculate()
        {
            float a = RuleTextureMakerGraph.ResolvePortValue<float>(GetInputPortByName(k_aInputName));
            return GetResult(a);
        }

        protected abstract float GetResult(float a);
    }

    [Serializable]
    public abstract class OperatorNodeBase2 : Node, IOperatorNode
    {
        const string k_aInputName = "A";
        const string k_bInputName = "B";

        const string k_outputName = "Output";

        protected override void OnDefinePorts(IPortDefinitionContext context)
        {
            // Input
            context.AddInputPort<float>(k_aInputName).Build();
            context.AddInputPort<float>(k_bInputName).Build();

            // Output
            context.AddOutputPort<float>(k_outputName).Build();
        }

        public float Calculate()
        {
            float a = RuleTextureMakerGraph.ResolvePortValue<float>(GetInputPortByName(k_aInputName));
            float b = RuleTextureMakerGraph.ResolvePortValue<float>(GetInputPortByName(k_bInputName));

            return GetResult(a, b);
        }

        protected abstract float GetResult(float a, float b);
    }
}
