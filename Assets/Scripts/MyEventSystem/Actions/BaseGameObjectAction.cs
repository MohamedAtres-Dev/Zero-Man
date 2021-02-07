using UnityEngine;
namespace Mohamed_EventSystem.Actions {
public abstract class BaseGameObjectAction : ScriptableObject
{
    public abstract void OnPerformAction(GameObject obj);
}
}