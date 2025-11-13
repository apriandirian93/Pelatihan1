using UnityEngine;

public class SquareJump : MonoBehaviour
{
    public bool diLantai;
    public float forceMultiplier = 3.0f; //variabel untuk perhitungan daya lompat

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Lompat()
    {
        if (diLantai)
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
        if (collision.gameObject.CompareTag("Lantai"))
        {
            diLantai = true;
            Debug.Log("Di lantai");
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Lantai"))
        {
            diLantai = false;
            Debug.Log("Tidak di lantai");
        }
    }
}
