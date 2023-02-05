using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class bossFightLogic : MonoBehaviour
{
    float[] arr = { -7.53f, -6.53f, -5.53f, -4.53f, -3.53f, -2.53f, -1.53f, -0.53f, 0.53f, 1.53f, 2.53f, 3.53f, 4.53f, 5.53f, 6.53f, 7.53f };
    float CreatTime = 5f;
    GameObject soldiers;
    GameObject soldiers1;
    GameObject soldiers2;
    GameObject soldiers3;
    GameObject soldiers4;
    GameObject soldiers5;
    GameObject soldiers6;
    GameObject soldiers7;
    GameObject soldiers8;
    GameObject soldiers9;
    GameObject soldiers10;
    GameObject soldiers11;
    GameObject soldiers12;
    GameObject soldiers13;
    GameObject soldiers14;
    GameObject soldiers15;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CreatTime -= Time.deltaTime;
        if (CreatTime <= 0)
        {
            CreatTime = Random.Range(1, 5);
            Vector3 noSoldier = new Vector3(GetRandom(), 67f, 0);
            GameObject obj = (GameObject)Resources.Load("Prefabs/enemy_soldier");
            GameObject obj1 = (GameObject)Resources.Load("Prefabs/enemy_soldier");
            GameObject obj2 = (GameObject)Resources.Load("Prefabs/enemy_soldier");
            GameObject obj3 = (GameObject)Resources.Load("Prefabs/enemy_soldier");
            GameObject obj4 = (GameObject)Resources.Load("Prefabs/enemy_soldier");
            GameObject obj5 = (GameObject)Resources.Load("Prefabs/enemy_soldier");
            GameObject obj6 = (GameObject)Resources.Load("Prefabs/enemy_soldier");
            GameObject obj7 = (GameObject)Resources.Load("Prefabs/enemy_soldier");
            GameObject obj8 = (GameObject)Resources.Load("Prefabs/enemy_soldier");
            GameObject obj9 = (GameObject)Resources.Load("Prefabs/enemy_soldier");
            GameObject obj10 = (GameObject)Resources.Load("Prefabs/enemy_soldier");
            GameObject obj11 = (GameObject)Resources.Load("Prefabs/enemy_soldier");
            GameObject obj12 = (GameObject)Resources.Load("Prefabs/enemy_soldier");
            GameObject obj13 = (GameObject)Resources.Load("Prefabs/enemy_soldier");
            GameObject obj14 = (GameObject)Resources.Load("Prefabs/enemy_soldier");
            GameObject obj15 = (GameObject)Resources.Load("Prefabs/enemy_soldier");

            soldiers = Instantiate<GameObject>(obj);
            soldiers1 = Instantiate<GameObject>(obj1);
            soldiers2 = Instantiate<GameObject>(obj2);
            soldiers3 = Instantiate<GameObject>(obj3);
            soldiers4 = Instantiate<GameObject>(obj4);
            soldiers5 = Instantiate<GameObject>(obj5);
            soldiers6 = Instantiate<GameObject>(obj6);
            soldiers7 = Instantiate<GameObject>(obj7);
            soldiers8 = Instantiate<GameObject>(obj8);
            soldiers9 = Instantiate<GameObject>(obj9);
            soldiers10 = Instantiate<GameObject>(obj10);
            soldiers11 = Instantiate<GameObject>(obj11);
            soldiers12 = Instantiate<GameObject>(obj12);
            soldiers13 = Instantiate<GameObject>(obj13);
            soldiers14 = Instantiate<GameObject>(obj14);
            soldiers15 = Instantiate<GameObject>(obj15);

            soldiers.transform.position = new Vector3(arr[0], 67f, 0);
            soldiers1.transform.position = new Vector3(arr[1], 67f, 0);
            soldiers2.transform.position = new Vector3(arr[2], 67f, 0);
            soldiers3.transform.position = new Vector3(arr[3], 67f, 0);
            soldiers4.transform.position = new Vector3(arr[4], 67f, 0);
            soldiers5.transform.position = new Vector3(arr[5], 67f, 0);
            soldiers6.transform.position = new Vector3(arr[6], 67f, 0);
            soldiers7.transform.position = new Vector3(arr[7], 67f, 0);
            soldiers8.transform.position = new Vector3(arr[8], 67f, 0);
            soldiers9.transform.position = new Vector3(arr[9], 67f, 0);
            soldiers10.transform.position = new Vector3(arr[10], 67f, 0);
            soldiers11.transform.position = new Vector3(arr[11], 67f, 0);
            soldiers12.transform.position = new Vector3(arr[12], 67f, 0);
            soldiers13.transform.position = new Vector3(arr[13], 67f, 0);
            soldiers14.transform.position = new Vector3(arr[14], 67f, 0);
            soldiers15.transform.position = new Vector3(arr[15], 67f, 0);

            List<GameObject> soldiersList = new List<GameObject>
            {
                soldiers,
                soldiers1,
                soldiers2,
                soldiers3,
                soldiers4,
                soldiers5,
                soldiers6,
                soldiers7,
                soldiers8,
                soldiers9,
                soldiers10,
                soldiers11,
                soldiers12,
                soldiers13,
                soldiers14,
                soldiers15
            };

            foreach (GameObject soldier in soldiersList)
            {
                if (soldier.transform.position == noSoldier)
                {
                    Destroy(soldier);
                }
                else
                {
                    soldier.GetComponent<soldierLogic>().charge();
                }
            }
        }
    }

    public float GetRandom()
    {
        int ran = Random.Range(0,16);
        return arr[ran];
    }
}
