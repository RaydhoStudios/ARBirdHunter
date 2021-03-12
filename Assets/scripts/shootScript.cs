using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;
using EZCameraShake;

public class shootScript : MonoBehaviour
{

    public GameObject arCamera;
    public GameObject feathers;
    public Text coinText;
    private float coinScore;
    


    private void Awake()
    {
        coinText.text = coinScore.ToString("0");
       
    }


    public void Shoot(AudioSource shotgun)
    {
        shotgun.Play();
        RaycastHit hit;
        CameraShaker.Instance.ShakeOnce(4f, 4f, .1f, 1f);
        

        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            
            if (hit.transform.name == "robin(Clone)" || hit.transform.name == "gold(Clone)" || hit.transform.name == "sparrow(Clone)"|| hit.transform.name == "cardinal(Clone)"|| hit.transform.name == "chick(Clone)"|| hit.transform.name == "jay(Clone)"|| hit.transform.name == "crow(Clone)")
            {
                coinScore++;
                coinText.text = coinText.text = coinScore.ToString("0");
                
                
                Destroy(hit.transform.gameObject);

                Instantiate(feathers, hit.point, Quaternion.LookRotation(hit.normal));
                //CameraShaker.Instance.ShakeOnce(4f, 4f, .1f, 1f);
            }
        }
    }
}
