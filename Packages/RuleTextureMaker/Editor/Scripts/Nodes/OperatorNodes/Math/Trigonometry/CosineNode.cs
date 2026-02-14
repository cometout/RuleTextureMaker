using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    public class CosineNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return Mathf.Cos(a);
        }
    }
}
