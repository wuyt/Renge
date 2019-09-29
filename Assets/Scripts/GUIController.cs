using UnityEngine;
using UnityEngine.UI;

public class GUIController : MonoBehaviour
{
    public void OnClicked()
    {
        Debug.Log("按钮被按下");
    }

    public void OnCliced(string str){
        Debug.Log(str);
    }



    void Start()
    {
        Button btn = GetComponent<Button>();
        if(btn!=null){
            btn.onClick.AddListener(ScriptOnCliced);
        }
    }
    private void ScriptOnCliced(){
        Debug.Log("脚本直接获取");
    }
}
