using System.Collections;
using UnityEngine;

public class SquareSpawner : MonoBehaviour
{
    public GameObject SpawnObject;
    public bool sedangSpawn = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(MunculkanObject());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MunculkanObject()
    {
        while(sedangSpawn == true)
        {
            Instantiate(SpawnObject, new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), 0), Quaternion.identity);
            yield return new WaitForSeconds(2);
        }
    }
}
