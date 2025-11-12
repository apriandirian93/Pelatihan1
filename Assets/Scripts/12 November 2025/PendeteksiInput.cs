using System;
using UnityEngine;

public class PendeteksiInput : MonoBehaviour
{
    // public Score objectScore;
    public Action inputEvent;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // objectScore.AddScore();
            inputEvent.Invoke();
        }
    }
}
