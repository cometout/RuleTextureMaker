using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    [System.Serializable]
    public class CeilingNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return Mathf.Ceil(a);
        }
    }
}
