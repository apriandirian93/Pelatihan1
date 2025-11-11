using System.Collections.Generic;
using UnityEngine;

public class ContohList : MonoBehaviour
{
    [SerializeField]
    List<Mobil> Listmobil = new List<Mobil>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Mobil mobil = Listmobil.Find(element => element.speed > 50);
        Debug.Log(mobil.name);
        // bool isExsist = Listmobil = Listmobil.Exists(element => element == "Agya");
        // Debug.Log(isExsist);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
