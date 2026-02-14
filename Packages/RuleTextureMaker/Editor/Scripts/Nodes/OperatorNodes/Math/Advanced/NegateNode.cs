using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    public class NegateNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return a * -1;
        }
    }
}
