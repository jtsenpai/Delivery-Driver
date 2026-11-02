using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("He is a wreckless driver");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enter the start gate");
    }
}
