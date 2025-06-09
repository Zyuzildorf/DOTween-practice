using DG.Tweening;
using UnityEngine.UI;

namespace Source.Scripts
{
    public class ChangeText : DOTweenAnimation
    {
        private Text _text;
        private Sequence _sequence;

        private void Awake()
        {
            _text = GetComponent<Text>();
            _sequence = DOTween.Sequence();
        }

        private void Start()
        {
            _sequence.Append(_text.DOText("Молочко", _duration));
            _sequence.Append(_text.DOText(" c грушей", _duration).SetRelative());
            _sequence.Append(_text.DOText("Плохое молочко", _duration, true, ScrambleMode.All));
            _sequence.SetLoops(_repeats, _loopType);
        }
    }
}