using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spitter : MonoBehaviour
{
    [SerializeField] private GameObject _spit, _dest;
    [SerializeField] private float _timeToWait = 1f;
    bool complete = true;
    // Update is called once per frame
    void Update()
    {
        if(!complete) { return; }
        StartCoroutine(enumerator());
    }

    IEnumerator enumerator()
    {
         complete = false;
       var go = Instantiate(_spit, transform);
        var sp = go.GetComponent<NodeFollower>();
        go.transform.position = transform.position;
        sp.nodes = new GameObject[2];
        sp.nodes[0] = this.gameObject;
        sp.nodes[1] = _dest;
        yield return new WaitForSeconds(_timeToWait);
        complete = true;
    }
}
