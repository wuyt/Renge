using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class SwitchController : MonoBehaviour
{
    public Slider slider;
    private AsyncOperation asyncOperation;



    public void GoFirst()
    {
        SceneManager.LoadScene("First");
    }

    public void BackStart()
    {
        SceneManager.LoadScene("Start");
    }

    public void GoSecond()
    {
        SceneManager.LoadSceneAsync("Second");
    }



    void Update()
    {
        if (asyncOperation != null)
        {
            slider.value = asyncOperation.progress;
        }
    }
    IEnumerator loadScene()
    {
        asyncOperation = SceneManager.LoadSceneAsync("Third");
        yield return asyncOperation;
    }
    public void AsynScene()
    {
        StartCoroutine(loadScene());
    }

}
