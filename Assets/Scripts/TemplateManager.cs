using UnityEngine;

public class TemplateManager : MonoBehaviour
{
    public Renderer overlayRenderer;      // Quad Renderer for AR Overlay
    public Sprite[] sketchTemplates;      // Array of templates
    private int currentIndex = 0;

    void Start()
    {
        // Start with the first template if available
        if (sketchTemplates.Length > 0)
            ChangeTemplate(0);
    }

    public void ChangeTemplate(int index)
    {
        if (index >= 0 && index < sketchTemplates.Length)
        {
            currentIndex = index;
            overlayRenderer.material.mainTexture = sketchTemplates[index].texture;
        }
    }

    public void NextTemplate()
    {
        currentIndex = (currentIndex + 1) % sketchTemplates.Length;
        ChangeTemplate(currentIndex);
    }

    public void PreviousTemplate()
    {
        currentIndex--;
        if (currentIndex < 0) currentIndex = sketchTemplates.Length - 1;
        ChangeTemplate(currentIndex);
    }
}
