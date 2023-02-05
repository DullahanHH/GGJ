using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    // Start is called before the first frame update
    void Update()
    {
        if (Dialog_logic.isFinalDialogFinished) {
            LoadNextLevel();
        }
    }


    // Update is called once per frame
public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

IEnumerator LoadLevel(int levelIndex) {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        FindObjectOfType<BGMManager>().ReplaceSound("final");
        SceneManager.LoadScene("Credits");
    }
}

