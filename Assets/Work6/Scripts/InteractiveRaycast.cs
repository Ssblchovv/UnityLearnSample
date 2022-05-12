using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Camera))]
public class InteractiveRaycast : MonoBehaviour
{
    [SerializeField]
    GameObject prefab = null;

    InteractiveBox intBox = null;

    Camera cam;

    void Awake()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out RaycastHit info))
            {
                var tr = info.transform;
                // инструментальная 12 ст 35 мед юнион
                if (tr.CompareTag("InteractivePlane"))
                {
                    if (prefab == null) return;
                    Instantiate(prefab, info.point + info.normal*0.5f, Quaternion.LookRotation(info.normal));
                }
                else if (tr.TryGetComponent<InteractiveBox>(out InteractiveBox ib))
                {
                    if (intBox == null)
                    {
                        intBox = ib;
                    }
                    else
                    {
                        intBox.AddNext(ib);
                        intBox = null;
                    }
                }
            }
        } 
        else if (Input.GetMouseButtonUp(1))
        {
            if (Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out RaycastHit info))
            {
                if (info.transform.TryGetComponent<InteractiveBox>(out InteractiveBox ib))
                {
                    Destroy(ib.gameObject);
                }
            }
        }
    }
}
