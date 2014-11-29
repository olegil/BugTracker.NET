﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace btnet
{
    public class BtnetClaimTypes
    {
        public const string UserId = "us_id";
        public const string OrganizationId = "us_org";
        public const string BugsPerPage = "us_bugs_per_page";
        public const string CanOnlySeeOwnReportedBugs = "og_can_only_see_own_reported";
        public const string OtherOrgsPermissionLevel = "og_other_orgs_permission_level";
    }
}