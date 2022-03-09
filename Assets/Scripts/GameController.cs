using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    public static GameController instance;
    int score = 0;
    int sceneIndex = 1;
    string sceneName;

    private void Awake()
    {
        instance = this;
    }

    public void changeLevel()
    {
        sceneIndex++;

        if (sceneIndex < 4)
        {
            SceneManager.LoadScene(sceneIndex);
        }
    }

    void SaveCurrentScene()
    {
        sceneName = SceneManager.GetActiveScene().name;
    }

    void LoadGame()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void updateScore(int t_score)
    {
        score += t_score;
        HighScoreScript.instance.currentScore = score;
    }
}