namespace Cometout.EditorTools.RuleTextureMaker
{
    [System.Serializable]
    public class HyperbolicSineNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return System.MathF.Sinh(a);
        }
    }
}
