using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryController : MonoBehaviour
{
   public GameObject go;

   public void Del(){
       Destroy(go);
   }
}
