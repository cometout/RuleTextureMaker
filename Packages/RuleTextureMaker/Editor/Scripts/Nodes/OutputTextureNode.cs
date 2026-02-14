using System;
using System.Linq;
using Unity.GraphToolkit.Editor;
using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    [Serializable]
    public class OutputTextureNode : Node
    {
        const string k_widthInputName  = "Width";
        const string k_heightInputName = "Height";

        const string k_formulaInputName = "Formula";

        protected override void OnDefinePorts(IPortDefinitionContext context)
        {
            // Input
            context.AddInputPort<int>(k_widthInputName)
                .WithDefaultValue(defaultValue: 16)
                .Build();
            context
                .AddInputPort<int>(k_heightInputName)
                .WithDefaultValue(defaultValue: 16)
                .Build();

            context
                .AddInputPort<float>(k_formulaInputName)
                .Build();
        }

        public Texture2D CreateTexture(RuleTextureMakerGraph graph)
        {
            // Inputのポートの値を取得
            int width  = RuleTextureMakerGraph.ResolvePortValue<int>(GetInputPortByName(k_widthInputName));
            width = Mathf.Max(width, 1);

            int height = RuleTextureMakerGraph.ResolvePortValue<int>(GetInputPortByName(k_heightInputName));
            height = Mathf.Max(height, 1);

            //
            var nodes = graph.GetNodes();
            var valueNodes = nodes
                .OfType<GetPixelNode>()
                .ToArray();
            var normalizedValueNodes = nodes
                .OfType<GetPixelNormalizedValueNode>()
                .ToArray();

            var texture = new Texture2D(width, height);
            var colors = new Color32[width * height];
            for (int y = 0; y < height; y++)
            {
                SetNormalizeY(valueNodes, y);
                SetNormalizeY(normalizedValueNodes, (float)y / height);
                for (int x = 0; x < width; x++)
                {
                    SetNormalizeX(valueNodes, x);
                    SetNormalizeX(normalizedValueNodes, (float)x /  width);
                    float value = RuleTextureMakerGraph
                        .ResolvePortValue<float>(GetInputPortByName(k_formulaInputName));
                    colors[x + (y * width)] = new Color(value, value, value, a: 1f);
                }
            }
            texture.SetPixels32(colors);
            texture.Apply();
            return texture;
        }

        void SetNormalizeX(IValueNode[] nodes, float x)
        {
            foreach (var node in nodes)
            {
                node.SetX(x);
            }
        }

        void SetNormalizeY(IValueNode[] nodes, float y)
        {
            foreach(var node in nodes)
            {
                node.SetY(y);
            }
        }
    }
}
