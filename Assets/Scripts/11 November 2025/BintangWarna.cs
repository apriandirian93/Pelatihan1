using UnityEngine;

public class BintangWarna : MonoBehaviour
{
    SpriteRenderer _spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        //_spriteRenderer.color = Color.grey;

        Color warna;
        ColorUtility.TryParseHtmlString("#28ABCD", out warna);
        _spriteRenderer.color = warna;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
