using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    public class ClampNode : OperatorNodeBase3
    {
        protected override string BInputName { get; } = "Min";
        protected override string CInputName { get; } = "Max";

        protected override float GetResult(float a, float b, float c)
        {
            return Mathf.Clamp(a, b, c);
        }
    }
}
