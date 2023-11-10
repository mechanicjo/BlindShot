using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Rigidbody target;
    
    bool isLive;

    private Rigidbody _rigid;
    private SpriteRenderer _spriter;
    
    // Start is called before the first frame update
    void Start()
    {
        _rigid = GetComponent<Rigidbody>();
        _spriter = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 dirVec = target.position - _rigid.position;
        Vector3 nextVec = speed * Time.fixedDeltaTime * dirVec.normalized;
        _rigid.MovePosition(_rigid.position + nextVec);
        _rigid.velocity = Vector3.zero;
        
    }

    private void OnEnable()
    {
        target = GameManager.instance.player.GetComponent<Rigidbody>();
    }
}
