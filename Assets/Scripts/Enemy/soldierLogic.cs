using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class soldierLogic : MonoBehaviour
{
    public int damage;
    public Vector3 startPos;
    public Vector3 endPos;
    public float speed = 4f;
    public TextMeshPro displayText;

    private bool OnMove;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        displayText.text = damage.ToString();

        soldierMove();
    }

    private void soldierMove()
    {
        if (!OnMove)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, endPos, speed * Time.deltaTime);
        }
        else
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, startPos, speed * Time.deltaTime);
        }
        if (this.transform.position.x == endPos.x && this.transform.position.y == endPos.y && !OnMove)
        {
            OnMove = true;
        }
        else if (this.transform.position.x == startPos.x && this.transform.position.y == startPos.y && OnMove)
        {
            OnMove = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "byteMan":
                Destroy(gameObject);
                collision.SendMessage("makeDamage",damage);
                break;
        }
    }
}
