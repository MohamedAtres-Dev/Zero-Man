using UnityEngine;

namespace Mohamed_EventSystem.Events
{
    [CreateAssetMenu(fileName ="New Void Event", menuName ="Game Events/Void Event")]
    public class VoidEvent : BaseGameEvent<MyVoid>
    {
        public void Raise() => Raise((new MyVoid()));
    }
}