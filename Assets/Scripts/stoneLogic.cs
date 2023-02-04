using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stoneLogic : MonoBehaviour
{
    // Start is called before the first frame update
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
                collision.SendMessage("pickSquareStone");
                break;
        }
    }

}
