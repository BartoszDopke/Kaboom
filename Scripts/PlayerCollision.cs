using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    //public GameObject apple;
    private bool isCollide = false;
    private bool isCollide2 = false;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Player")
        {
            Score.points += 100;
            if (!isCollide)
            {
                if (GameManager.collideWithBomb != null)
                    GameManager.collideWithBomb.Invoke();
                isCollide = true;
            }
            Destroy(gameObject);
        }
        if (coll.gameObject.name == "Player2")
        {
            Score.points += 100;
            if (!isCollide2)
            {
                if (GameManager.collideWithBomb2 != null)
                    GameManager.collideWithBomb2.Invoke();
                isCollide2 = true;
            }
            Destroy(gameObject);
        }
    }
}

