using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HoloToolkit.Unity.InputModule
{



    public class TapBounce : MonoBehaviour, IInputClickHandler
    {
       // public GameObject particle;
        //  public AudioSource audioS;
        public void OnInputClicked(InputClickedEventData eventData)
        {
            // audioS = GetComponent<AudioSource>();
            // Increase the scale of the object just as a response.
           // gameObject.transform.localScale -= 0.9f * gameObject.transform.localScale;
            // Instantiate(particle, transform.position, transform.rotation);
            gameObject.transform.Translate(Vector3.up * Time.deltaTime * 50, Space.World);
            gameObject.transform.Translate(Vector3.forward * Time.deltaTime * 10, Space.World);
            //  audioS.Play();
            // Destroy(gameObject);
            eventData.Use(); // Mark the event as used, so it doesn't fall through to other handlers.
        }
    }
}
