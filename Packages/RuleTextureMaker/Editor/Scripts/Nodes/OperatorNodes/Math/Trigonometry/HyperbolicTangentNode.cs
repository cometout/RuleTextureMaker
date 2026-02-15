namespace Cometout.EditorTools.RuleTextureMaker
{
    [System.Serializable]
    public class HyperbolicTangentNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return System.MathF.Tanh(a);
        }
    }
}
