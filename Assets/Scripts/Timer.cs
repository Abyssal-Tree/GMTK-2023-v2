using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private float duration;

    [SerializeField] private TextMeshProUGUI timer;
    private float startT;
    private void Start()
    {
        startT = Time.time;
    }

    private void Update()
    {
        var t = duration - Time.time - startT;
        timer.text = t <= 0 ? "Victory" : Mathf.RoundToInt(t).ToString();
    }
}
