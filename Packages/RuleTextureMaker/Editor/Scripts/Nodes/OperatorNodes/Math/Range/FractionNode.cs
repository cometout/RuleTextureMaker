using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    [System.Serializable]
    public class FractionNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return a - Mathf.Floor(a);
        }
    }
}
