
using UnityEngine;

public class MovingCube : MonoBehaviour
{
    public float moveSpeed = 1f;

    void FixedUpdate()
    {
        // Move the cube towards the player
        transform.position += Vector3.back * moveSpeed * Time.fixedDeltaTime;
    }

    void Update()
    {
        // Check if the cube has passed the player
        if (transform.position.z < -2f)
        {
            // Find the ScoreManager
            ScoreManager scoreManager = FindAnyObjectByType<ScoreManager>();

            // Reset the combo when a cube is missed
            if (scoreManager != null)
            {
                scoreManager.ResetCombo();
                Debug.Log("MISSED CUBE - COMBO RESET");
            }

            // Remove the missed cube
            Destroy(gameObject);
        }
    }
}
