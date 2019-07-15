using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BomberMove : MonoBehaviour
{
    private float speed = 0.7f;
    public Rigidbody2D rb;
    public GameObject apple;
    public GameObject bomber;
    Vector3 NextPoint;
    public float nMin = -6.5f;
    public float nMax = 6.5f;
    public float yStart = 3.37f;

    //tworzy nowy losowy punkt, do którego dochodzi Bomber
    Vector3 GenerateNextPoint(float min, float max)
    {
        return (new Vector3(Random.Range(min, max), 3.37f, yStart));
    }

    //spawnuje bomby
    void Spawn()
    {
        GameObject newapple = (GameObject)Instantiate(apple) as GameObject;
        if (newapple != null)
        {
            float x = bomber.transform.position.x;
            float y = bomber.transform.position.y - 1.5f;
            newapple.transform.position = new Vector2(x, y);
        }
    }
    public void SpawnDelayOnePlayer()
    {
        InvokeRepeating("Spawn", 0.5f, 0.4f);
    }
    public void SpawnDelayTwoPlayers()
    {
        InvokeRepeating("Spawn", 0.5f, 0.3f);
    }


    //wywołuje spawn co określony czas
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "OnePlayer")
        {
            SpawnDelayOnePlayer();
        }
        else if(sceneName == "TwoPlayers")
        {
            SpawnDelayTwoPlayers();
        }
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        NextPoint = GenerateNextPoint(nMin, nMax);
    }


        void LateUpdate()
        {

            if (Vector3.Distance(transform.position, NextPoint) > 0.5f) //vector3.distance zwraca mi dystans między a i b
            {
                transform.position = Vector3.Lerp(transform.position, NextPoint, speed / 20); //dzięki speed/int zmieniam prędkość zmian pozycji Bombera
            }
            else
            {
                NextPoint = GenerateNextPoint(nMin, nMax);
            }

        }

}

