using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : SampleScript
{
    public int speed = 1;

    private Vector3 startPosition;
    public Vector3 endPosition;
    private bool moving = false;
    private float cummsumTime = 0f;
    private float dist = 0f;

    [ContextMenu("Use")]
    public override void Use()
    {
        moving = true;
        dist = Vector3.Distance(transform.position, endPosition);
        cummsumTime = 0f;
        startPosition = transform.position;
    }

    private void Start()
    {

    }

    void Update()
    {
        if (moving)
        {
            transform.position = Vector3.Lerp(startPosition, endPosition, cummsumTime * speed / dist);
            cummsumTime += Time.deltaTime;
            if (Vector3.Distance(transform.position, endPosition) <= Mathf.Epsilon)
            {
                moving = false;
            }
        }
    }
}
