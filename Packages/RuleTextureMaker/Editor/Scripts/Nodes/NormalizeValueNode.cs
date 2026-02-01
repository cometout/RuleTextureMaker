using System;
using Unity.GraphToolkit.Editor;
using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    [Serializable]
    public class NormalizeValueNode : Node, IValueNode
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
            m_x = Mathf.Clamp01(x);
        }

        public void SetY(float y)
        {
            m_y = Mathf.Clamp01(y);
        }

        public float GetValue(string portName)
        {
            return portName switch
            {
                k_xOutputName => m_x,
                k_yOutputName => m_y,
                _             => 0f
            };
        }
    }
}
