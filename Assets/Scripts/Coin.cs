using UnityEngine;
using System.Collections.Generic;

public class Coin : MonoBehaviour
{
    public static Pooler coinPool;
    public bool isPremium;

    void OnTriggerEnter(Collider other)
    {
        MasterInfo masterInfo = FindObjectOfType<MasterInfo>();
        if (masterInfo != null)
        {
            masterInfo.IncrementScore();
        }
        this.gameObject.SetActive(false);
    }
}
