using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    public class RandomRangeNode : OperatorNodeBase3
    {
        protected override string AInputName { get; } = "Seed";
        protected override string BInputName { get; } = "Min";
        protected override string CInputName { get; } = "Max";

        static readonly Vector2 k_coefficient = new(12.9898f, 78.233f);

        protected override float GetResult(float a, float b, float c)
        {
            float dot = Vector2.Dot(new Vector2(a,a), k_coefficient);

            float ramdom01 = Frac(Mathf.Sign(dot) * 43758.5453f);

            return Mathf.Lerp(b, c, ramdom01);
        }

        float Frac(float value)
        {
            return value - Mathf.Floor(value);
        }
    }
}
