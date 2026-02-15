using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    [System.Serializable]
    public class ArccosineNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return Mathf.Acos(a);
        }
    }
}
