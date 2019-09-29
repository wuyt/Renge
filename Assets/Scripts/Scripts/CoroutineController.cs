using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
        StartCoroutine(WaitTime());
        Debug.Log("go on");
    }

    IEnumerator WaitTime(){
        Debug.Log("start wait");
        yield return new WaitForSeconds(5);
        Debug.Log("End wait");
    }
}
