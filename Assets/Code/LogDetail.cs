using System;
using System.Collections;
using Code;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

internal class LogDetail : MonoBehaviour
{
    [SerializeField] private ScrollRect _scrollRect;
    [SerializeField] private TextMeshProUGUI _message;
    [SerializeField] private Button _copyButton;
    private LogData _currentLogData;

    private void Awake()
    {
        _copyButton.onClick.AddListener(CopyText);
    }

    private void CopyText()
    {
        GUIUtility.systemCopyBuffer = _message.text;
    }

    public void Update(LogData logData)
    {
        _currentLogData = logData;
        _message.SetText(logData.StackTrace);
        StartCoroutine(SetScrollbarToTop());
    }

    private IEnumerator SetScrollbarToTop()
    {
        yield return null;
        yield return null;
        _scrollRect.verticalScrollbar.value = 1f;
    }
}