namespace Cometout.EditorTools.RuleTextureMaker
{
    [System.Serializable]
    public class StepNode : OperatorNodeBase2
    {
        protected override string AInputName { get; } = "Edge";

        protected override string BInputName { get; } = "value";

        protected override float GetResult(float a, float b)
        {
            return b < a ? 0f : 1f;
        }
    }
}
