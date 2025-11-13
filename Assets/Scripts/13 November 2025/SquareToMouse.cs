using UnityEngine;

public class SquareToMouse : MonoBehaviour
{
    public Transform squareTransform;
    public Vector2 PosisiKlik;
    // Update is called once per frame
    void Update()
    {
        // // geser object ke mouse
        // Vector2 WorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // // squareTransform.position = WorldPosition;
        // squareTransform.position = Vector2.MoveTowards(squareTransform.position,WorldPosition, 0.1f);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            PosisiKlik = Camera.main.ScreenToWorldPoint(Input.mousePosition);            
        }
        squareTransform.position = Vector2.MoveTowards(squareTransform.position,PosisiKlik, 0.1f);
    }
}
