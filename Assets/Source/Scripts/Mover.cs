using DG.Tweening;
using UnityEngine;

namespace Source.Scripts
{
    public class Mover : DOTweenAnimation
    {
        [SerializeField] private Vector3 _position;

        private void Start()
        {
            transform.DOMove(_position, Duration).SetLoops(Repeats, LoopType);
        }
    }
}