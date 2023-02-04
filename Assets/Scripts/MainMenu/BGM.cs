using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
 using UnityEngine.UI;

public class BGM : MonoBehaviour{
    private static BGM BGMInstance;
   
    void Awake()
     {
        
        if (BGMInstance != null && BGMinstance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            BGMInstance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    public static BGM BGMinstance{
        get{
            if(BGMInstance==null){
                BGMInstance = FindObjectOfType<BGM>();
                DontDestroyOnLoad(BGMInstance.gameObject);
            }
            return BGMInstance;
        }
    }
}