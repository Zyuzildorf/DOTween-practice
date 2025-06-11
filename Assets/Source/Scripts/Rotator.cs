using DG.Tweening;
using UnityEngine;

namespace Source.Scripts
{
    public class Rotator : DOTweenAnimation
    {
        [SerializeField] private RotateMode _rotateMode;
        [SerializeField] private Vector3 _rotateTo;

        private void Start()
        {
            transform.DORotate(_rotateTo, Duration, _rotateMode).SetLoops(Repeats, LoopType);
        }
    }
}