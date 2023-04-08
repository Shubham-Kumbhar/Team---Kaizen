using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanges : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClick(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
