using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaserCollision : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // ignore the laser collide with the change laser
        if (gameObject.tag == "Laser")
        {
            if (collision.gameObject.tag == "Change" || collision.gameObject.tag == "Rocket" || collision.gameObject.tag == "Center")
            {
                Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), gameObject.GetComponent<Collider2D>());
                return;
            }
           
            if (collision.gameObject.tag != "Wall" && collision.gameObject.tag != "Player" && collision.gameObject.tag != "Rock" && collision.gameObject.tag != "SubEnemy" && collision.gameObject.tag != "Power")
            {
                if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Boss")
                {
                    Score.score += 10;
                    LogicGame.instance.TakeMana(10);
                }
                if (collision.gameObject.tag == "Enemy")
                {
                    Destroy(collision.gameObject);
                    Destroy(gameObject);
                }
                else if (collision.gameObject.tag == "Boss")
                {
                    BossHealth.instance.health -= 1;
                    Destroy(gameObject);
                }
                if (collision.gameObject.tag == "Laser")
                {
                    Destroy(gameObject);
                    Destroy(collision.gameObject);
                }
                
            }
        }
        

        // setting collision of the laser to other object except wall / player
        

        // destroy the object which collides the wall
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }

}
