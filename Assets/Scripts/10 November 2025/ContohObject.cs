using UnityEngine;

[System.Serializable]
public class Mobil
{
    public string name;
    public string color;
    public int speed;

    public Mobil(string nama, string warna, int kecepatan) //nama sama dengan class
    {
        name = nama;
        color = warna;
        speed = kecepatan;
    }
}
