using UnityEngine;

public class CoinTake : MonoBehaviour
{
   [SerializeField] int rotationSpeed = 2;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed , 0, Space.World);
    }
}
