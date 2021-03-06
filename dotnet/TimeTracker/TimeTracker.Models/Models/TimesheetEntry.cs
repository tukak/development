﻿using System;

namespace RFI.TimeTracker.Models
{
    public class TimesheetEntry : BaseNotifyObject
    {
        private DateTime? _workStart;
        private DateTime? _workEnd;
        private DateTime? _lunchBreakStart;
        private DateTime? _lunchBreakEnd;
        private string _note;

        public DateTime? WorkStart
        {
            get { return _workStart; }
            set
            {
                SetPropertyValue(ref _workStart, value);
                OnPropertyChanged("WorkTime");
            }
        }

        public DateTime? WorkEnd
        {
            get { return _workEnd; }
            set
            {
                SetPropertyValue(ref _workEnd, value);
                OnPropertyChanged("WorkTime");
            }
        }

        public DateTime? LunchBreakStart
        {
            get { return _lunchBreakStart; }
            set
            {
                SetPropertyValue(ref _lunchBreakStart, value);
                OnPropertyChanged("WorkTime");
            }
        }

        public DateTime? LunchBreakEnd
        {
            get { return _lunchBreakEnd; }
            set
            {
                SetPropertyValue(ref _lunchBreakEnd, value);
                OnPropertyChanged("WorkTime");
            }
        }

        public string Note
        {
            get { return _note; }
            set { SetPropertyValue(ref _note, value); }
        }

        public TimeSpan? WorkTime
        {
            get
            {
                var workTime = WorkEnd - WorkStart;
                var lunchBreakTime = LunchBreakEnd - LunchBreakStart;
                return workTime - (lunchBreakTime ?? new TimeSpan());
            }
        }
    }
}
