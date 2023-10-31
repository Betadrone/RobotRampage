using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    [SerializeField]
    private string robotType;

    public int health;
    public int range;
    public float fireRate;

    public Transform missileFireSpot;
    UnityEngine.AI.NavMeshAgent agent;

    private Transform player;
    private float timeLastFired;

    private bool isDead;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}