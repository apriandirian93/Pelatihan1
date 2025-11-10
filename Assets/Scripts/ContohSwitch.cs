using UnityEngine;

public class ContohSwitch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    int GameID = 2;
    void Start()
    {
        switch(GameID)
        {
        case 1:
            Debug.Log("Basic Sword");
            break;
        case 2:
            Debug.Log("Electric Bow");
            break;
        default:
            Debug.Log("Fire Spell");
            break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
