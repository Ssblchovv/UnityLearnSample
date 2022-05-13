using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vrashenie : SampleScript
{
    [SerializeField]
    private float rotateSpeed;

    [SerializeField]
    Vector3 targetRotation;
    bool rotateting = false;

    Quaternion startRot;
    Quaternion endRot;
    float t;

    
    public void Start()
    {
        startRot = transform.rotation;
        endRot = Quaternion.Euler(targetRotation);
        t = 0;
    }

    public void Update()
    {
        if (rotateting && t<1)
        {
            t += rotateSpeed * Time.deltaTime;
            transform.rotation = Quaternion.Lerp(startRot, endRot, t);
        }
    }
    [ContextMenu("Вращение")]
    public override void Use()
    {
        rotateting = true;

    }
}



