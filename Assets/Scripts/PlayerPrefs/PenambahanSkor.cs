using TMPro;
using UnityEngine;

public class PenambahanSkor : MonoBehaviour
{
    public int highscore = 0;
    public int skor = 0;
    public TMP_Text teksSkor;
    public TMP_Text tekshighscore;
    private void Start()
    {
        if (PlayerPrefs.HasKey("highscore"))
        {
            highscore = PlayerPrefs.GetInt("highscore");
            tekshighscore.text = "High Score: " + highscore;
        }
    }
    public void TambahSKor()
    {
        skor = skor + 1;
        teksSkor.text = "Score: " + skor;
    }

    public void KurangSkor()
    {
        skor = skor - 1;
        teksSkor.text = "Score: " + skor;
    }

    public void SimpanHighScore()
    {
        PlayerPrefs.SetInt("lastscore", skor);
        if (skor > highscore)
        {
            highscore = skor;
            PlayerPrefs.SetInt("highscore", highscore);
            PlayerPrefs.Save();
            tekshighscore.text = "High Score: " + highscore;
        }
        // PlayerPrefs.DeleteKey("highscore");
    }
}
