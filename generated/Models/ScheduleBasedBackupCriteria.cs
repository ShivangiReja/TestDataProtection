// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace DataProtectionPlugin.Models
{
    /// <summary>
    /// This is for scheduled backups where criteria is schedule based
    ///                  /// Example of supported identifiers:
    ///              1.  Every Sunday/Monday
    ///                  DaysOfWeeks : Sunday/Monday
    ///             
    ///              2.  First/Second Sunday/Tuesday of the Month
    ///                  WeekOfMonth : First/Second
    ///                  DaysOfWeek : Sunday/Tuesday
    ///             
    ///              3.  1st/2nd day of month
    ///                  DaysOfMonth : 1/2
    ///             
    ///              4. First Sunday of January
    ///                  WeekOfMonth : First/Second
    ///                  DaysOfWeek : Sunday/Tuesday
    ///                  MonthsOfYear : Jan
    ///             
    ///              5. 1st/2nd January
    ///                  DaysOfMonth : 1/2
    ///                  MonthsOfYear : Jan
    ///             
    ///              6. First SuccessFull of Week
    ///                 AbsoluteIdentifier : FirstOfWeek
    /// </summary>
    public partial class ScheduleBasedBackupCriteria : BackupCriteria
    {
        /// <summary> Initializes a new instance of ScheduleBasedBackupCriteria. </summary>
        public ScheduleBasedBackupCriteria()
        {
            AbsoluteCriteria = new ChangeTrackingList<AbsoluteMarker>();
            ScheduleTimes = new ChangeTrackingList<DateTimeOffset>();
            DaysOfMonth = new ChangeTrackingList<Day>();
            WeeksOfTheMonth = new ChangeTrackingList<WeekNumber>();
            DaysOfTheWeek = new ChangeTrackingList<DayOfWeek>();
            MonthsOfYear = new ChangeTrackingList<Month>();
            ObjectType = "ScheduleBasedBackupCriteria";
        }

        /// <summary> Initializes a new instance of ScheduleBasedBackupCriteria. </summary>
        /// <param name="objectType"> Type of the specific object - used for deserializing. </param>
        /// <param name="absoluteCriteria">
        /// it contains absolute values like &quot;AllBackup&quot; / &quot;FirstOfDay&quot; / &quot;FirstOfWeek&quot; / &quot;FirstOfMonth&quot;
        ///             and should be part of AbsoluteMarker enum
        /// </param>
        /// <param name="scheduleTimes"> List of schedule times for backup. </param>
        /// <param name="daysOfMonth"> This is day of the month from 1 to 28 other wise last of month. </param>
        /// <param name="weeksOfTheMonth"> It should be First/Second/Third/Fourth/Last. </param>
        /// <param name="daysOfTheWeek"> It should be Sunday/Monday/T..../Saturday. </param>
        /// <param name="monthsOfYear"> It should be January/February/....../December. </param>
        internal ScheduleBasedBackupCriteria(string objectType, IList<AbsoluteMarker> absoluteCriteria, IList<DateTimeOffset> scheduleTimes, IList<Day> daysOfMonth, IList<WeekNumber> weeksOfTheMonth, IList<DayOfWeek> daysOfTheWeek, IList<Month> monthsOfYear) : base(objectType)
        {
            AbsoluteCriteria = absoluteCriteria;
            ScheduleTimes = scheduleTimes;
            DaysOfMonth = daysOfMonth;
            WeeksOfTheMonth = weeksOfTheMonth;
            DaysOfTheWeek = daysOfTheWeek;
            MonthsOfYear = monthsOfYear;
            ObjectType = objectType ?? "ScheduleBasedBackupCriteria";
        }

        /// <summary>
        /// it contains absolute values like &quot;AllBackup&quot; / &quot;FirstOfDay&quot; / &quot;FirstOfWeek&quot; / &quot;FirstOfMonth&quot;
        ///             and should be part of AbsoluteMarker enum
        /// </summary>
        public IList<AbsoluteMarker> AbsoluteCriteria { get; }
        /// <summary> List of schedule times for backup. </summary>
        public IList<DateTimeOffset> ScheduleTimes { get; }
        /// <summary> This is day of the month from 1 to 28 other wise last of month. </summary>
        public IList<Day> DaysOfMonth { get; }
        /// <summary> It should be First/Second/Third/Fourth/Last. </summary>
        public IList<WeekNumber> WeeksOfTheMonth { get; }
        /// <summary> It should be Sunday/Monday/T..../Saturday. </summary>
        public IList<DayOfWeek> DaysOfTheWeek { get; }
        /// <summary> It should be January/February/....../December. </summary>
        public IList<Month> MonthsOfYear { get; }
    }
}
