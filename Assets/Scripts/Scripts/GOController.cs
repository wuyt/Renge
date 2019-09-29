using UnityEngine;

public class GOController : MonoBehaviour
{
    public GameObject go;

    public void SetGO(bool status)
    {
        go.SetActive(status);
    }
}
