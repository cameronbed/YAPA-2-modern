﻿using System;
using System.ComponentModel;

namespace YAPA.Contracts
{
    public interface IPomodoroEngine : INotifyPropertyChanged
    {
        int Index { get; }
        PomodoroPhase Phase { get; }
        int Elapsed { get; }
        int WorkTime { get; }
        int BreakTime { get; }

        event Func<bool> OnStarting;
        event Action OnStarted;
        event Action OnStopped;

        void Start();
        void Stop();
        void Reset();

        bool IsRunning { get; }
    }

    public enum PomodoroPhase
    {
        NotStarted,
        Work,
        WorkEnded,
        Break,
        BreakEnded
    }
}
