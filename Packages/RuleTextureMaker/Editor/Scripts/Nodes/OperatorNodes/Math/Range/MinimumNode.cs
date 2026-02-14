using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    public class MinimumNode : OperatorNodeBase2
    {
        protected override float GetResult(float a, float b)
        {
            return Mathf.Min(a, b);
        }
    }
}
