using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    [System.Serializable]
    public class SqrtNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return Mathf.Sqrt(a);
        }
    }
}
