using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class byteNPCLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public int byteValue = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "byteMan":
                Destroy(gameObject);
                collision.SendMessage("hugByteNPC", byteValue);
                break;
            case "rootKing":
                break;
            case "squareKing":
                break;
        }
    }
}
