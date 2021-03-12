using System.Collections;
using System.Collections.Generic;
//using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource menumusic;

    private void Start()
    {
        menumusic = GetComponent<AudioSource>();

        if(SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(1) || SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(3))
        {
            menumusic.Play();
        }
    }

    public void playGame(Animator anim)
    {
        anim.SetTrigger("Start");
        StartCoroutine( LoadLevel(2) );

       
    }

    IEnumerator LoadLevel(int levelindex)
    {
        
        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(levelindex);
    }
    public void exitGame()
    {
        Application.Quit();
    }
    public void OpenInstagram()
    {
        Application.OpenURL("https://www.instagram.com/raydho_studios/");
    }
    public void replayGame(Animator anim)
    {
        anim.SetTrigger("Start");
        StartCoroutine(LoadLevel(2));


    }
}
