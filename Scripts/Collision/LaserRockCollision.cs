using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserRockCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Center" || collision.gameObject.tag == "Change")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), gameObject.GetComponent<Collider2D>());
            return;
        } 
        if (collision.gameObject.tag == "Player")
        {
            //LogicGame.instance.TakeDame(10);
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Boss")
        {
            Destroy(gameObject);
        }
    }
}
