using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootKing : MonoBehaviour
{
    private Vector2 targetPos;
    private Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        targetPos = new Vector2(transform.position.x, FindObjectOfType<player>().transform.position.y + 2);
        transform.position = Vector2.Lerp(transform.position, targetPos, 0.01f);
    }

    public void WaveSword()
    {
        ani.SetTrigger("Wave");
    }
}
