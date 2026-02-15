using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    [System.Serializable]
    public class NegateNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return a * -1;
        }
    }
}
