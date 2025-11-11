using UnityEngine;

public class Contoh : MonoBehaviour
{
    // int number1 = 10;
    // int number2 = 7;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // int number3 = number1;
        // number1 = number2;
        // number2 = number3;
        // Debug.Log(number1);
        // Debug.Log(number2);

        Mobil mobil1 = new Mobil();
        mobil1.name = "Avanza";
        mobil1.color = "Hitam";
        mobil1.speed = 60;

        Mobil mobil2 = new Mobil();
        mobil2.name = "Agya";
        mobil2.color = "Merah";
        mobil2.speed = 40;

        Debug.Log("Nama mobil: " + mobil1.name);
        Debug.Log("Warna mobil: " + mobil1.color);
        Debug.Log("Kecepatan mobil: " + mobil1.speed + " km/jam");

        Debug.Log("Nama mobil: " + mobil2.name);
        Debug.Log("Warna mobil: " + mobil2.color);
        Debug.Log("Kecepatan mobil: " + mobil2.speed + " km/jam");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
