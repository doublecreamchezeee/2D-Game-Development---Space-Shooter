using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.8f);
        KillMap();
        KillItself();
    }

    void KillItself()
    {
        Destroy(gameObject);
    }

    void KillMap()
    {
        GameObject[] enemy = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject[] rock = GameObject.FindGameObjectsWithTag("Rock");
        GameObject[] laser = GameObject.FindGameObjectsWithTag("Laser");
        for (int i = 0; i < enemy.Length; i++)
        {
            Destroy(enemy[i]);
        }
        for (int i = 0; i < rock.Length; i++)
        {
            Destroy(rock[i]);
        }
        for (int i = 0; i < laser.Length; i++)
        {
            Destroy(laser[i]);
        }
    }
}
