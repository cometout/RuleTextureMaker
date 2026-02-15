using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    [System.Serializable]
    public class Arctangent2Node : OperatorNodeBase2
    {
        protected override float GetResult(float a, float b)
        {
            return Mathf.Atan2(a, b);
        }
    }
}
