using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rootGateLogic : MonoBehaviour
{
    public int gateHealth = 3;
    public SpriteRenderer sr;

    public Sprite broken_1;
    public Sprite broken_2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void gateDoorUpdate()
    {
        if(gateHealth == 2)
        {
            // door pic with 2 health
            sr.sprite = broken_1;
        }
        if(gateHealth == 1)
        {
            // door pic with 1 health
            sr.sprite = broken_2;
        }
        if (gateHealth == 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "byteMan":
                if (gateHealth != 0)
                {
                    collision.SendMessage("throughRootGate");
                    gateHealth--;
                }
                gateDoorUpdate();
                break;
        }
    }
}
