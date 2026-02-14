using System;
using Unity.GraphToolkit.Editor;

namespace Cometout.EditorTools.RuleTextureMaker
{
    [Serializable]
    public class GetPixelNode : Node, IValueNode
    {
        const string k_xOutputName = "x";
        const string k_yOutputName = "y";

        float m_x = 0f;
        float m_y = 0f;

        protected override void OnDefinePorts(IPortDefinitionContext context)
        {
            // Output
            context.AddOutputPort<float>(k_xOutputName).Build();
            context.AddOutputPort<float>(k_yOutputName).Build();
        }

        public void SetX(float x)
        {
            m_x = x;
        }

        public void SetY(float y)
        {
            m_y = y;
        }

        public float GetValue(string portName)
        {
            return portName switch
            {
                k_xOutputName => m_x,
                k_yOutputName => m_y,
                _ => 0f
            };
        }
    }
}
