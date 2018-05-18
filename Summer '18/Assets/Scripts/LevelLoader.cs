using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour {

    public GameObject loadingScreen;
    public Slider slider;

    public void LoadLevel (int sceneIndex) 
    {
        StartCoroutine(Load(sceneIndex));
    }

    IEnumerator Load (int sceneIndex) 
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex); //Loads the Scene asynchronously in the background.

        loadingScreen.SetActive(true);

        while (operation.isDone == false) 
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);

            Debug.Log(operation.progress);
            Debug.Log("**************");
            slider.value = progress;

            yield return null;
        }
    }
}
