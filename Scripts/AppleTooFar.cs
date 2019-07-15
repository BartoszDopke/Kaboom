using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTooFar : MonoBehaviour
{
    //public bool isOutofBound = false;
    void Update()
    {
        //wywołanie metod ze Sprite Changerów, gdy bomba spadnie poza kamerę
        if (transform.position.y < -6.2f)
        {
            if (GameManager.bombOutOfBounds != null)
                GameManager.bombOutOfBounds.Invoke();
            Destroy(gameObject);
        }
    }
}
