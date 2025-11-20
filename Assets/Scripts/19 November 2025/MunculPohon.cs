using System.Collections;
using JetBrains.Annotations;
using UnityEngine;

public class MunculPohon : MonoBehaviour
{
    public GameObject PohonMuncul;
    public bool sedangMuncul = true;
    void Start()
    {
        StartCoroutine(MunculkanPohon());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MunculkanPohon()
    {
        Vector3 SisiBawah = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0));
        Vector3 TempatMuncul = new Vector3(SisiBawah.x, -2f, 0);
        while(sedangMuncul == true)
        {
            Instantiate(PohonMuncul, TempatMuncul, Quaternion.identity);
            yield return new WaitForSeconds(2);
        }
    }
}
