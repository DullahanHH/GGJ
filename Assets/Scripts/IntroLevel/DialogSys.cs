using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class DialogSys : MonoBehaviour
{
    [Header("UI components")]
    public TextMeshProUGUI textLabel;
    public Image faceImage;
    [Header("Text components")]
    public TextAsset textFile;
    public int index;
    [Header("Head Image")]
    public Sprite face01, face02;
    bool textFinished;
    bool cancelTyping;
    private float TextSpeed = 0.05f;
    List<string> textList = new List<string>();
    // Start is called before the first frame update

    public static bool isDialogFinished;

    public float walkSpeed = 4f;
    public GameObject Button;
    void Awake()
    {
        GetTextFromFile(textFile);
    }

    private void OnEnable(){
        textFinished = true;
        StartCoroutine(SetTextUI());
    }

    // Update is called once per frame
    void Update()
    {
        if((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && index == textList.Count){
            gameObject.SetActive(false);
            Button.SetActive(false);
            index = 0;
            isDialogFinished = true;             
            return;
        }
        if((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))){
            if(textFinished && !cancelTyping){
                StartCoroutine(SetTextUI());
                }
            else if(!textFinished){
                cancelTyping = !cancelTyping;
            }
        }
    }

    void GetTextFromFile(TextAsset file){
        textList.Clear();
        index = 0;
        var lineData = file.text.Split(new[] {Environment.NewLine}, StringSplitOptions.None);

        foreach(var line in lineData){
            textList.Add(line);
        }
    }

    IEnumerator SetTextUI(){
        textFinished = false;
        textLabel.text = "";

        switch(textList[index]){
            case "Player":
                faceImage.sprite =  face01;
                faceImage.transform.position = new Vector3(-5,-3,0);
                index++;
                break;
            case "Square":
                faceImage.sprite =  face02;
                faceImage.transform.position = new Vector3(5,-3,0);
                index++;
                break;
        }

        int i = 0;
        while(!cancelTyping && i< textList[index].Length-1){
            textLabel.text += textList[index][i];
            i++;
            yield return new WaitForSeconds(TextSpeed);
        }

        textLabel.text = textList[index];
        cancelTyping = false;

        textFinished = true;
        index++;
    }

    IEnumerator MoveTo(Transform mover, Vector3 destination, float speed) {
    // This looks unsafe, but Unity uses
    // en epsilon when comparing vectors.
    while(mover.position != destination) {
         mover.position = Vector3.MoveTowards(
             mover.position,
             destination,
             speed * Time.deltaTime);
         // Wait a frame and move again.
         yield return null;
    }
}

}

