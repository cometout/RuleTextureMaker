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

        [SerializeField] TextureWrapMode m_wrapMode = TextureWrapMode.Repeat;
        [SerializeField] FilterMode m_filterMode = FilterMode.Bilinear;
        [Range(0, 16)]
        [SerializeField] int m_anisoLevel = 1;

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
                    m_outputTexture = CreateTexture(texture.width, texture.height);
                    m_outputTexture.SetPixels(texture.GetPixels());
                }
            }

            if(m_outputTexture == null)
            {
                m_outputTexture = CreateTexture(16, 16);     
            }

            m_outputTexture.Apply();

        }

        Texture2D CreateTexture(int width, int height)
        {
            width  = Mathf.Max(width, 1);
            height = Mathf.Max(height, 1);

            return new Texture2D(width, height, TextureFormat.RGB24, true)
            {
                name       = k_outputTextureAssetIdName,
                wrapMode   = m_wrapMode,
                filterMode = m_filterMode,
                anisoLevel = m_anisoLevel,
            };
        }
    }
}
