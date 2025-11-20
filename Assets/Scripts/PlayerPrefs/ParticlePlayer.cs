using UnityEngine;

public class ParticlePlayer : MonoBehaviour
{
    public ParticleSystem particle;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            particle.Play();
        }
    }
}
