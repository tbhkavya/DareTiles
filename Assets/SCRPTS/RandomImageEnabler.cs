using UnityEngine;
using System.Collections.Generic;

public class RandomImageEnabler : MonoBehaviour
{
    // Array to hold the child GameObjects
    public GameObject[] imageObjects;

    private void Start()
    {
        // Call the method to enable a random image
        EnableRandomImage();
    }

    private void EnableRandomImage()
    {
        // First, disable all image objects
        foreach (GameObject imgObj in imageObjects)
        {
            imgObj.SetActive(false);
        }

        // Get a list of disabled objects
        var disabledObjects = new List<GameObject>();
        foreach (GameObject imgObj in imageObjects)
        {
            if (!imgObj.activeSelf)
            {
                disabledObjects.Add(imgObj);
            }
        }

        // If there are disabled objects, enable one randomly
        if (disabledObjects.Count > 0)
        {
            int randomIndex = Random.Range(0, disabledObjects.Count);
            disabledObjects[randomIndex].SetActive(true);
            Debug.Log("Enabling image: " + disabledObjects[randomIndex].name); // Debug log
        }
        else
        {
            Debug.LogWarning("No disabled objects found to enable.");
        }
    }
}