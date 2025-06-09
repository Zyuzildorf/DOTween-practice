using DG.Tweening;
using UnityEngine;

namespace Source.Scripts
{
    public class RotateTo : DOTweenAnimation
    {
        [SerializeField] private RotateMode _rotateMode;
        [SerializeField] private Vector3 _rotateTo;

        private void Start()
        {
            transform.DORotate(_rotateTo, _duration, _rotateMode).SetLoops(_repeats, _loopType);
        }
    }
}