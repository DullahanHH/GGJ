using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public int health = 1;
    public int stoneCounter = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void hugByteNPC(int byteValue)
    {
        health += byteValue;
        print(health);
    }

    private void pickSquareStone()
    {
        stoneCounter++;
        print(stoneCounter);
    }

    private void throughRootGate()
    {
        health = (int)Math.Sqrt(health);
        print(health);
    }
}
