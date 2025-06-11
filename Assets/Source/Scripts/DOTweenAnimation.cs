using DG.Tweening;
using UnityEngine;

namespace Source.Scripts
{
    public class DOTweenAnimation : MonoBehaviour
    {
        [SerializeField] protected LoopType LoopType;
        [SerializeField] protected float Duration;
        [SerializeField] protected int Repeats;
    }
}