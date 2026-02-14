using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    public class SaturateNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return Mathf.Clamp01(a);
        }
    }
}
