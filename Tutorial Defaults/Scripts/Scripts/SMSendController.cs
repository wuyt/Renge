using UnityEngine;

public class SMSendController : MonoBehaviour
{
    public GameObject go;
   
   public void Send(){
       go.SendMessage("Show");
   }
}
