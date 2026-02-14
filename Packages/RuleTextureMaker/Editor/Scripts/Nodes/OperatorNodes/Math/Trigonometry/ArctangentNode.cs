using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    public class ArctangentNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return Mathf.Atan(a);
        }
    }
}
