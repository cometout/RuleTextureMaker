using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    public class TangentNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return Mathf.Tan(a);
        }
    }
}
