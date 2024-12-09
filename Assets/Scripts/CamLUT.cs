using UnityEngine;

public class CamLUT : MonoBehaviour
{
    public Material m_renderMaterial;
    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, m_renderMaterial);
    }
}

