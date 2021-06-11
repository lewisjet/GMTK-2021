using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeFollower : MonoBehaviour
{
    [SerializeField] private GameObject[] _nodes;
    private int _currentNodeIndex = 0;
    [SerializeField] private float _speed;
    // Update is called once per frame
    void FixedUpdate()
    {
       var node = _nodes[_currentNodeIndex];
       Vector3.MoveTowards(transform.position,node.transform.position,_speed * Time.deltaTime);
       if(node.transform.position == transform.position){ _currentNodeIndex++; }
    }

}
