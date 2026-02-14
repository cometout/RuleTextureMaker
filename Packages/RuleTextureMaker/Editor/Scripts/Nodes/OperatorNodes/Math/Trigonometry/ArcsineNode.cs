using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    public class ArcsineNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return Mathf.Asin(a);
        }
    }
}
