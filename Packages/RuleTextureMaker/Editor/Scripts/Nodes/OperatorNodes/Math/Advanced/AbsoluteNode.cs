using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    public class AbsoluteNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return Mathf.Abs(a);
        }
    }
}
