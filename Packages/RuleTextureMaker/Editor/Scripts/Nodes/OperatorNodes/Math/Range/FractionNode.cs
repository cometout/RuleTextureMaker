using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    public class FractionNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return a - Mathf.Floor(a);
        }
    }
}
