using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallDoorLogic : MonoBehaviour
{
    public int smallDoorPW;

    public GameObject smallDoor;

    void Start()
    {
        smallDoor = GameObject.Find("small_door");
        
    }

    // Update is called once per frame
    void Update()
    {
        distanceDetermine();
    }

    private void distanceDetermine()
    {
        float sqrDistance = (FindObjectOfType<player>().transform.position - smallDoor.transform.position).sqrMagnitude;
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
        if (FindObjectOfType<player>().health == smallDoorPW)
        {
            Destroy(smallDoor);
        }
        else
        {
            FindObjectOfType<player>().SendMessage("playerStatement", "smallDoorBlock");
        }
    }
}


