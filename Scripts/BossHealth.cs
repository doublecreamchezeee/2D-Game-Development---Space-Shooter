using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public int health = 10;

    public static BossHealth instance { get; private set; }
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float change = (float)health/20;
        transform.localScale = new Vector3(change, 0.5f, 0);
        GameObject boss = GameObject.FindWithTag("Boss");
        if (health == 0)
        {
            Destroy(boss);
        }
    }
    
}
