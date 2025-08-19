using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] GameObject thePlayer;
    // Update is called once per frame
    void OnTriggerEnter(Collider other) {
        // Disable movement script
        var move = thePlayer.GetComponent<Movement>();
        if (move != null)
            move.enabled = false;
        // Stop Rigidbody movement
        Rigidbody rb = thePlayer.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero; // For newer Unity
            rb.isKinematic = true;
        }
    }
}
