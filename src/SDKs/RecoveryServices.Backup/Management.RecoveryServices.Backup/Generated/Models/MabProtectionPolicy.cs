// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// Mab container-specific backup policy.
    /// </summary>
    [Newtonsoft.Json.JsonObject("MAB")]
    public partial class MabProtectionPolicy : ProtectionPolicy
    {
        /// <summary>
        /// Initializes a new instance of the MabProtectionPolicy class.
        /// </summary>
        public MabProtectionPolicy() { }

        /// <summary>
        /// Initializes a new instance of the MabProtectionPolicy class.
        /// </summary>
        /// <param name="protectedItemsCount">Number of items associated with
        /// this policy.</param>
        /// <param name="schedulePolicy">Backup schedule of backup
        /// policy.</param>
        /// <param name="retentionPolicy">Retention policy details.</param>
        public MabProtectionPolicy(int? protectedItemsCount = default(int?), SchedulePolicy schedulePolicy = default(SchedulePolicy), RetentionPolicy retentionPolicy = default(RetentionPolicy))
            : base(protectedItemsCount)
        {
            SchedulePolicy = schedulePolicy;
            RetentionPolicy = retentionPolicy;
        }

        /// <summary>
        /// Gets or sets backup schedule of backup policy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "schedulePolicy")]
        public SchedulePolicy SchedulePolicy { get; set; }

        /// <summary>
        /// Gets or sets retention policy details.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "retentionPolicy")]
        public RetentionPolicy RetentionPolicy { get; set; }

    }
}
