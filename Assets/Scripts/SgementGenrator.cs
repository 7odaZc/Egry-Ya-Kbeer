using System.Collections;
using UnityEngine;

public class SgementGenrator : MonoBehaviour
{
    public GameObject[] segmentMap;
    [SerializeField] float zpos ;
    [SerializeField] bool creatingSegment = false;
    [SerializeField] int segmentNum;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        if (creatingSegment == false)
        {
            creatingSegment = true;
            StartCoroutine(GenerateSegments());
        }
        
    }
    IEnumerator GenerateSegments()
    {
        segmentNum = Random.Range(0, segmentMap.Length);
        Instantiate(segmentMap[segmentNum], new Vector3(0, 0, zpos), Quaternion.identity);
        zpos += 17f;
        yield return new WaitForSeconds(2);
        creatingSegment = false;
    }

}
