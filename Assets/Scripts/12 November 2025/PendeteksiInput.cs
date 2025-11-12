using UnityEngine;

public class PendeteksiInput : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    // Input.GetKey untuk tekan dan tahan
    // Input.GetKeyUp ketika dilepas tombolnya
    public Score objectScore;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            objectScore.AddScore();
        }
    }
}
