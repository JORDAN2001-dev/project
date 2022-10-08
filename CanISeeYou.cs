using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanISeeYou : MonoBehaviour
{

    public Color detectionColor = Color.green;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RayCastSight();

    }
    private void RayCastSight()
    {
        Vector3 objectOrigin = transform.position;
        Vector3 sightDirection = transform.forward;

        float maxDistance = 10f;

        Debug.DrawRay(objectOrigin, sightDirection * maxDistance, Color.red);

        Ray ray = new Ray(objectOrigin, sightDirection);

        bool visible = Physics.Raycast(ray, out RaycastHit raycastHit, maxDistance);

        if (visible)
        {
            raycastHit.collider.GetComponent<Renderer>().material.color = detectionColor;
        }
    }
}
