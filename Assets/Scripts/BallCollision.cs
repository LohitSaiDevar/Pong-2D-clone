using UnityEngine;

public class BallCollision : MonoBehaviour
{
    public BallMovement ballMovement;
    public ScoreController scoreController;

    void BounceOnCollision(Collision2D c)
    {
        Vector3 ballPosition = this.transform.position;
        Vector3 racketPosition = c.gameObject.transform.position;

        float racketHeight = c.collider.bounds.size.y;
        float x;

        if (c.gameObject.name == "Player1Con")
        {
            x = 1;
        }
        else
        {
            x = -1;
        }

        float y = (ballPosition.y - racketPosition.y)/ racketHeight;
        this.ballMovement.IncreasedHitCount();
        this.ballMovement.MoveBall(new Vector2(x, y));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player1Con" || collision.gameObject.name == "Player2Con")
        {
            this.BounceOnCollision(collision);
        }
        else if (collision.gameObject.name == "Wall_left")
        {
            Debug.Log("Collision left");
            this.scoreController.GoalPlayer1();
            StartCoroutine(ballMovement.StartBall(true));
        }
        else if (collision.gameObject.name == "Wall_right")
        {
            Debug.Log("Collision Right");
            this.scoreController.GoalPlayer2();
            StartCoroutine(ballMovement.StartBall(false));
        }
        else
        {
            Debug.Log("No collision");
        }
    }
}
