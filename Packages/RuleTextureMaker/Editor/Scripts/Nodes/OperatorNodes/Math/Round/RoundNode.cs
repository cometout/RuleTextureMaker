using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    public class RoundNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return Mathf.Round(a);
        }
    }
}
