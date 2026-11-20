

using UnityEngine;
using UnityEngine.SceneManagement;
public class IntroScene : MonoBehaviour
{
    void Start()
    {
        Invoke("LoadScene", 2f);
    }

    void LoadScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}