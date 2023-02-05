using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class byteNPCLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public int byteValue = 1;
    public TextMeshPro displayText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        displayText.text = byteValue.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "byteMan":
                Destroy(gameObject);
                collision.SendMessage("hugByteNPC", byteValue);
                break;
        }
    }
}
