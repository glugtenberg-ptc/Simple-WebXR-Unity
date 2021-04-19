using System.Collections;
using System.Collections.Generic;
using Rufus31415.WebXR;
using UnityEngine;

public class HitTester : MonoBehaviour
{

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(SimpleWebXR.HitTestResult != null && SimpleWebXR.HitTestResult.Hit)
        {
            var hitPos = SimpleWebXR.HitTestResult.Position;
            var hitRot = SimpleWebXR.HitTestResult.Rotation;

            transform.SetPositionAndRotation(hitPos, hitRot);

            foreach (Transform child in transform)
                child.gameObject.SetActive(true);
        }
        else
        {
            foreach (Transform child in transform)
                child.gameObject.SetActive(false);
        }
    }
}
