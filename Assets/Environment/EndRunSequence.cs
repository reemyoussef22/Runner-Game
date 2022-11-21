using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndRunSequence : MonoBehaviour
{

    public GameObject liveCoins;
    public GameObject EndScreen;
    public GameObject FadeOut;

    void Start()
    {
        StartCoroutine(EndSequence());
    }

    IEnumerator EndSequence()
    {
        yield return new WaitForSeconds(1);
        liveCoins.SetActive(false);
        EndScreen.SetActive(true);
        yield return new WaitForSeconds(1);
        FadeOut.SetActive(true);
    }
}
