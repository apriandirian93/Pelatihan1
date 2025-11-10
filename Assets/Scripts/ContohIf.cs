using UnityEngine;

public class ContohIf : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    int age = 17;
    int money = 50000;
    void Start()
    {
        if ((age >= 18) || (money > 100000))
        {
            Debug.Log("Allowed");
        }
        else
        {
            Debug.Log("Not Allowed");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
