using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    [System.Serializable]
    public class LogNode : OperatorNodeBase
    {
        public enum BaseType
        {
            BaseE,

            Base2,

            Base10,
        }

        const string k_baseOptionName = "Base";

        protected override float GetResult(float a)
        {
            var option = GetNodeOptionByName(k_baseOptionName);
            var baseType = option.TryGetValue(out BaseType type)
                ? type : BaseType.Base2;

            return baseType switch
            {
                BaseType.Base2  => Mathf.Log(a, 2f),
                BaseType.Base10 => Mathf.Log10(a),
                _               => Mathf.Log(a),
            };
        }

        protected override void OnDefineOptions(IOptionDefinitionContext context)
        {
            context.AddOption<BaseType>(k_baseOptionName).Build();
        }
    }
}
