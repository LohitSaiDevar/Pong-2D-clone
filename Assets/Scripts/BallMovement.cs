using System.Collections;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float movementSpeed;
    public float speedPerHit;
    public float maxSpeed;

    int hitCount = 0;
    void Start()
    {
        StartCoroutine(this.StartBall());
    }

    void InitialPosition(bool startPlayer1)
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

        if (startPlayer1)
        {
            gameObject.transform.localPosition = new Vector3(-90, -45, 0);
        }
        else
        {
            gameObject.transform.localPosition = new Vector3(90, -45, 0);
        }
    }
    public IEnumerator StartBall(bool startPlayer1 = true)
    {
        InitialPosition(startPlayer1);
        this.hitCount = 0;
        yield return new WaitForSeconds(2);
        if (startPlayer1)
        {
            this.MoveBall(new Vector2(-1,0));
        }
        else
        {
            this.MoveBall(new Vector2(1, 0));
        }
    }
    public void MoveBall(Vector2 dir)
    {
        dir = dir.normalized;
        float speed = this.movementSpeed + this.speedPerHit * this.hitCount;
        Rigidbody2D rb = this.gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = dir * speed;
    }

    public void IncreasedHitCount()
    {
        if (this.hitCount * this.speedPerHit <= this.maxSpeed)
        {
            this.hitCount++;
        }
    }

}
