using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainUIHandler : MonoBehaviour
{
    [SerializeField] private Text highScoreText;
    [SerializeField] private Text leaderboardText;



    private void Start() {
        highScoreText.text = string.Format("Best Score : {0} : {1}",GameManager.Instance.highScoreName , GameManager.Instance.HighScore);
        UpdateLeaderboard();
    }

    public void ReturnToMenu(){
        SceneManager.LoadScene(0);
    }

    public void UpdateLeaderboard(){
        leaderboardText.text = string.Format("Leaderboard :\n");
        for (int i = 0; i < GameManager.Instance.highScoreList.Count; i++)
        {
            leaderboardText.text += string.Format("{1} : {0}\n", GameManager.Instance.highScoreList[i], GameManager.Instance.highScoreNameList[i]);
        }
    }
        
}
