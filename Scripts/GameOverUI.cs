using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class GameOverUI : MonoBehaviour
{

    //koniec gry
   public void Quit()
    {
        Debug.Log("Application Quit!");
        Application.Quit();
    }


    //wznowienie obecnej sceny i zresetowanie życia
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Score.points = 0;
        SpriteChanger.hp = 3;
        SpriteChanger2.hp2 = 3;
    }

    public void MenuStart()
    {
        SceneManager.LoadScene(0);
        Score.points = 0;
        SpriteChanger.hp = 3;
        SpriteChanger2.hp2 = 3;
    }


}
