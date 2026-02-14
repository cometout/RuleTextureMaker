using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    public class ModuloNode : OperatorNodeBase2
    {
        protected override float GetResult(float a, float b)
        {
            return a - b * Mathf.Floor(a / b);
        }
    }
}
