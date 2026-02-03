using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    public class Normalize : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return Mathf.Clamp01(a);
        }
    }
}
