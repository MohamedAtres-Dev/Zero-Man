using UnityEngine;

namespace Mohamed_EventSystem.Actions {
[CreateAssetMenu(fileName ="New Disable Action" , menuName ="Actions/Disable Action")]
public class DisableAction : BaseGameObjectAction
{
     
    public override void OnPerformAction(GameObject obj)
    {
        obj.SetActive(false);
    }


}
}