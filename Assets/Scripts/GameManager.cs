using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public List<string> highScoreNameList;
    public List<int> highScoreList;
    public string Name;
    public string highScoreName = "Name";
    public int HighScore;

    

    void Start()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void UpdateHighScore(string name, int score){
        if (highScoreList.Count == 0){
            highScoreList.Add(score);
            highScoreNameList.Add(name);

        }
        else{
            for (int i = 0; i < highScoreList.Count ; i++)
            {
                int hscore = highScoreList[i];
                if (score > hscore){
                    highScoreList.Insert(i, score);
                    highScoreNameList.Insert(i, name);
                    break;
                }
            }
        }
    }
}
