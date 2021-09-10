// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Scheduler.Models
{
    /// <summary> The JobProperties. </summary>
    public partial class JobProperties
    {
        /// <summary> Initializes a new instance of JobProperties. </summary>
        public JobProperties()
        {
        }

        /// <summary> Initializes a new instance of JobProperties. </summary>
        /// <param name="startTime"> Gets or sets the job start time. </param>
        /// <param name="action"> Gets or sets the job action. </param>
        /// <param name="recurrence"> Gets or sets the job recurrence. </param>
        /// <param name="state"> Gets or set the job state. </param>
        /// <param name="status"> Gets the job status. </param>
        internal JobProperties(DateTimeOffset? startTime, JobAction action, JobRecurrence recurrence, JobState? state, JobStatus status)
        {
            StartTime = startTime;
            Action = action;
            Recurrence = recurrence;
            State = state;
            Status = status;
        }

        /// <summary> Gets or sets the job start time. </summary>
        public DateTimeOffset? StartTime { get; set; }
        /// <summary> Gets or sets the job action. </summary>
        public JobAction Action { get; set; }
        /// <summary> Gets or sets the job recurrence. </summary>
        public JobRecurrence Recurrence { get; set; }
        /// <summary> Gets or set the job state. </summary>
        public JobState? State { get; set; }
        /// <summary> Gets the job status. </summary>
        public JobStatus Status { get; }
    }
}
