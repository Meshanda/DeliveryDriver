using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;

    [Range(-10, -100)]
    [SerializeField]
    float camOffset = -10f;
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0,0,camOffset);
    }
}
