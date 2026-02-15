namespace Cometout.EditorTools.RuleTextureMaker
{
    [System.Serializable]
    public class HyperbolicCosineNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return System.MathF.Cosh(a);
        }
    }
}
