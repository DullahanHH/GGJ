using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Dialog_logic : MonoBehaviour
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
    public Vector3 face1Position = new Vector3(6.72f,-0.05f,0);
    public Vector3 face2Position = new Vector3(200,-0.05f,0);
    // Start is called before the first frame update

    public static bool isDialogFinished;

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
        Debug.Log("??");
        switch(textList[index]){
            case "Player":
                faceImage.sprite =  face01;
                faceImage.transform.position = face1Position;
                index++;
                break;
            case "Square":
                faceImage.sprite =  face02;
                Debug.Log(face2Position);
                faceImage.transform.position = face2Position;
                Debug.Log(faceImage.transform.position);
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
}

