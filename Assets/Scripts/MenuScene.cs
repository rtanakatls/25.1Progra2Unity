using UnityEngine;
using GameJolt.API;
using UnityEngine.UI;
using GameJolt.UI;
using UnityEngine.SceneManagement;

public class MenuScene : MonoBehaviour
{
    [SerializeField] private Button trophiesButton;
    [SerializeField] private Button playButton;
    [SerializeField] private Button rankingButton;

    private void Awake()
    {
        trophiesButton.onClick.AddListener(() =>
        {
            GameJoltUI.Instance.ShowTrophies();
        });
        playButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("GameplayScene");
        });
        rankingButton.onClick.AddListener(() =>
        {
            GameJoltUI.Instance.ShowLeaderboards();
        });
    }

    private void Start()
    {
        Trophies.Unlock(267753);
    }
}
