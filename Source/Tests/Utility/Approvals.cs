﻿#region Copyright 2014 Exceptionless

// This program is free software: you can redistribute it and/or modify it 
// under the terms of the GNU Affero General Public License as published 
// by the Free Software Foundation, either version 3 of the License, or 
// (at your option) any later version.
// 
//     http://www.gnu.org/licenses/agpl-3.0.html

#endregion

using System;
using ApprovalTests;
using ApprovalTests.Reporters;
using ApprovalTests.Writers;

namespace Exceptionless.Tests.Utility {
    public static class ApprovalsUtility {
        public static void VerifyFile(string approvedFilePath, object receivedData) {
            Approvals.Verify(new ConfigurableTempTextFileWriter(approvedFilePath, "" + receivedData));
        }
    }

    public class SmartReporter : FirstWorkingReporter {
        public SmartReporter() : base(BeyondCompareReporter.INSTANCE, NUnitReporter.INSTANCE) {}
    }
}