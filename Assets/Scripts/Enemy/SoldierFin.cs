using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SoldierFin : MonoBehaviour
{
    public float moveSpeed = 1;
    public int damage = 1;
    public TextMeshPro displayText;

    // Start is called before the first frame update
    void Start()
    {
        displayText.text = damage.ToString();
        Invoke("movingDown", 0);
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 15);
    }

    private void movingDown()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.down * moveSpeed;
    }
}
