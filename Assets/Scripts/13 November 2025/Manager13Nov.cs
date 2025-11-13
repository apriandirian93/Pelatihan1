using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class Manager13Nov : MonoBehaviour
{
    public int skor;
    public TMP_Text teksSkor;
    public ClickToMoveSquare clickToMoveSquare;
    public GameObject BolaJatuh;
    public SquareJump squareJump;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Klik kiri");
            // Vector3 vector = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // Debug.Log("Posisi mouse ada di " + vector.ToString());
            TambahSkor();
            UpdateTeksSkor();
            // ToggleKiriKanan();
            clickToMoveSquare.isMoveRight = false;
            MunculDariAtas();
            squareJump.Lompat();
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Klik kanan");
            KurangSkor();
            UpdateTeksSkor();
            clickToMoveSquare.isMoveRight = true;
        }
    }

    void TambahSkor()
    {
        skor++;
        Debug.Log("Skor Bertambah");
    }

    void KurangSkor()
    {
        skor--;
        Debug.Log("Skor Berkurang");
    }

    void UpdateTeksSkor()
    {
        teksSkor.text = skor.ToString();
        Debug.Log("Teks skor berubah");
    }

    void ToggleKiriKanan()
    {
        if (clickToMoveSquare.isMoveRight)
        {
            clickToMoveSquare.isMoveRight = false;
        }
        else
        {
            clickToMoveSquare.isMoveRight = true;
        }
    }

    void MunculDariAtas()
    {
        //ambil posisi dimana kursor mouse berada
        Vector3 posisiKlik = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //ambil posisi titik paling atas layar
        Vector3 titikAtas = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0));
        //gunakan posisi kursor pada sumbu x dan posisi titik paling atas layar untuk Vector3 bernama tempatJatuh
        Vector3 tempatJatuh = new Vector3(posisiKlik.x, titikAtas.y, 0);
        // memunculkan object dengan nama bolaJatuh di posisi tempatJatuh dan dengan rotasi Quaternion.identity
        Instantiate(BolaJatuh, tempatJatuh, Quaternion.identity);
    }
}
