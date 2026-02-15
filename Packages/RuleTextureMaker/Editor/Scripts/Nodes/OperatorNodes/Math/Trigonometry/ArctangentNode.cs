using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    [System.Serializable]
    public class ArctangentNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return Mathf.Atan(a);
        }
    }
}
