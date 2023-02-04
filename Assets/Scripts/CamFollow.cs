using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform target;
    [Range(0, 1)]
    public float smooth = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        if (target != null)
        {
            if (target.position != transform.position)
            {
                Vector3 targetPos = new Vector3(target.position.x, target.position.y + 1, 0);
                transform.position = Vector3.Lerp(transform.position, targetPos, smooth);
            }
            
        }
    }
}
