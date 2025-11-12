using UnityEngine;

public class KotakBergerak : MonoBehaviour
{
    public ArahGerak arahgerak = ArahGerak.kanan;
    public float kecepatan = 5.0f;
    public InteraksiUI12Nov interaksiui12nov;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (arahgerak)
        {
            case ArahGerak.atas:
                gameObject.transform.Translate(0, kecepatan * Time.deltaTime, 0);
                break;
            case ArahGerak.bawah:
                gameObject.transform.Translate(0, -kecepatan * Time.deltaTime, 0);
                break;
            case ArahGerak.kiri:
                gameObject.transform.Translate(-kecepatan * Time.deltaTime, 0, 0);
                break;
            case ArahGerak.kanan:
                gameObject.transform.Translate(kecepatan * Time.deltaTime, 0, 0);
                break;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Dinding"))
        {
            Debug.Log("Kotak Menabrak Dinding");
            if (arahgerak == ArahGerak.atas)
            {
                arahgerak = ArahGerak.bawah;
            }
            else if (arahgerak == ArahGerak.bawah)
            {
                arahgerak = ArahGerak.atas;
            }
            else if (arahgerak == ArahGerak.kanan)
            {
                arahgerak = ArahGerak.kiri;
            }
            else
            {
                arahgerak = ArahGerak.kanan;
            }
            interaksiui12nov.skor++;
            TambahSkor();
        }
    }
    
    public void TambahSkor()
    {
        interaksiui12nov.TeksSkor.text = "Skor: " + interaksiui12nov.skor.ToString();
    }
}
public enum ArahGerak
{
    atas,
    bawah,
    kiri,
    kanan
}