using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Laser" || collision.gameObject.tag == "Rock" || collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Rocket" || collision.gameObject.tag == "Control" || collision.gameObject.tag == "LaserRock") 
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), gameObject.GetComponent<Collider2D>());
            return;
        }
    }
}
