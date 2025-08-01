using UnityEngine;
using UnityEngine.UI;

public class GalleryImageLoader : MonoBehaviour
{
    public Renderer overlayRenderer; // Quad Renderer for AR Overlay

    public void PickImageFromGallery()
    {
        NativeGallery.GetImageFromGallery((path) =>
        {
            if (path != null)
            {
                // Load the image as Texture2D
                Texture2D texture = NativeGallery.LoadImageAtPath(path, 1024);
                if (texture != null)
                {
                    overlayRenderer.material.mainTexture = texture;
                }
            }
        }, "Select an image to sketch");
    }
}
