using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    public class MaximumNode : OperatorNodeBase2
    {
        protected override float GetResult(float a, float b)
        {
            return Mathf.Max(a, b);
        }
    }
}
