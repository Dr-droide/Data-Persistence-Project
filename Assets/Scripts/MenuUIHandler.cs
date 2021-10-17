using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif


public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] private TMP_InputField Name;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void NewStart(){
        GameManager gm = new GameManager();
        gm.Name = Name.text;
        SceneManager.LoadScene(1);
    }

    public void Exit(){
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit(); // original code to quit Unity player
        #endif
    }

    public void ReturnToMenu(){
        SceneManager.LoadScene(0);
    }
}
