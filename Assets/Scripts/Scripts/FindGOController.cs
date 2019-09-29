using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindGOController : MonoBehaviour
{
    public GameObject go1;

    public void Find1()
    {
        Debug.Log(go1.name);
    }
    public void Find2()
    {
        var go = GameObject.Find("Green");
        Debug.Log(go.name);
    }
    public void Find3()
    {
        var go = transform.Find("/GameMaster/Grey").gameObject;
        Debug.Log(go.name);
    }
    public void Find4()
    {
        var go = GameObject.FindWithTag("Player");
        Debug.Log(go.name);
    }
}
