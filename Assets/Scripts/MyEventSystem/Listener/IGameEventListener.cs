

namespace Mohamed_EventSystem.Events
{
    public interface IGameEventListener<T> 
    {
        void OnEventRaised(T item);
    }
}

