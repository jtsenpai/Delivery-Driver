using UnityEngine;

public class Driver : MonoBehaviour
{
    // Variables
    private float steerSpeed = 0.1f;
    private float moveSpeed = 0.1f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, steerSpeed, 0);
        transform.Rotate(0, 0, 0.01f);
    }
}
