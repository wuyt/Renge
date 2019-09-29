using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindComponentController : MonoBehaviour
{
    public Camera cam;

    public void FindCam(){
        Debug.Log(cam);
    }
    public void FindCanvas(){
        var canvas = FindObjectOfType<Canvas>();
        Debug.Log(canvas);
    }

    public void FindAudio(){
        var audio = GetComponent<AudioSource>();
        Debug.Log(audio);
    }
}
