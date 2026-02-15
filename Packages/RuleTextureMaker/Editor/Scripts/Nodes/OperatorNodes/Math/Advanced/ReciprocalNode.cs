using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    [System.Serializable]
    public class ReciprocalNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            if(Mathf.Approximately(a, 0f)) { return 0f; }

            return 1 / a;
        }
    }
}
