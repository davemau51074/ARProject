using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace HoloToolkit.Unity.InputModule
{
    /// <summary>
    /// This class implements IInputClickHandler to handle the tap gesture.


    public class TapLaunch : MonoBehaviour, IInputClickHandler
    {
        public void OnInputClicked(InputClickedEventData eventData)
        {
            // Increase the scale of the object just as a response.
            ///gameObject.transform.localScale -= 0.9f * gameObject.transform.localScale;
           
            eventData.Use(); // Mark the event as used, so it doesn't fall through to other handlers.
        }
    }

}