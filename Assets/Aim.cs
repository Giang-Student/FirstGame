using UnityEngine;

public class Aim : MonoBehaviour
{
    [SerializeField] private Vector3 mousePosition;

    public void setMousePosition(Vector3 mousePosition)
    {
        this.mousePosition = mousePosition;
    }

    public Vector3 getMousePosition()
    {
        return mousePosition;
    }

    private void Update()
    {
        mousePosition = Input.mousePosition;

        // đổi từ tọa độ màn hình sang tọa độ world

        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // vì game 2D nên giữ z = 0

        mousePosition.z = 0;

        transform.position = mousePosition;
    }
}