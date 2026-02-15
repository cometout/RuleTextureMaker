using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    [System.Serializable]
    public class PosterizeNode : OperatorNodeBase2
    {

        protected override string BInputName { get; } = "Steps";

        protected override float GetResult(float a, float b)
        {
            if(b <= 0f) { return 0f; }

            return Mathf.Floor(a * b) / b;
        }
    }
}
