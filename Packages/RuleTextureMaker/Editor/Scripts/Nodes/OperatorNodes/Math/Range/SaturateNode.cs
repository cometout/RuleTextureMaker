using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    [System.Serializable]
    public class SaturateNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return Mathf.Clamp01(a);
        }
    }
}
