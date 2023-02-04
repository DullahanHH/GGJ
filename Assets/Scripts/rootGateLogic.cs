using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rootGateLogic : MonoBehaviour
{
    public int gateHealth = 3;
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
        }
        if(gateHealth == 1)
        {
            // door pic with 1 health
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
