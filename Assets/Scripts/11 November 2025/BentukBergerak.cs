using UnityEngine;

public class BentukBergerak : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(1 * Time.deltaTime, 1 * Time.deltaTime, 0);
    }
}
