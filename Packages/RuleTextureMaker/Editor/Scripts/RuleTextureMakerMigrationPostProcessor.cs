#if UNITY_6000_4_OR_NEWER

using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Linq;
using System.IO;
using System;

namespace Cometout.EditorTools.RuleTextureMaker
{
    public static class RuleTextureMakerMigrationPostProcessor
    {
        static readonly Dictionary<string, string> k_replacementRules = new()
        {
            // ① m_Script 参照（実験パッケージ → ビルトインモジュール）
            {
                "m_Script: {fileID: 11500000, guid: 790b4d75d92f4b0984310a268dbd952f, type: 3}",
                "m_Script: {fileID: 12501, guid: 0000000000000000e000000000000000, type: 0}"
            },

            // ② EditorClassIdentifier のアセンブリ名
            {
                "m_EditorClassIdentifier: Unity.GraphToolkit.Editor::",
                "m_EditorClassIdentifier: UnityEditor.dll::"
            },

            // ③ asm 参照（Internal.Editor を先に置換 ← 部分一致を防ぐため）
            {
                "asm: Unity.GraphToolkit.Internal.Editor",
                "asm: UnityEditor.GraphToolkitModule"
            },

            // ④ asm 参照（Editor）— ③ の後に実行されるので誤置換しない
            {
                "asm: Unity.GraphToolkit.Editor",
                "asm: UnityEditor.GraphToolkitModule"
            },
        };

        [MenuItem("CometOut/RuleTextureMaker/Resolve")]
        public static void Process()
        {
            var assets = AssetDatabase
                .FindAssets($"t:{nameof(DefaultAsset)}")
                .Select(AssetDatabase.GUIDToAssetPath)
                .Where(assetPath => assetPath.EndsWith(RuleTextureMakerGraph.k_assetExtension))
                .ToArray();

            EditorUtility.ClearProgressBar();
            for (int i=0; i<assets.Length; i++) 
            {
                string assetPath = assets[i];
                EditorUtility.DisplayProgressBar(
                    title   : $"Resolve RuleTextureMaker",
                    info    : $"Resolve {assetPath} ...",
                    progress: (float)i / assets.Length);
                Resolve(assetPath);
            }
            EditorUtility.ClearProgressBar();

            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }

        static void Resolve(string assetPath)
        {
            try
            {
                string fullPath = Path.GetFullPath(assetPath);
                if (!File.Exists(fullPath)) { return; }

                string content = File.ReadAllText(fullPath);
                if (!content.StartsWith("%YAML")) { return; }

                bool modified = false;
                foreach (var rule in k_replacementRules)
                {
                    if (!content.Contains(rule.Key)) { continue; }
                    
                    content = content.Replace(rule.Key, rule.Value);
                    modified = true;
                }

                if (modified)
                {
                    File.WriteAllText(fullPath, content);
                    Debug.Log($"Resolve --> {assetPath}");
                }
            }
            catch (Exception ex)
            {
                Debug.LogError($"Resolve Failed... --> {assetPath}");
                Debug.LogException(ex);
            }
        }
    }
}

#endif // UNITY_6000_4_OR_NEWER