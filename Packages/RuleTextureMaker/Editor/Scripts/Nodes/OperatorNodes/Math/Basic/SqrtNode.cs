using System;
using Unity.GraphToolkit.Editor;
using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    public class SqrtNode : OperatorNodeBase
    {
        protected override float GetResult(float a)
        {
            return Mathf.Sqrt(a);
        }
    }
}
