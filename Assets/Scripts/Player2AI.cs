using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2AI : MonoBehaviour
{
    public GameObject ball;
    public float moveSpeed;

    private void FixedUpdate()
    {
        if (Mathf.Abs(transform.position.y - ball.transform.position.y) > 50)
        {
            if (transform.position.y < ball.transform.position.y)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0,1) * moveSpeed;
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0,-1) * moveSpeed;
            }
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
        }
    }
}
