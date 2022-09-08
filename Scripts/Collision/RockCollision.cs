using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockCollision : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Change" || collision.gameObject.tag == "Center" || collision.gameObject.tag == "Power" || collision.gameObject.tag == "Change")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), gameObject.GetComponent<Collider2D>());
            return;
        }
        if (collision.gameObject.tag == "Laser" || collision.gameObject.tag == "Rock")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Boss")
        {
            if (collision.gameObject.tag == "Player")
            {
                LogicGame.instance.TakeDame(50);
            }
            Destroy(gameObject);
        }
        
    }
    
}
