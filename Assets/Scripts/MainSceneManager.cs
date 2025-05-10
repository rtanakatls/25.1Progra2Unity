using UnityEngine;
using GameJolt.UI;

public class MainSceneManager : MonoBehaviour
{
    void Start()
    {
        GameJoltUI.Instance.ShowSignIn();
    }
}
