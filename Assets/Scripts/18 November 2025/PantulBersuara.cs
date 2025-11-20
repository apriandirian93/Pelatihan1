using UnityEngine;

public class PantulBersuara : MonoBehaviour
{
    public AudioSource _SFX;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PutarEfek();
    }

    public void PutarEfek()
    {
        _SFX.Play();

    }
}
