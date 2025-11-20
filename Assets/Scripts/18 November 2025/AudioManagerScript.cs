using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{
    public AudioSource _BGM;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Spasi ditekan");
            PutarBGM();
        }
    }

    public void PutarBGM()
    {
        _BGM.loop = true;
        _BGM.Play();

    }
}
