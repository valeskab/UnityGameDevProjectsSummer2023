using UnityEngine;

public class NoteMatchBehaviour : MonoBehaviour
{
    public ID idObj;

    public void ButtonClicked()
    {
        var otherID = GetComponent<IDContainerBehaviour>().idObj;
        if (otherID == idObj)
        {
            Debug.Log("Matched");
        }
        else
        {
            Debug.Log("Not Matched");
        }
    }
}