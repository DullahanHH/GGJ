using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class largeDoorLogic : MonoBehaviour
{
    public int largeDoorPW;
    public float detectRadius = 1.25f;
    public string loadScenceName;

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
        float distance = (FindObjectOfType<player>().transform.position - this.transform.position).magnitude;
        
        if (distance <= detectRadius)
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
            SceneManager.LoadScene(loadScenceName);
        }
        else
        {
            FindObjectOfType<player>().SendMessage("playerStatement", "largeDoorBlock");
        }
    }
}
