using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    [System.Serializable]
    public class OneMinusNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return 1 - a;
        }
    }
}
