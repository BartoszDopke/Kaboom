using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Move : MonoBehaviour
{
    //zmienne
   // private float speed = 200f;
    private Rigidbody2D rb;
    private Vector3 mousePosition;
    private Vector2 direction;
    //public GameObject player2;
    //public Transform start;
    //public Transform end;
    //private float length;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        //length = Vector3.Distance(start.position, end.position); //dorobić
    }

    //dopracować płynny ruch po pojedynczym kliknięciu
    //ruch Playerem2 za pomocą myszki, postać pobiera współrzędne na bieżąco z myszki
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            //transform.position = Vector3.Lerp(transform.position, mousePosition, speed / 20);           
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mousePosition.x, -6f, 0);           
        }
        
    }
}
