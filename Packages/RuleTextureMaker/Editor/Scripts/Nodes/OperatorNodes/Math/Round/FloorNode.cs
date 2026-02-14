using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    public class FloorNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return Mathf.Floor(a);
        }
    }
}
