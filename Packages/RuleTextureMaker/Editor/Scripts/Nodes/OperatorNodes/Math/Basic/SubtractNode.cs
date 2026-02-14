using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    public class SubtractNode : OperatorNodeBase2
    {
        protected override float GetResult(float a, float b)
        {
            return a - b;
        }
    }
}
