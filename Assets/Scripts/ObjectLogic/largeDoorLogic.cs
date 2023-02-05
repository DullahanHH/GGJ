using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class largeDoorLogic : MonoBehaviour
{
    public int largeDoorPW = 2;
    public float detectRadius = 1.25f;
    public string loadScenceName;
    public TextMeshPro displayText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        displayText.text = largeDoorPW.ToString();

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
