using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeFollower : MonoBehaviour
{
    [SerializeField] public GameObject[] nodes;
    private int _currentNodeIndex = 0;
    [SerializeField] private float _speed;
    [SerializeField] private bool _destroyAtEnd;
    // Update is called once per frame
    void Update()
    {
       var node = nodes[_currentNodeIndex];
       var newPos = Vector3.MoveTowards(transform.position,node.transform.position,_speed * Time.deltaTime);
       transform.localScale = newPos.x - transform.position.x > 0 ? new Vector3(1,1,1) : new Vector3(-1,1,1);
       transform.position = newPos;
       if(node.transform.position == transform.position)
       { _currentNodeIndex++; if(_currentNodeIndex > nodes.Length - 1){ _currentNodeIndex = 0; if(_destroyAtEnd){Destroy(gameObject);} }  }
    }

}
