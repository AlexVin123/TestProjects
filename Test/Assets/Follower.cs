using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private Vector3 _targetLastPosition;
    private Tweener _tween;
    private Animator _animator;
    bool _isWalk;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _animator.SetTrigger("Walk");
        _isWalk = true;
        _tween = transform.DOMove(_target.position, 1).SetAutoKill(false);
        transform.DOLookAt(_target.position,1);
        _targetLastPosition = _target.position;
    }

    private void Update()
    {
        if(_targetLastPosition != _target.position)
        {
            _tween.ChangeEndValue(_target.position, true).Restart();
            _targetLastPosition = _target.position;
        }

        transform.DOLookAt(_target.position,1);

    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        if (_isWalk == false)
        {
            _animator.SetTrigger("Walk");
            _isWalk = true;
        }
        else
        {
            _animator.SetTrigger("Run");
            _isWalk = false;
        }
    }
}
