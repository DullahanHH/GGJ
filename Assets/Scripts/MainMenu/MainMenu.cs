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
        SceneManager.LoadScene("MainMenuScenes");
    }

    public void Chatper1_0(){
        SceneManager.LoadScene("Intro");
    }

    public void Chatper1_1(){
        SceneManager.LoadScene("1-1");
    }

    public void Chatper1_2(){
        SceneManager.LoadScene("1-2");
    }

    public void Chatper1_3(){
        SceneManager.LoadScene("1-3");
    }

    public void Chatper1_4(){
        SceneManager.LoadScene("1-4");
    }

    public void Chatper2_1(){
        SceneManager.LoadScene("2-1");
    }

    public void Chatper2_2(){
        SceneManager.LoadScene("2-2");
    }
    public void Chatper3_1(){
        SceneManager.LoadScene("3-1");
    }
    public void Chatper3_2(){
        SceneManager.LoadScene("3-2");
    }
  public void reloadScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}
