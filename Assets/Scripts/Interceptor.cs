using UnityEngine;

public class Interceptor : MonoBehaviour
{
    public float health = 100f;
    public float damagePerHit = 50f; // You might not need this if it's instant death

    // Tag to identify the player GameObject
    [Tooltip("Tag of the player GameObject")]
    public string playerTag = "Player"; // Make sure your player has this tag

    void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding GameObject has the specified player tag
        if (collision.gameObject.CompareTag(playerTag))
        {
            // Access the HealthManager instance and apply instant death
            if (HealthManager.Instance != null)
            {
                HealthManager.Instance.ApplyInstantDeath();
                Debug.Log("Player collided with interceptor! Applied instant death.");
            }
            else
            {
                Debug.LogError("HealthManager Instance is null. Make sure it exists in the scene.");
            }

            // Optionally destroy the interceptor upon collision with the player
            Destroy(gameObject);
        }
        else
        {
            // Handle collisions with other objects if needed
            health -= damagePerHit;
            if (health <= 0f)
            {
                Destroy(gameObject);
            }
            Debug.Log($"Interceptor collided with {collision.gameObject.name}. Health: {health}");
        }
    }
}