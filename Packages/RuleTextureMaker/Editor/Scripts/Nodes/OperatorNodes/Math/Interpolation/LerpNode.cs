using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    public class LerpNode : OperatorNodeBase3
    {
        protected override string CInputName { get; } = "t";

        const string k_isUnclampedName = "Is Unclamped";

        protected override float GetResult(float a, float b, float c)
        {
            var option = GetOutputPortByName(k_isUnclampedName);
            bool isUnclamped = option.TryGetValue(out bool flag)
                ? flag : false;

            if (isUnclamped)
            {
                return Mathf.LerpUnclamped(a, b, c);
            }
            else
            {
                return Mathf.Lerp(a, b, c);
            }
        }

        protected override void OnDefineOptions(IOptionDefinitionContext context)
        {
            context.AddOption<bool>(k_isUnclampedName).Build();
        }
    }
}
