using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    [System.Serializable]
    public class DegreesToRadiansNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return a * Mathf.Deg2Rad;
        }
    }
}
