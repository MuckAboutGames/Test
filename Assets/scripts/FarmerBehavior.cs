using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerBehavior : MonoBehaviour
{
    private float speed = 3.5f;
    private Vector2 target;

    private GameObject[] multipleObjects;

    float timer = 0.0f; // begins at this value
   [SerializeField]
    float timerMax = 1.0f; // event occurs at this value

    void Start()
    {
        target = new Vector2(0.0f, 0.0f);
    }

    void Update()
    {
        float step = speed * Time.deltaTime;
        target = getClosestEnemy().position;

        // move sprite towards the target location
        transform.position = Vector2.MoveTowards(transform.position, target, step);
    }


    public Transform getClosestEnemy()
    {
        multipleObjects = GameObject.FindGameObjectsWithTag("Grass");
        float closestDistance = Mathf.Infinity;
        Transform trans = null;

        if (multipleObjects.Length != 0)
        {
            foreach (GameObject go in multipleObjects)
            {
                float currentDistance;
                currentDistance = Vector2.Distance(transform.position, go.transform.position);
                if (currentDistance < closestDistance)
                {
                    closestDistance = currentDistance;
                    trans = go.transform;
                }
                if (currentDistance == 0)
                {
                    timer += Time.deltaTime;
                    if (timer >= timerMax)
                    {
                        Destroy(go);
                        timer = 0.0f;
                    }
                }
            }
        }
        
        return trans;
    }
}
