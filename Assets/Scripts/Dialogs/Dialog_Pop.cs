using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Dialog_Pop : MonoBehaviour
{
    [Header("UI components")]
    public TextMeshProUGUI textLabel;
    [Header("Text components")]
    public TextAsset textFile;
    public int index;
    [Header("Head Image")]
    bool textFinished;
    bool cancelTyping;
    private float TextSpeed = 0.05f;
    List<string> textList = new List<string>();
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

