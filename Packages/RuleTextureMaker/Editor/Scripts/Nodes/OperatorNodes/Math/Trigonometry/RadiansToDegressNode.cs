using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    public class RadiansToDegressNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return a * Mathf.Rad2Deg;
        }
    }
}
