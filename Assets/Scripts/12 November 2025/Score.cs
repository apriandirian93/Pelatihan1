using UnityEngine;

public class Score : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public PendeteksiInput objectPendeteksiInput;
    public int score;
    public void OnEnable()
    {
        // Listen
        objectPendeteksiInput.inputEvent += AddScore;
    }
    public void AddScore()
    {
        score = score + 1;
    }
    public void OnDisable()
    {
        // Unlisten
        objectPendeteksiInput.inputEvent -= AddScore;
    }
}
