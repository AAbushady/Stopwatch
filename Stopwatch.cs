using System;

namespace Stopwatch
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private TimeSpan _duration;
        private bool _isOn;

        public void Start()
        {
            if (_isOn)
            {
                throw new InvalidOperationException("Stopwatch can only be started once and must be stopped before reusing.");
            }

            _isOn = true;
            _startTime = DateTime.Now;
        }

        public string Stop()
        {
            _isOn = false;

            _endTime = DateTime.Now;

            _duration = _endTime - _startTime;

            return $"{_duration.Hours:00}:{_duration.Minutes:00}:{_duration.Seconds:00}";
        }
    }
}