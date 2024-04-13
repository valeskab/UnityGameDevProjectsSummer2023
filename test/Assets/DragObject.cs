using UnityEngine;

public class DragObject : MonoBehaviour
{
    private Vector3 offset;
    private bool isDragging = false;
    private Rigidbody rb;

    private void Start()
    {
        // Get a reference to the Rigidbody component
        rb = GetComponent<Rigidbody>();
    }

    private void OnMouseDown()
    {
        // Calculate the offset between the object's position and the mouse position
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        isDragging = true;
        
        // Disable physics simulation while dragging
        rb.isKinematic = true;
    }

    private void OnMouseDrag()
    {
        if (isDragging)
        {
            // Calculate the new position of the object based on the mouse position
            Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
            rb.MovePosition(new Vector3(newPosition.x, newPosition.y, transform.position.z));
        }
    }

    private void OnMouseUp()
    {
        isDragging = false;
        
        // Re-enable physics simulation after dragging
        rb.isKinematic = false;
    }
}