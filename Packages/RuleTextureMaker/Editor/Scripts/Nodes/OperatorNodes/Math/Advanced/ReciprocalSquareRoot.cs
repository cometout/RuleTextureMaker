using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    public class ReciprocalSquareRoot : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            if (Mathf.Approximately(a, 0f)) { return 0f; }

            return 1 / Mathf.Sqrt(a);
        }
    }
}
