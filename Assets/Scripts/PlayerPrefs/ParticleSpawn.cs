using UnityEngine;

public class ParticleSpawn : MonoBehaviour
{
    public GameObject objectEffect;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector2 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(objectEffect, mouseWorldPosition, Quaternion.identity);
        }
    }
}
