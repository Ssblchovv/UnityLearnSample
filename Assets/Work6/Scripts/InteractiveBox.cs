using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(BoxCollider))]
public class InteractiveBox : MonoBehaviour
{
    [SerializeField]
    private InteractiveBox next = null;

    void Update()
    {
        if (this.next == null) return;
        

        var dir = (this.next.transform.position - transform.position).normalized;
        if (Physics.Raycast(this.transform.position, dir, out RaycastHit info))
        {
            var go = info.transform.gameObject;
            if (go.TryGetComponent<ObstacleItem>(out ObstacleItem oi))
            {
                oi.GetDamage(Time.deltaTime);
            }
            Debug.DrawLine(this.transform.position, info.point, Color.yellow);
            return;
        }

        Debug.DrawLine(this.transform.position, this.next.transform.position, Color.yellow);
    }

    public void AddNext(InteractiveBox box)
    {
        if (this.next != null) return;
        this.next = box;
    }
}
