using UnityEngine;
using UnityEngine.Rendering;

public class UIAmbientLightCamera : MonoBehaviour
{
    [SerializeField] private Camera m_Camera;

    private void Awake()
    {
        if (m_Camera == null)
            m_Camera = GetComponent<Camera>();
    }

    void OnEnable()
    {
        RenderPipelineManager.beginCameraRendering += OnBeginCameraRendering;
        RenderPipelineManager.endCameraRendering += OnEndCameraRendering;
    }

    void OnDisable()
    {
        RenderPipelineManager.beginCameraRendering -= OnBeginCameraRendering;
        RenderPipelineManager.endCameraRendering -= OnEndCameraRendering;
    }

    void OnBeginCameraRendering(ScriptableRenderContext context, Camera cam)
    {
        if (cam == m_Camera)
            RenderSettings.fog = false;
        else
            RenderSettings.fog = true;
    }

    void OnEndCameraRendering(ScriptableRenderContext context, Camera cam)
    {
        if (cam == m_Camera)
            RenderSettings.fog = false;
        else
            RenderSettings.fog = true;
    }
}