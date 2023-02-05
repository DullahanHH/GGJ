using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class player : MonoBehaviour
{
    public int health = 1;
    public TextMeshProUGUI healthText;
    public Image healthImage;
    public bool isStoneExisted = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkHealthValue();
        Die();
    }
    private void checkHealthValue(){
        healthText.text = "Current Bytes: " + health + "/99";
    }

    private void hugByteNPC(int byteValue)
    {
        health += byteValue;
        print(health);
    }

    private void pickSquareStone()
    {
        isStoneExisted = true;
        playerStatement("pickSquareStone");
    }

    private void consumeSquareStone()
    {
        isStoneExisted = false;
        playerStatement("consumeSquareStone");
    }

    private void throughRootGate()
    {
        health = (int)Math.Sqrt(health);
        print(health);
    }
    
    private void Die()
    {
        if(health <= 0)
        {
            playerStatement("die");
            //reload the current scene
        }
        else if(health > 99)
        {
            playerStatement("overflow");
            //reload the current scene
        }
    }

    private void makeDamage(int damage)
    {
        health -= damage;
    }

    private void playerStatement(string statementVal)
    {
        switch (statementVal)
        {
            case "smallDoorBlock":
                Debug.Log("blockblock");
                //show up a script under the main char saying 'The door is still locked....'
                //using dialog background pic?
                break;
            case "largeDoorBlock":
                Debug.Log("largeBlock!");
                //show up a script under the main char saying 'The door is still locked....'
                //using dialog background pic?
                break;
            case "die":
                Debug.Log("DIE!");
                break;
            case "overflow":
                Debug.Log("DIE!");
                break;
            case "collection":
                Debug.Log("collection!");
                break;
            case "consumeSquareStone":
                healthImage.color = new Color32(255,255,255,100);
                break;
            case "pickSquareStone":
                healthImage.color = new Color32(255,255,255,255);
                break;  
        }
    }

    
}
