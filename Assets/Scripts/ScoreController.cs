using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    int scorePlayer1 = 0;
    int scorePlayer2 = 0;

    public GameObject scoreTextPlayer1;
    public GameObject scoreTextPlayer2;

    public int goalToWin;

    

    private void Update()
    {
        if (this.scorePlayer1 >= this.goalToWin || this.scorePlayer2 >= this.goalToWin)
        {
            SceneManager.LoadScene(2);
        }
    }
    public void FixedUpdate()
    {
        Text uiScorePlayer1 = scoreTextPlayer1.GetComponent<Text>();
        uiScorePlayer1.text = this.scorePlayer1.ToString();

        Text uiScorePlayer2 = scoreTextPlayer2.GetComponent<Text>();
        uiScorePlayer2.text = this.scorePlayer2.ToString();
    }

    public void GoalPlayer1()
    {
        this.scorePlayer1++;
    }
    public void GoalPlayer2()
    {
        this.scorePlayer2++;
    }
}
