using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class largeDoorLogic : MonoBehaviour
{
    public int largeDoorPW;

    public GameObject largeDoor;
    void Start()
    {
        largeDoor = GameObject.Find("large_door");
    }

    // Update is called once per frame
    void Update()
    {
        distanceDetermine();
    }
    private void distanceDetermine()
    {
        float sqrDistance = (FindObjectOfType<player>().transform.position - largeDoor.transform.position).sqrMagnitude;
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
        if (FindObjectOfType<player>().health == largeDoorPW)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            FindObjectOfType<player>().SendMessage("playerStatement", "largeDoorBlock");
        }
    }
}
