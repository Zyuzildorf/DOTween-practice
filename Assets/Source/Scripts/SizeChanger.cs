using DG.Tweening;
using UnityEngine;

namespace Source.Scripts
{
    public class SizeChanger : DOTweenAnimation
    {
        [SerializeField] private float _scale;
    
        private void Start()
        {
            transform.DOScale(_scale, Duration).SetLoops(Repeats, LoopType);
        }
    }
}