using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    public Button exitButton;

    void Start()
    {
        exitButton.onClick.AddListener(ExitGameOnClick);
    }

    void ExitGameOnClick()
    {
        Application.Quit();
    }
}
