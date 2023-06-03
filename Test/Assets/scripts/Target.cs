using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Target : MonoBehaviour
{
    [SerializeField] private Vector3[] _poinWave;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(transform.DOMove(_poinWave[0],1).SetEase(Ease.Linear));
        sequence.Append(transform.DOMove(_poinWave[1], 3).SetEase(Ease.Linear));
        sequence.Append(transform.DOMove(_poinWave[2], 4).SetEase(Ease.Linear));
        sequence.Append(transform.DOMove(_poinWave[3], 5).SetEase(Ease.Linear));
        sequence.Append(transform.DOMove(_poinWave[0], 4).SetEase(Ease.Linear));

        sequence.SetLoops(-1).SetEase(Ease.Linear);
    }
}
