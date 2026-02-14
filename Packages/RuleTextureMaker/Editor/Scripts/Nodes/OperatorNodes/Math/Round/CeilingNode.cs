using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    public class CeilingNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return Mathf.Ceil(a);
        }
    }
}
