using UnityEngine;

public class ContohLoop : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //int nyawa = 10;
        // while (nyawa > 0)
        // {
        //     nyawa = nyawa - 1;
        //     Debug.Log(nyawa);
        // }
        for(int nyawa = 10; nyawa > 0; nyawa--)
        {
            Debug.Log("Sisa nyawa: " + nyawa);
        }
        Debug.Log("Game Over");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
