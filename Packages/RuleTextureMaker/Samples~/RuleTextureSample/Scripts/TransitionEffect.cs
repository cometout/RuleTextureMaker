using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image), typeof(Animator))]
public class TransitionEffect : MonoBehaviour
{
    [SerializeField] Button m_testButton;
    [SerializeField, Range(0f, 1f)] float m_progress = 0f;

    static readonly int k_progressShaderID = Shader.PropertyToID("_Progress");

    static readonly int k_animationHash = Animator.StringToHash("TransitionInOut");

    Material m_material;

    void Awake()
    {
        if(TryGetComponent<Image>(out var image))
        {
            m_material = new Material(image.material);
            image.material = m_material;
        }

        if(m_testButton && TryGetComponent<Animator>(out var animator))
        {
            m_testButton.onClick.RemoveAllListeners();
            m_testButton.onClick.AddListener(() =>
            {
                animator.Play(k_animationHash, layer:0, normalizedTime: 0f);
            });
        }
    }

    void Update()
    {
        if (m_material)
        {
            m_material.SetFloat(k_progressShaderID, m_progress);
        }
    }
}
