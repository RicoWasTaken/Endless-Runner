using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toHowto : MonoBehaviour
{
    public void ToHowTo()
    {
        SceneManager.LoadSceneAsync("how to play");
    }
}
