using System;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Code
{
    internal class LogLine : MonoBehaviour
    {
        [Serializable]
        private class TypeColor
        {
            [SerializeField] private LogType _type;
            [SerializeField] private Color _color;

            public LogType Type => _type;
            public Color Color => _color;
        }

        [SerializeField] private TypeColor[] _typeColors;
        [SerializeField] private Image _image;
        [SerializeField] private TextMeshProUGUI _message;
        [SerializeField] private Button _button;

        public void Configure(LogData logData, Action<LogData> onButtonClicked)
        {
            _image.color = _typeColors.First(typeColor => typeColor.Type.Equals(logData.Type)).Color;
            _message.SetText(logData.LogString);

            _button.onClick.AddListener(() => onButtonClicked?.Invoke(logData));
        }
    }
}