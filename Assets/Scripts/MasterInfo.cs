using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MasterInfo : MonoBehaviour
{

    public int coinCount ;
    [SerializeField] TMP_Text coinDisplay;
    public void IncrementScore()
    {
        coinCount++;
        coinDisplay.text = "Coins: " + coinCount;
    }
     

    // Update is called once per frame
    void Update()
    {
    
    }
}
