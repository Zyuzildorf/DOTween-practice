using DG.Tweening;
using UnityEngine;

namespace Source.Scripts
{
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
            _meshRenderer.material.DOColor(_color, _duration).SetLoops(_repeats, _loopType);
        }
    }
}