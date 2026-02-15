namespace Cometout.EditorTools.RuleTextureMaker
{
    [System.Serializable]
    public class AddNode : OperatorNodeBase2
    {
        protected override float GetResult(float a, float b)
        {
            return a + b;
        }
    }
}
