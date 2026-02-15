using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    [System.Serializable]
    public class PowerNode : OperatorNodeBase2
    {
        protected override float GetResult(float a, float b)
        {
            return Mathf.Pow(a, b);
        }
    }
}
