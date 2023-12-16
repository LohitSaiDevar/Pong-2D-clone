using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void MoveScene(int sceneID)
    {
        Debug.Log("Game has started");

        SceneManager.LoadScene(sceneID);
    }
}
