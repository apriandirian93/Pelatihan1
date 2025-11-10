using UnityEngine;

public class Contoh : MonoBehaviour
{
    int number1 = 10;
    int number2 = 7;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number3 = number1;
        number1 = number2;
        number2 = number3;
        Debug.Log(number1);
        Debug.Log(number2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
