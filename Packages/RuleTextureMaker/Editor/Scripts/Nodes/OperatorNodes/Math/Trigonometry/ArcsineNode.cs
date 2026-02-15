using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    [System.Serializable]
    public class ArcsineNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return Mathf.Asin(a);
        }
    }
}
