using UnityEngine;

public class Grasscript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float minForce;
    public float maxForce; 
    public float upwardForceFactor;
    public float deadzone = -30;
    void Start()
    {
        if (rb != null)
        {
            // Generate a random force magnitude between the new minForce and maxForce
            float randomForce = Random.Range(minForce, maxForce);

            // Create a direction vector that combines left and a random upward force
            Vector2 forceDirection = new Vector2(-1f, Random.Range(0f, upwardForceFactor));

            // Debug log to track the force being applied
            Debug.Log("Applying force: " + (forceDirection * randomForce).ToString());

            // Apply the combined force to the Rigidbody2D with the random magnitude
            rb.AddForce(forceDirection * randomForce, ForceMode2D.Impulse);
        }
        else
        {
            Debug.LogError("Rigidbody2D is not assigned.");
        }
    }

    void Update()
    {
        if (transform.position.y < deadzone)
        {
            Debug.Log("skibidi grass deleted");
            Destroy(gameObject);
        }
    }
}
