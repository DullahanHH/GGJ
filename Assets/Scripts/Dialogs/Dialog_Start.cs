using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog_Start : MonoBehaviour
{
    public GameObject talkUI;
    public CamFollow camera;
    // Start is called before the first frame update
    void Start()
    {
        talkUI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(Dialog_logic.isDialogFinished){
            camera.enabled = true;;
        }
    }
}
