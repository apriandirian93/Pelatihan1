using UnityEngine;

public class DinoLoncat : MonoBehaviour
{
    public bool diDarat = true;
    public float  forceMultiplier = 8.0f;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Lompat()
    {
        if (diDarat)
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.AddForce(transform.up * forceMultiplier, ForceMode2D.Impulse);
        }
        else
        {
            Debug.Log("Sedang Melompat, Harap Tunggu");
        }        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Daratan"))
        {
            diDarat = true;
            Debug.Log("Di Daratan");
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Daratan"))
        {
            diDarat = false;
            Debug.Log("Tidak di Daratan");
        }
    }
}
