using DG.Tweening;
using UnityEngine.UI;

namespace Source.Scripts
{
    public class TextChanger : DOTweenAnimation
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
            _sequence.Append(_text.DOText("Молочко", Duration));
            _sequence.Append(_text.DOText(" c грушей", Duration).SetRelative());
            _sequence.Append(_text.DOText("Плохое молочко", Duration, true, ScrambleMode.All));
            _sequence.SetLoops(Repeats, LoopType);
        }
    }
}