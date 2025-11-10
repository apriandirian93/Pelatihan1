using UnityEngine;

public class ContohLogicOperation : MonoBehaviour
{
    int number1 = 1287;
    int number2 = 14;
    int number3 = 589;
    int number4 = 63;
    int number5 = 55;
    int number6 = 5;
    int number7 = 21;
    int number8 = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bool hasil = ((number1 * number2 + number3)>(number4 + number5 * number6)) && !(number7 < number8);
        Debug.Log(hasil);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
