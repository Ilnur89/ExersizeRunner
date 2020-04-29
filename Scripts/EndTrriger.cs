using UnityEngine;


public class EndTrriger : MonoBehaviour
{
    public ManageGame gamecontrol;
    public void OnTriggerEnter()
    {
       gamecontrol.CompleteLevel();
       
    }
}
