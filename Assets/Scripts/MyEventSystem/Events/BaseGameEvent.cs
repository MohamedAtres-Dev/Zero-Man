using System.Collections.Generic;
using UnityEngine;

namespace Mohamed_EventSystem.Events
{
    public abstract class BaseGameEvent<T> : ScriptableObject
    {
        private readonly List<IGameEventListener<T>> eventListners = new List<IGameEventListener<T>>();

        public void Raise(T item)
        {
            for (int i = eventListners.Count - 1; i >= 0; i--)
            {
                eventListners[i].OnEventRaised(item);
            }
        }

        public void RegisterListener(IGameEventListener<T> listener)
        {
            if (!eventListners.Contains(listener))
            {
                eventListners.Add(listener);
            }
        }

        public void UnregisterListener(IGameEventListener<T> listener)
        {
            if (eventListners.Contains(listener))
            {
                eventListners.Remove(listener);
            }
        }
    }
}
