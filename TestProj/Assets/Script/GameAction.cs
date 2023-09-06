using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "New Game Action", menuName = "ScriptableObjects/Game Action")]
public class GameAction : ScriptableObject
{
    public UnityAction<float> actionFloat;
    public UnityAction<string> actionString;

    public void RaiseAction(float value)
    {
        actionFloat?.Invoke(value);
    }

    public void RaiseAction(string value)
    {
        actionString?.Invoke(value);
    }
}