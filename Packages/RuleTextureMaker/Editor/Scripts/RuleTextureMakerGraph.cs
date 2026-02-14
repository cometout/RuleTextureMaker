using System;
using System.Linq;
using Unity.GraphToolkit.Editor;
using UnityEditor;
using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    [Graph(k_assetExtension)]
    [Serializable]
    public class RuleTextureMakerGraph : Graph
    {
        /// <summary>
        /// 拡張子
        /// </summary>
        public const string k_assetExtension = "ruletexture";

        const string k_newAssetName = "New RuleTexture";

        [MenuItem("Assets/Create/Cometout/RuleTexture Maker Graph", false)]
        static void CreateAsset()
        {
            GraphDatabase
                .PromptInProjectBrowserToCreateNewAsset<RuleTextureMakerGraph>(k_newAssetName);
        }

        public override void OnGraphChanged(GraphLogger graphLogger)
        {
            CheckGraph(graphLogger);    
        }

        void CheckGraph(GraphLogger graphLogger)
        {
            var outputTextureNodes = GetNodes().OfType<OutputTextureNode>().ToArray();
            switch (outputTextureNodes.Length)
            {
            case 0:
                break;

            default:
                break;
            }
        }

        public static T ResolvePortValue<T>(IPort port)
        {
            var sourcePort = port.firstConnectedPort;

            return (sourcePort?.GetNode()) switch
            {
                // 定数ノード
                IConstantNode constantNode
                         when constantNode.TryGetValue(out T constantValue) => constantValue,
                // 変数ノード
                IVariableNode variableNode
                         when variableNode.variable.TryGetDefaultValue(out T variableValue) => variableValue,
                IValueNode valueNode
                         when typeof(T).IsAssignableFrom(typeof(float)) => (T)(object)valueNode.GetValue(sourcePort.name),
                IOperatorNode operatorNode
                         when typeof(T).IsAssignableFrom(typeof(int))
                           || typeof(T).IsAssignableFrom(typeof(float)) => (T)(object)operatorNode.Calculate(),
                // ポートがつながっていないので、直で設定している値を取得する
                null when port.TryGetValue<T>(out var value) => value,
                
                _ => default,
            };
        }
    }
}
