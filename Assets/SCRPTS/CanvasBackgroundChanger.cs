using UnityEngine;
using UnityEngine.UI;

public class CanvasBackgroundChanger : MonoBehaviour
{
    public Image portraitImage;
    public Image landscapeImage;

    void Start()
    {
        // Initially show portrait image
        portraitImage.gameObject.SetActive(true);
        landscapeImage.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Screen.width > Screen.height) // Landscape
        {
            portraitImage.gameObject.SetActive(false);
            landscapeImage.gameObject.SetActive(true);
        }
        else // Portrait
        {
            portraitImage.gameObject.SetActive(true);
            landscapeImage.gameObject.SetActive(false);
        }
    }
}