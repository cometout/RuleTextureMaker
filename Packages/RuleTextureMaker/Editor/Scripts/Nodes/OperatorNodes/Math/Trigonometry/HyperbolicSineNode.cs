using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    public class HyperbolicSineNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return System.MathF.Sinh(a);
        }
    }
}
