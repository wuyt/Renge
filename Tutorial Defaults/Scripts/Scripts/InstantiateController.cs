using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateController : MonoBehaviour
{
    public Transform perfab;

    public void Add(){
        Instantiate(perfab);
    }
}
