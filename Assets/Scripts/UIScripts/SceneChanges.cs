using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanges : MonoBehaviour
{
    // Start is called before the first frame update
    public int SceneChanged;
    public void OnClick()
    {
        SceneManager.LoadScene(SceneChanged);
    }
}
