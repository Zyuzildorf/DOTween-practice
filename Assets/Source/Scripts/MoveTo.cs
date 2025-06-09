using DG.Tweening;
using UnityEngine;

namespace Source.Scripts
{
    public class MoveTo : DOTweenAnimation
    {
        [SerializeField] private Vector3 _position;

        private void Start()
        {
            transform.DOMove(_position, _duration).SetLoops(_repeats, _loopType);
        }
    }
}