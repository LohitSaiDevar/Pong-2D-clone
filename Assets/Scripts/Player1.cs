using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float movementSpeed;
    private void FixedUpdate()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        float v = Input.GetAxisRaw("Vertical");
        Vector2 v2 = new Vector2(0, v);
        rb.velocity = v2 * movementSpeed;
    }
}
