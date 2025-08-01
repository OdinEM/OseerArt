using UnityEngine;
using TMPro; 

public class TypewriterEffect : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    public float delay = 0.1f; 

    private string fullText;

    void Start()
    {
        fullText = textMesh.text;
        textMesh.text = "";
        StartCoroutine(TypeText());
    }

    System.Collections.IEnumerator TypeText()
    {
        foreach (char c in fullText)
        {
            textMesh.text += c;
            yield return new WaitForSeconds(delay);
        }
    }
}
