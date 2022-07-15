using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flowPlayer : MonoBehaviour
{
    public Transform target;

    public float lerpSpeed = 5;

    public float zOffset = -19;

    public float yPos = 19;

    

	void LateUpdate ()
    {
        var currentPosition = transform.position;

        var targetPosition = new Vector3(target.position.x, yPos + target.position.y, target.position.z + zOffset);

        transform.position = targetPosition;
	}
   
}
