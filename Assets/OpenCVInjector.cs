using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Reaktion;

public class OpenCVInjector : InjectorBase
{



    // OpenCV code goes here.
    // Example code in PlayerTrackedObject.cs
    // Update dbLevel

    public void Update()
    {
        // Add this one line
        dbLevel = transform.position.y; //Use PlayerTrackedObject and write position to dbLevel. 
    }
}
