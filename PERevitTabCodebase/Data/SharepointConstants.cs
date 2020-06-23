﻿#region autodesk libraries
using Autodesk.Revit.DB;
#endregion

#region system libraries
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace PERevitTab.Data
{
    public class SharepointConstants
    {
        public static class Cache
        {
            public static string username { get; set; }
            public static SecureString password { get; set; }
        }
        public static class Links
        {
            public static string siteUrl = @"https://perkinseastman.sharepoint.com/sites/Grove";
            public static string spReadList = @"cp_published_volumes";
            public static string spWriteList = @"cp_revit_volumes";
            public static string userListName = @"translatedUser";
            public static string projectListName = @"projects";
            public static string projectPermissionsListName = @"cp_project_permissions";
            public static string allItems = "All Items";
        }

        public enum ColumnHeaders
        {
            org1_Title,
            org1_abbreviation,
            org1_sort_id,
            org1_volume_sort,
            org2_Title,
            org2_abbreviation,
            org2_sort_id,
            org2_volume_sort,
            org3_Title,
            org3_abbreviation,
            org3_sort_id,
            org3_volume_sort,
            org4_Title,
            org4_abbreviation,
            org4_sort_id,
            org4_volume_sort,
            org5_Title,
            org5_abbreviation,
            org5_sort_id,
            org5_volume_sort,
            org6_Title,
            org6_abbreviation,
            org6_sort_id,
            org6_volume_sort,
            org7_Title,
            org7_abbreviation,
            org7_sort_id,
            org7_volume_sort,
            vif_id,
            is_depreciated,
            pe_standard_Title,
            leed_standard_Title,
            ibc_standard_Title,
            gross_factor,
            area_net,
            count_occupant_capacity,
            count_occupant_non_capacity,
            count_volume_capacity,
            count_volume_non_capacity,
            phase_created_Title,
            phase_demolished_Title,
            vol_abbreviation,
            vol_sort_id,
            vol_sorted,
            vol_volume_sort,
        }
        public static class Dictionaries
        {
            public static Dictionary<string, ParameterType> newRevitRoomParameters = new Dictionary<string, ParameterType>
            {
                { "org1_Title", ParameterType.Text },
                { "org1_abbreviation", ParameterType.Text },
                { "org1_sort_id", ParameterType.Integer },
                { "org1_volume_sort", ParameterType.Text },
                { "org2_Title", ParameterType.Text },
                { "org2_abbreviation", ParameterType.Text },
                { "org2_sort_id", ParameterType.Integer },
                { "org2_volume_sort", ParameterType.Text },
                { "org3_Title", ParameterType.Text },
                { "org3_abbreviation", ParameterType.Text },
                { "org3_sort_id", ParameterType.Integer },
                { "org3_volume_sort", ParameterType.Text },
                { "org4_Title", ParameterType.Text },
                { "org4_abbreviation", ParameterType.Text },
                { "org4_sort_id", ParameterType.Integer },
                { "org4_volume_sort", ParameterType.Text },
                { "org5_Title", ParameterType.Text },
                { "org5_abbreviation", ParameterType.Text },
                { "org5_sort_id", ParameterType.Integer },
                { "org5_volume_sort", ParameterType.Text },
                { "org6_Title", ParameterType.Text },
                { "org6_abbreviation", ParameterType.Text },
                { "org6_sort_id", ParameterType.Integer },
                { "org6_volume_sort", ParameterType.Text },
                { "org7_Title", ParameterType.Text },
                { "org7_abbreviation", ParameterType.Text },
                { "org7_sort_id", ParameterType.Integer },
                { "org7_volume_sort", ParameterType.Text },
                { "vif_id", ParameterType.Text },
                { "is_depreciated", ParameterType.YesNo },
                { "pe_standard_Title", ParameterType.Text },
                { "leed_standard_Title", ParameterType.Text },
                { "ibc_standard_Title", ParameterType.Text },
                { "gross_factor", ParameterType.Number },
                { "area_net", ParameterType.Number },
                { "count_occupant_capacity", ParameterType.Integer },
                { "count_occupant_non_capacity", ParameterType.Integer },
                { "count_volume_capacity", ParameterType.Integer },
                { "count_volume_non_capacity", ParameterType.Integer },
                { "phase_created_Title", ParameterType.Text },
                { "phase_demolished_Title", ParameterType.Text },
                { "vol_abbreviation", ParameterType.Text },
                { "vol_sort_id", ParameterType.Integer },
                { "vol_sorted", ParameterType.Text },
                { "vol_volume_sort", ParameterType.Text },
            };
        }
    }
}
