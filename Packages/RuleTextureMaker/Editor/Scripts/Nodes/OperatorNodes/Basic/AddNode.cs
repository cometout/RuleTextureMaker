using System;
using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    public class AddNode : OperatorNodeBase2
    {
        protected override float GetResult(float a, float b)
        {
            return a + b;
        }
    }
}
