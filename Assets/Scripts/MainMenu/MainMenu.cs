using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    AudioSource menuBGM;

    public void PlayGame(){
        SceneManager.LoadScene("chapter-choice");
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void BackToMainMenu(){
        FindObjectOfType<BGMManager>().ReplaceSound("main");
        SceneManager.LoadScene("MainMenuScenes");
    }

    public void Chatper1_0(){
        FindObjectOfType<BGMManager>().ReplaceSound("level");
        SceneManager.LoadScene("Intro");
    }

    public void Chatper1_1(){
        FindObjectOfType<BGMManager>().ReplaceSound("level");
        SceneManager.LoadScene("1-1");
    }

    public void Chatper1_2(){
        FindObjectOfType<BGMManager>().ReplaceSound("level");
        SceneManager.LoadScene("1-2");
    }

    public void Chatper1_3(){
        FindObjectOfType<BGMManager>().ReplaceSound("level");
        SceneManager.LoadScene("1-3");
    }

    public void Chatper1_4(){
        FindObjectOfType<BGMManager>().ReplaceSound("level");
        SceneManager.LoadScene("1-4");
    }

    public void Chatper2_1(){
        FindObjectOfType<BGMManager>().ReplaceSound("level");
        SceneManager.LoadScene("2-1");
    }

    public void Chatper2_2(){
        FindObjectOfType<BGMManager>().ReplaceSound("level");
        SceneManager.LoadScene("2-2");
    }
    public void Chatper3_1(){
        FindObjectOfType<BGMManager>().ReplaceSound("level");
        SceneManager.LoadScene("3-1");
    }
    public void Chatper3_2(){
        FindObjectOfType<BGMManager>().ReplaceSound("boss");
        SceneManager.LoadScene("3-2");
    }
  public void reloadScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}
