using System.Linq;
using Unity.GraphToolkit.Editor;
using UnityEditor.AssetImporters;
using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    [ScriptedImporter(1, RuleTextureMakerGraph.k_assetExtension)]
    public class RuleTextureMakerImporter : ScriptedImporter
    {
        const string k_outputTextureAssetIdName = "OutputRuleTexture";

        Texture2D m_outputTexture;

        public override void OnImportAsset(AssetImportContext ctx)
        {
            var graph = GraphDatabase.LoadGraphForImporter<RuleTextureMakerGraph>(ctx.assetPath);
            if(graph == null)
            {
                Debug.LogError($"Failed to load texture maker graph object: {ctx.assetPath}");
                return;
            }

            CompileGraph(graph);

            if (m_outputTexture)
            {
                ctx.AddObjectToAsset(k_outputTextureAssetIdName, m_outputTexture);
                ctx.SetMainObject(m_outputTexture);
            }
        }

        void CompileGraph(RuleTextureMakerGraph graph)
        {
            // グラフ内のOutputTextureNodeを取得する
            var outputTextureNode = graph.GetNodes().OfType<OutputTextureNode>().FirstOrDefault();
            if(outputTextureNode != null)
            {
                // OutputTextureNodeからTextureを作成
                var texture = outputTextureNode.CreateTexture(graph);
                if (texture != null)
                {
                    m_outputTexture = new Texture2D(texture.width, texture.height);
                    m_outputTexture.SetPixels(texture.GetPixels());
                }
            }

            if(m_outputTexture == null)
            {
                m_outputTexture = CreateTexture(16, 16);     
            }

            m_outputTexture.Apply();

        }

        static Texture2D CreateTexture(int width, int height)
        {
            width  = Mathf.Max(width, 1);
            height = Mathf.Max(height, 1);

            return new Texture2D(width, height, TextureFormat.ARGB32, false)
            {
                name = k_outputTextureAssetIdName
            };
        }
    }
}
