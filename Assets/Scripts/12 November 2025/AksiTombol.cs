using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AksiTombol : MonoBehaviour
{
    // Sprite adalah asset gambar yang ingin dimasukkan ke object image
    public Sprite assetGambar;
    // Image adalah component dari object image yang ada di dalam scene
    public Image image;
    public TMP_Text objectText;
    public void Aksi()
    {
        // // mengubah gambar
        // image.sprite = assetGambar;
        // // mengubah teks
        // objectText.text = "RAM";
        // Debug.Log("Tombol ditekan");
        
        // Pindah ke scene baru
        SceneManager.LoadScene("Day 3 Scene Baru");
    }
}
