using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    [System.Serializable]
    public class SignNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return Mathf.Sign(a);
        }
    }
}
