using DG.Tweening;
using UnityEngine;

namespace Source.Scripts
{
    [RequireComponent(typeof(MeshRenderer))]
    public class ColorChanger : DOTweenAnimation
    {
        [SerializeField] private Color _color;

        private MeshRenderer _meshRenderer;

        private void Awake()
        {
            _meshRenderer = GetComponent<MeshRenderer>();
        }

        private void Start()
        {
            _meshRenderer.material.DOColor(_color, Duration).SetLoops(Repeats, LoopType);
        }
    }
}