using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameplayUiScript : MonoBehaviour {

    //private static readonly int SCORE_FACTOR = 10;

    [SerializeField] private TextMeshProUGUI txtScore;
    [SerializeField] private TextMeshProUGUI txtHighestScore;

    
    void Start() {
        txtScore.text = GetScoreString();
        txtHighestScore.text = GetHighestScoreString();
    }

    
    void Update() {
        txtScore.text = GetScoreString();
        txtHighestScore.text = GetHighestScoreString();
    }

    private string GetScoreString() {
        //return (GameManager.Instance.GetScore() * SCORE_FACTOR).ToString();
        return (DisplayTime(GameManager.Instance.GetScore()));
    }

    private string GetHighestScoreString() {
        //return (GameManager.Instance.GetHighestScore() * SCORE_FACTOR).ToString();
        return (DisplayTime(GameManager.Instance.GetHighestScore()));
    }

    private string DisplayTime(float timeToDisplay) {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        return(string.Format("{0:00}:{1:00}", minutes, seconds));
    }

}
