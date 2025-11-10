using UnityEngine;

public class ContohFunction : MonoBehaviour
{
        // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(perkalian(2, 3));
    }
    
    public void perkalian(int angka7, int angka8)
    {
        int hasilkali = angka7 * angka8;
        return hasilkali;
    }
}
