using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{
    public GameAction gameAction;
    public UnityEvent respondEvent;
    public UnityEvent respondLateEvent;

    private void OnEnable()
    {
        gameAction.actionFloat += HandleAction;
    }

    private void OnDisable()
    {
        gameAction.actionFloat -= HandleAction;
    }

    private void HandleAction(float value)
    {
        respondEvent.Invoke();
    }

    public void DelayedAction()
    {
        respondLateEvent.Invoke();
    }
}