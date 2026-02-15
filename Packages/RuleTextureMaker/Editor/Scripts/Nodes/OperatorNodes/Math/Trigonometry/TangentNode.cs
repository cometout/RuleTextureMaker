using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    [System.Serializable]
    public class TangentNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return Mathf.Tan(a);
        }
    }
}
