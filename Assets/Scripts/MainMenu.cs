using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public void StartNew()
    {
        SceneManager.LoadScene(0);
    }
}
