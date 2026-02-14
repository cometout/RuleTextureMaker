using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    public class HyperbolicCosineNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return System.MathF.Cosh(a);
        }
    }
}
