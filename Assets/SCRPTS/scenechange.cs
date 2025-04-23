using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    // Specify the name of the scene you want to load
    public string sceneToLoad;

    // Start is called before the first frame update
    void Start()
    {
        // Get the button component and add a listener to it
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(ChangeScene);
        }
    }

    // Method to change the scene
    void ChangeScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}