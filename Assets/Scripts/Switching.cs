using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Switching : MonoBehaviour
{
    public GameObject deleteObj;
    public GameObject displayObj;
    public GameObject deleteTxt;
    public GameObject displayTxt;
    public GameObject pannelError;
    public GameObject BoutonReset;

    //Elisa
    //public int score;


    public void Switch()
    {
        deleteObj.SetActive(false);
        displayObj.SetActive(true);
        deleteTxt.SetActive(false);
        displayTxt.SetActive(true);
    }

    public void resetScene()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        StartCoroutine(WaitForSceneLoad());
    }

    private IEnumerator WaitForSceneLoad()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Echec()
    {
        pannelError.SetActive(true);
        BoutonReset.SetActive(false);
    }
}
