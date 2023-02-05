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
    public TextMeshPro displayText;

    private int oldHealth;

    public ParticleSystem increaseParticle;
    public ParticleSystem decreaseParticle;
    public GameObject alertDoor;
    public GameObject alertDie;
    void Start()
    {
        //healthText = TextMeshProUGUI.FindObjectOfType
        oldHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        displayText.text = health.ToString();

        checkHealthValue();
        Die();

        if (health > oldHealth)
        {
            oldHealth = health;
            increaseParticle.Play();
            FindObjectOfType<SoundManager>().PlaySound("bRise");
        }
        if (health < oldHealth)
        {
            oldHealth = health;
            decreaseParticle.Play();
            FindObjectOfType<SoundManager>().PlaySound("bDown");
        }
    }
    void checkHealthValue(){
        healthText = GameObject.Find("byteValue").GetComponent<TextMeshProUGUI>();
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

    public void consumeSquareStone()
    {
        if (isStoneExisted)
        {
            health = health * health;
            isStoneExisted = false;
            FindObjectOfType<SoundManager>().PlaySound("iUsed");
        }
        
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
                alertDoor.SetActive(true);
                //show up a script under the main char saying 'The door is still locked....'
                //using dialog background pic?
                break;
            case "largeDoorBlock":
                alertDoor.SetActive(true);
                //show up a script under the main char saying 'The door is still locked....'
                //using dialog background pic?
                break;
            case "die":
                alertDie.SetActive(true);
                break;
            case "overflow":
                alertDie.SetActive(true);
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
