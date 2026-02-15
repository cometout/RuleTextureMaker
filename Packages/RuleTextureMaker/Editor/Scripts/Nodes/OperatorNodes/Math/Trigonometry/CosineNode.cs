using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    [System.Serializable]
    public class CosineNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return Mathf.Cos(a);
        }
    }
}
