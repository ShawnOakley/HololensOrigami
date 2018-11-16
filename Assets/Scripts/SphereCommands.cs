using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCommands : MonoBehaviour {

    // Called by GazeGestureManager when the user performs a Select Gesture
    void OnSelect()
    {
        if (!this.GetComponent<Rigidbody>())
        {
            var rigidbody = this.gameObject.AddComponent<Rigidbody>();
            rigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;
        }
    }
}
