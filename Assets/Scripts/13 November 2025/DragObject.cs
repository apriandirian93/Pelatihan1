using UnityEngine;

public class DragObject : MonoBehaviour
{
    void OnMouseDrag()
    {
        Vector2 WorldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //mengunci posisi X
        Vector2 squarePosition = new Vector2(WorldMousePosition.x, transform.position.y);
        //mengunci posisi Y
        //Vector2 squarePosition = new Vector2(transform.position.x, WorldMousePosition.y);
        Vector2 minimum = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
        Vector2 maximum = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0));
        //membatasi sumbu x dari 0 sampai lebar screen
        squarePosition.x = Mathf.Clamp(squarePosition.x, minimum.x, maximum.x);
        transform.position = squarePosition;
    }

    // void OnMouseEnter()
    // {
    //     Debug.Log("Enter");
    // }

    // void OnMouseDown()
    // {
    //     Debug.Log("Down");
    // }

    //     void OnMouseExit()
    // {
    //     Debug.Log("Exit");
    // }
}
