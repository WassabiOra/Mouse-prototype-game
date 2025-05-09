using UnityEngine;

public class Balloon : MonoBehaviour
{
    public float speed = 2f; // Balloon floating speed
    public int scoreValue = 10; // Score gained per balloon pop

    private void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);

        // Destroy balloon if it reaches the top of the screen
        if (transform.position.y > 6f) 
        {
            GameManager.Instance.LoseLife(); // Reduce the lives
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        GameManager.Instance.AddScore(scoreValue); // Adds score on pop
        Destroy(gameObject); // Removes balloon
    }
}
