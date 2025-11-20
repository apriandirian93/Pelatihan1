using UnityEngine;

public class PohonGerak : MonoBehaviour
{
    public float kecepatan = 3f;
    void Update()
    {
        gameObject.transform.Translate(-kecepatan * Time.deltaTime, 0, 0);
    }
}
