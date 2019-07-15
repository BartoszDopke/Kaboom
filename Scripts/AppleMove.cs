using UnityEngine;

public class AppleMove : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
