using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soldierGen : MonoBehaviour
{
    public Vector2[] genPoints;
    public GameObject soldier;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Gen", 3f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Gen()
    {
        int walkablePos = Random.Range(0, genPoints.Length);

        for (int i=0;i<genPoints.Length;i++)
        {
            if (i != walkablePos)
            {
                GameObject enemyCopy = Instantiate(soldier, genPoints[i], soldier.transform.rotation);
            }
        }
    }
}
