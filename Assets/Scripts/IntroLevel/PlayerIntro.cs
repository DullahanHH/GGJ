using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIntro : MonoBehaviour
{
    private float speed = 3f;
    public Transform startPosition;
    public Transform startPosition2;
    public GameObject Square;
    private Vector3 endPosition = new Vector3(2,0,0);
    private Vector3 endPosition2 = new Vector3(12,0,0);

    bool isFinished = false;

    // Update is called once per frame
    void Update()
    {
        if(transform.position == endPosition){
            isFinished = true;
        }
        if(!isFinished){
            transform.position = Vector3.MoveTowards(startPosition.position, endPosition, speed*Time.deltaTime);
        }
        if(DialogSys.isDialogFinished){
            transform.position = Vector3.MoveTowards(startPosition.position, endPosition2, speed*Time.deltaTime);
            Square.transform.position = Vector3.MoveTowards(startPosition2.position, endPosition2, speed*Time.deltaTime);
        }
        if(transform.position == endPosition2){
            MainMenu mainMenu = new MainMenu();
            mainMenu.Chatper1_1();
        }
    }
}