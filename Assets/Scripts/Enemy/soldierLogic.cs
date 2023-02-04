using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soldierLogic : MonoBehaviour
{

    public int damage;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "byteMan":
                Destroy(gameObject);
                collision.SendMessage("makeDamage",damage);
                break;
        }
    }
}
