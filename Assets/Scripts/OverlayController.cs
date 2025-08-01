using UnityEngine;
using UnityEngine.UI;

public class OverlayController : MonoBehaviour
{
    public Renderer overlayRenderer;   // The quad renderer
    public Slider opacitySlider;
    public Slider scaleSlider;

    private Vector3 initialScale;

    void Start()
    {
        // Save the original scale of the overlay
        initialScale = transform.localScale;
    }

    void Update()
    {
        // Update opacity
        if (overlayRenderer != null && opacitySlider != null)
        {
            Color c = overlayRenderer.material.color;
            c.a = opacitySlider.value;  // Set transparency based on slider
            overlayRenderer.material.color = c;
        }

        // Update scale
        if (scaleSlider != null)
        {
            float scaleValue = scaleSlider.value;
            transform.localScale = initialScale * scaleValue;
        }
    }
}
