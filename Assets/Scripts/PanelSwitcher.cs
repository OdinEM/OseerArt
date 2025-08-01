using UnityEngine;

public class PanelSwitcher : MonoBehaviour
{
    public GameObject logoPanel;
    public GameObject startPanel;
    public float delay = 3f;  

    void Start()
    {
        
        logoPanel.SetActive(true);
        startPanel.SetActive(false);

      
        Invoke("ShowStartPanel", delay);
    }

    void ShowStartPanel()
    {
        logoPanel.SetActive(false);
        startPanel.SetActive(true);
    }
}
