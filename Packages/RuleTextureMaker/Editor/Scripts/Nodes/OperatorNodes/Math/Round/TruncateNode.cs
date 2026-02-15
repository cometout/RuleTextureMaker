namespace Cometout.EditorTools.RuleTextureMaker
{
    [System.Serializable]
    public class TruncateNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return System.MathF.Truncate(a);
        }
    }
}
