using UnityEngine;

public class CircleMembesar : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localScale += new Vector3(1, 2, 1)* Time.deltaTime;
    }
}
