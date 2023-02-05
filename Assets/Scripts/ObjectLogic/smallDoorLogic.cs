using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallDoorLogic : MonoBehaviour
{
    public int smallDoorPW;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distanceDetermine();
    }

    private void distanceDetermine()
    {
        float sqrDistance = (FindObjectOfType<player>().transform.position - transform.position).sqrMagnitude;
        if (sqrDistance < 1.25 * 1.25)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                validatePW();
            }
        }
    }

    private void validatePW()
    {
        if (FindObjectOfType<player>().health == this.smallDoorPW)
        {
            Destroy(this.gameObject);
        }
        else
        {
            FindObjectOfType<player>().SendMessage("playerStatement", "smallDoorBlock");
        }
    }
}


