using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject Ribbon1;
    public GameObject Ribbon2;
    public GameObject Ribbon3;
    public GameObject Ribbon4;
    public GameObject Ribbon5;
    public GameObject Ribbon6;
    public GameObject Ribbon7;

    private void Start()
    {
        StartCoroutine(ActivationRoutine());
    }

    private IEnumerator ActivationRoutine()
    {
        //Set the first ribbon active
        yield return new WaitForSeconds(1);
        Ribbon1.SetActive(true);
        //Turn Ribbons active each 3 seconds
        yield return new WaitForSeconds(3);
        Ribbon2.SetActive(true);
        yield return new WaitForSeconds(3);
        Ribbon3.SetActive(true);
        yield return new WaitForSeconds(3);
        Ribbon4.SetActive(true);
        yield return new WaitForSeconds(3);
        Ribbon5.SetActive(true);
        yield return new WaitForSeconds(3);
        Ribbon6.SetActive(true);
        yield return new WaitForSeconds(3);
        Ribbon7.SetActive(true);
    }
}
