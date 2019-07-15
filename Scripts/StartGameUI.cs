using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class StartGameUI : MonoBehaviour
{
    //ładowanie sceny dla jednego gracza
    public void OnePlayerGameStart()
    {
        SceneManager.LoadScene(1);

    }
    //ładowanie sceny dla dwóch graczy
    public void TwoPlayerGameStart()
    {
        SceneManager.LoadScene(2);

    }
}
