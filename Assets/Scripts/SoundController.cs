using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource wallSound;
    public AudioSource racketSound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player1Con" || collision.gameObject.name == "Player2Con")
        {
            racketSound.Play();
        }
        else
        {
            wallSound.Play();
        }
    }
}
