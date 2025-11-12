using UnityEngine;

public class ContohArray : MonoBehaviour
{
    // string[] arraynama = { "Budi", "Asep", "Tono" };
    [SerializeField]
    Mobil[] arrayMobil;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Debug.Log(arraynama[2]);

        // arraynama[0] = "Fadhli";
        // Debug.Log(arraynama[0]);

        // Debug.Log(arraynama.Length);

        // for(int index = 0; index < arraynama.Length; index++)
        // {
        //     Debug.Log(arraynama[index]);
        // }

        for (int index = 0; index < arrayMobil.Length; index++)
        {
            Debug.Log(arrayMobil[index].name);
        }

        foreach (Mobil mobil1 in arrayMobil)
        {
            Debug.Log(mobil1.name);
        }
        Debug.Log(arrayMobil.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
