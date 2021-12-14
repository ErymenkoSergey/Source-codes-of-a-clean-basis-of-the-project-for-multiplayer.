using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour
{
    private async void Start()
    {
        await Task.Delay(1000);
        SceneManager.LoadScene(1);
    }
}
