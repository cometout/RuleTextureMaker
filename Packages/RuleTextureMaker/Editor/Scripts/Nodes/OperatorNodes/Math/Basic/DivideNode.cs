using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    public class DivideNode : OperatorNodeBase2
    {
        protected override float GetResult(float a, float b)
        {
            if(Mathf.Approximately(b, 0))
            {
                throw new System.DivideByZeroException();
            }
            return a / b;
        }
    }
}
