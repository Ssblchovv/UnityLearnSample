using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[RequireComponent(typeof(Renderer))]
[RequireComponent(typeof(Collider))]
public class ObstacleItem : MonoBehaviour
{
    private static readonly float MAX_HP = 1;

    [SerializeField]
    private float currentValue = MAX_HP;

    public UnityEvent onDestroyObstacle;

    private Renderer rend;

    private void Awake()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = Color.white;
    }

    public void GetDamage(float value)
    {
        currentValue -= value;
        rend.material.color = Color.Lerp(Color.red, Color.white, currentValue);

        if (currentValue <= 0)
        {
            onDestroyObstacle.Invoke();
            Object.Destroy(gameObject);
        }
    }
}
