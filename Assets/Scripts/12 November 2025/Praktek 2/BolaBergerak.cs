using Unity.VisualScripting;
using UnityEngine;

public class BolaBergerak : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bola"))
        {
            Debug.Log("Bola tabrakan dengan bola");
            gameObject.transform.Translate(1 * Time.deltaTime, 1 * Time.deltaTime, 0);
        }
        if (collision.gameObject.CompareTag("Dinding"))
        {
            Debug.Log("Bola tabrakan dengan dinding");
            gameObject.transform.Translate(1 * Time.deltaTime, 1 * Time.deltaTime, 0);
        }
    }
}
