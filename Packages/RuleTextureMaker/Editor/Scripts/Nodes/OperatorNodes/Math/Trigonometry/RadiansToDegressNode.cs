using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    [System.Serializable]
    public class RadiansToDegressNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return a * Mathf.Rad2Deg;
        }
    }
}
