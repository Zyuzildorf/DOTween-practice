using DG.Tweening;
using UnityEngine;

namespace Source.Scripts
{
    public class DOTweenAnimation : MonoBehaviour
    {
        [SerializeField] protected LoopType _loopType;
        [SerializeField] protected float _duration;
        [SerializeField] protected int _repeats;
    }
}