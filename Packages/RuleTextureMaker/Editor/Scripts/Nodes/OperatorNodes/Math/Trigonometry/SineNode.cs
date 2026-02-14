using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    public class SineNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return Mathf.Sin(a);
        }
    }
}
