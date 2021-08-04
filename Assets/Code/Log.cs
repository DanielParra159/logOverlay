using System.Collections;
using System.Collections.Generic;
using Code;
using UnityEngine;
using UnityEngine.UI;

public class Log : MonoBehaviour
{
    [SerializeField] private Button _showButton;
    [SerializeField] private Button _closeButton;
    [SerializeField] private GameObject _canvas;
    [SerializeField] private LogLine _logLinePrefab;
    [SerializeField] private LogDetail _logDetail;
    [SerializeField] private RectTransform _parent;

    void Awake()
    {
        Application.logMessageReceived += HandleLog;
        _showButton.onClick.AddListener(() => _canvas.SetActive(true));
        _closeButton.onClick.AddListener(() => _canvas.SetActive(false));
    }

    void OnDestroy()
    {
        Application.logMessageReceived -= HandleLog;
    }

    void HandleLog(string logString, string stackTrace, LogType type)
    {
        var logLine = Instantiate(_logLinePrefab, _parent);
        logLine.Configure(new LogData(logString, stackTrace, type), OnLogClicked);
    }

    private void OnLogClicked(LogData logData)
    {
        _logDetail.Update(logData);
    }
}