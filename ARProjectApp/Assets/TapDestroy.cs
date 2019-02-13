using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace HoloToolkit.Unity.InputModule
{

 

    public class TapDestroy : MonoBehaviour, IInputClickHandler
    {
        public GameObject particle;
      //  public AudioSource audioS;
        
        public void OnInputClicked(InputClickedEventData eventData)
        {
           // audioS = GetComponent<AudioSource>();
            // Increase the scale of the object just as a response.
            //  gameObject.transform.localScale -= 0.9f * gameObject.transform.localScale;
            Instantiate(particle, transform.position, transform.rotation);
           
          //  audioS.Play();
            Destroy(gameObject);
            eventData.Use(); // Mark the event as used, so it doesn't fall through to other handlers.
        }
    }
}
