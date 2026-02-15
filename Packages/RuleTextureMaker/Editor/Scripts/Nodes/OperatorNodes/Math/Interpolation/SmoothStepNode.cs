using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    [System.Serializable]
    public class SmoothStepNode : OperatorNodeBase3
    {
        protected override string AInputName { get; } = "from";
        protected override string BInputName { get; } = "to";
        protected override string CInputName { get; } = "t";

        protected override float GetResult(float a, float b, float c)
        {
            return Mathf.SmoothStep(a, b, c);
        }
    }
}
