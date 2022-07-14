using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUi : MonoBehaviour
{
    private MainManager mainManager;

    public Text bestScoreText;
    public Button start;
    public Button quit;
    public static string input;
    
    void Start()
    {
        DataManager.Instance.LoadScore();
        bestScoreText.text = $"Best Score: {DataManager.Instance.endScore} {DataManager.Instance.name}";
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
    static void ReadStringIput(string s)
    {
        input = s;
        Debug.Log(s);
    }
}
