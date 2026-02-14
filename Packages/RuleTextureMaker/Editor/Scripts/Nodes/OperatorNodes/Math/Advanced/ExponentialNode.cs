using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    public class ExponentialNode : OperatorNodeBase
    {
        public enum BaseType
        {
            BaseE,

            Base2,
        }

        const string k_baseOptionName = "Base";

        protected override float GetResult(float a)
        {
            var option = GetNodeOptionByName(k_baseOptionName);
            var baseType = option.TryGetValue(out BaseType type)
                ? type : BaseType.Base2;

            return baseType switch
            {
                BaseType.Base2 => Mathf.Pow(2f, a),
                _              => Mathf.Exp(a),
            };
        }

        protected override void OnDefineOptions(IOptionDefinitionContext context)
        {
            context.AddOption<BaseType>(k_baseOptionName).Build();
        }
    }
}
