using UnityEngine;

namespace Cometout.EditorTools.RuleTextureMaker
{
    public interface IValueNode
    {
        void SetX(float x);

        void SetY(float y);

        float GetValue(string portName);
    }
}
