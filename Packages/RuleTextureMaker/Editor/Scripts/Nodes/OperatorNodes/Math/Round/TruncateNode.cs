using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    public class TruncateNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return System.MathF.Truncate(a);
        }
    }
}
