using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class airwallLogic : MonoBehaviour
{
    public GameObject wallPrefab;
    public Vector3 newWallPos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "byteMan":
                Destroy(gameObject);
                Instantiate(wallPrefab, newWallPos, Quaternion.identity);
                break;
        }
    }
}
