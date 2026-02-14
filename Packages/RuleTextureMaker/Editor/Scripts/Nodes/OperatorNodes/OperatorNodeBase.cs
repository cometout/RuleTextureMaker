using System;
using Unity.GraphToolkit.Editor;
using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    [Serializable]
    public abstract class OperatorNodeBase : Node, IOperatorNode
    {
        const string k_outputName = "Output";

        protected virtual string AInputName { get; } = "A";

        protected override void OnDefinePorts(IPortDefinitionContext context)
        {
            // Input
            context.AddInputPort<float>(AInputName).Build();

            // Output
            context.AddOutputPort<float>(k_outputName).Build();
        }

        public float Calculate()
        {
            var a = RuleTextureMakerGraph.ResolvePortValue<float>(GetInputPortByName(AInputName));
            return GetResult(a);
        }

        protected abstract float GetResult(float a);
    }

    [Serializable]
    public abstract class OperatorNodeBase2 : Node, IOperatorNode
    {
        const string k_outputName = "Output";

        protected virtual string AInputName { get; } = "A";
        protected virtual string BInputName { get; } = "B";

        protected override void OnDefinePorts(IPortDefinitionContext context)
        {
            // Input
            context.AddInputPort<float>(AInputName).Build();
            context.AddInputPort<float>(BInputName).Build();

            // Output
            context.AddOutputPort<float>(k_outputName).Build();
        }

        public float Calculate()
        {
            var a = RuleTextureMakerGraph.ResolvePortValue<float>(GetInputPortByName(AInputName));
            var b = RuleTextureMakerGraph.ResolvePortValue<float>(GetInputPortByName(BInputName));

            return GetResult(a, b);
        }

        protected abstract float GetResult(float a, float b);
    }

    [Serializable]
    public abstract class OperatorNodeBase3 : Node, IOperatorNode
    {
        const string k_outputName = "Output";

        protected virtual string AInputName { get; } = "A";
        protected virtual string BInputName { get; } = "B";
        protected virtual string CInputName { get; } = "C";

        protected override void OnDefinePorts(IPortDefinitionContext context)
        {
            // Input
            context.AddInputPort<float>(AInputName).Build();
            context.AddInputPort<float>(BInputName).Build();
            context.AddInputPort<float>(CInputName).Build();

            // Output
            context.AddOutputPort<float>(k_outputName).Build();
        }

        public float Calculate()
        {
            var a = RuleTextureMakerGraph.ResolvePortValue<float>(GetInputPortByName(AInputName));
            var b = RuleTextureMakerGraph.ResolvePortValue<float>(GetInputPortByName(BInputName));
            var c = RuleTextureMakerGraph.ResolvePortValue<float>(GetInputPortByName(CInputName));

            return GetResult(a, b, c);
        }

        protected abstract float GetResult(float a, float b, float c);
    }
}
