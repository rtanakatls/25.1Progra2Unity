using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using GameJolt.API;

public class GameManager : MonoBehaviour
{
    private static GameManager instance; 

    public static GameManager Instance { get { return instance; } }

    public event Action<float> OnTimerUpdate;


    private float timer;
    private bool isTimerActive;
    private bool scoreSubmited;
    private void Awake()
    {
        isTimerActive = true;
        instance = this;
    }


    private void Update()
    {
        if (isTimerActive)
        {
            timer += Time.deltaTime;
            OnTimerUpdate?.Invoke(timer);
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Escape) && scoreSubmited)
            {
                SceneManager.LoadScene("MenuScene");
            }
        }
    }

    public void GameOver()
    {
        isTimerActive = false;
        Scores.Add(Mathf.CeilToInt(timer), $"{Mathf.CeilToInt(timer)} segundos", 1004593, "", (success) =>
        {
            scoreSubmited = true;
        });
    }

}
