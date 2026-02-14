using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    public class OneMinusNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return 1 - a;
        }
    }
}
