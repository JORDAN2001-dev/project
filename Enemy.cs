using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private Transform player;

    private NavMeshAgent nav;

    private Vector3 targetDir;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        targetDir = player.position - transform.position;

        float _angle = (Vector3.Angle(targetDir, transform.forward));

        if (_angle >= -180 && _angle <= 180)
        {
            nav.SetDestination(player.position);
        }





    }
}
