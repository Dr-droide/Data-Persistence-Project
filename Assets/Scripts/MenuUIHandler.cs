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
    

    public void NewStart(){
        GameManager.Instance.Name = Name.text;
        SceneManager.LoadScene(1);
    }

    public void Exit(){
        GameManager.Instance.SavingData();
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit(); // original code to quit Unity player
        #endif
    }
}
