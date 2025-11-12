using TMPro;
using UnityEngine;

public class InteraksiUI12Nov : MonoBehaviour
{
    public KotakBergerak kotakpemain;
    public int skor;
    public TMP_Text TeksSkor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void gerakatas()
    {
        kotakpemain.arahgerak = ArahGerak.atas;
    }

    public void gerakbawah()
    {
        kotakpemain.arahgerak = ArahGerak.bawah;
    }

    public void gerakkiri()
    {
        kotakpemain.arahgerak = ArahGerak.kiri;
    }
    
    public void gerakkanan()
    {
        kotakpemain.arahgerak = ArahGerak.kanan;
    }
}
