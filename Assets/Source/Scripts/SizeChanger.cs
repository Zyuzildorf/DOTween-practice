using DG.Tweening;
using UnityEngine;

namespace Source.Scripts
{
    public class SizeChanger : MonoBehaviour
    {
        [SerializeField] private LoopType _loopType;
        [SerializeField] private float _scale;
        [SerializeField] private float _duration;
        [SerializeField] private int _repeats;
    
        private void Start()
        {
            transform.DOScale(_scale, _duration).SetLoops(_repeats, _loopType);
        }
    }
}
