using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.tag == "SubEnemy")
        {
            if (collision.gameObject.tag == "Change" || collision.gameObject.tag == "Boss" || collision.gameObject.tag == "SubEnemy" || collision.gameObject.tag == "Center")
            {
                Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>() , collision.gameObject.GetComponent<Collider2D>());
                return;
            }

            if (collision.gameObject.tag == "Player")
            {
                LogicGame.instance.TakeDame(5);
                Destroy(gameObject);

            }

            
            
        }
        if (gameObject.tag == "Boss")
        {
            if (collision.gameObject.tag == "Change" || collision.gameObject.tag == "Boss" || collision.gameObject.tag == "SubEnemy" || collision.gameObject.tag == "Center")
            {
                Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), collision.gameObject.GetComponent<Collider2D>());
                return;
            }
        }
    }
}
