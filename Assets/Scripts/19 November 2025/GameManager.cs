using UnityEngine;

public class GameManager : MonoBehaviour
{
    public DinoLoncat dinoLoncat;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            dinoLoncat.Lompat();
        }
    }
}
