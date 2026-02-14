using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    public class InverseLerpNode : OperatorNodeBase3
    {
        protected override string CInputName { get; } = "value";

        protected override float GetResult(float a, float b, float c)
        {
            return Mathf.InverseLerp(a, b, c);
        }
    }
}
