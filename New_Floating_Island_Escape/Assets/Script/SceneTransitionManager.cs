using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionManager : MonoBehaviour
{

    public ResetScene fadeScreen;
    public int sceneIndex = 0;

    public void GoToScene(int sceneIndex)
    {

        StartCoroutine(GoToSceneRoutine(sceneIndex));

    }

    IEnumerator GoToSceneRoutine(int sceneIndex)
    {
        fadeScreen.FadeOut();
        yield return new WaitForSeconds(fadeScreen.fadeDuration);

        SceneManager.LoadScene(sceneIndex);
    }

    public void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Player")
        {

            GoToScene(sceneIndex);
            Debug.Log("Player Fall Reset Scene!!!!");

        }

    }


}
