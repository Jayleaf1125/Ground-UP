 using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{
       public void MoveToSceneOne()
    {
        SceneManager.LoadScene("StartScene");
    }
}
