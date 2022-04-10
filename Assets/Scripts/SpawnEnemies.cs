using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public Vector3 Min;
    public Vector3 Max;
    private float _xAxis;
    private float _yAxis;
    private float _zAxis; //If you need this, use it
    private Vector3 _randomPosition;
    public bool _canInstantiate;
    float enabledTime = 0;

    private void Start()
    {
        SetRanges();
    }
    private void Update()
    {
        _xAxis = Random.Range(Min.x, Max.x);
        _yAxis = Random.Range(Min.y, Max.y);
        _zAxis = Random.Range(Min.z, Max.z);
        _randomPosition = new Vector3(_xAxis, _yAxis, _zAxis);
    
        if(enabledTime % 300 == 0)
        {
            InvokeRepeating("InstantiateRandomObjects", 1, 5);
            enabledTime++;
        }
        
    }
    //Here put the ranges where your object will appear, or put it in the inspector.
    private void SetRanges()
    {
        Min = new Vector3(-20, 0, -50); //Random value.
        Max = new Vector3(20, 0, 50); //Another ramdon value, just for the example.
    }
    private void InstantiateRandomObjects()
    {
        if (_canInstantiate)
        {
            Instantiate(gameObject, _randomPosition, Quaternion.identity);
            _canInstantiate = false;
        }
    }
}
