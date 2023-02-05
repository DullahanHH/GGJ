using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierFin : MonoBehaviour
{
    public float moveSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("movingDown", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void movingDown()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.down * moveSpeed;
    }
}
