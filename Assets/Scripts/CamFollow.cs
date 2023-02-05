using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CamFollow : MonoBehaviour
{
    public Transform target;
    [Range(0, 1)]
    public float smooth = 2;
    public float ChangeSpeed = 1.0f;

    private float maximum = 13;

    private float minmum = 5;



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") != 0)

        {

            //����size��С    

            Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, minmum, maximum);

            //���ָı�    

            Camera.main.orthographicSize = Camera.main.orthographicSize - Input.GetAxis("Mouse ScrollWheel") * ChangeSpeed;

        }
    }

    private void LateUpdate()
    {
        if (target != null)
        {
            if (target.position != transform.position)
            {
                Vector3 targetPos = new Vector3(target.position.x, target.position.y, 0);
                transform.position = Vector3.Lerp(transform.position, targetPos, smooth);
            }
            
        }
       
    }
}
