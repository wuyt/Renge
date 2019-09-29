using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TfController : MonoBehaviour
{
    public Transform tf;

    public void ResetCube()
    {
        tf.position = Vector3.zero;
        tf.rotation = Quaternion.identity;
        tf.localScale = Vector3.one;
    }
    public void Posistion()
    {
        tf.position = new Vector3(1f, 1.5f, 0);
    }
    public void Rotation()
    {
        tf.eulerAngles = new Vector3(45f, 10f, 30f);
    }
    public void Scale()
    {
        tf.localScale = new Vector3(2.5f, 1f,1.3f);
    }
}
