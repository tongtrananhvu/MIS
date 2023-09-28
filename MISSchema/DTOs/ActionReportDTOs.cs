using System;
namespace MISSchema.DTOs
{
	public class ActionReportDTOs
	{
        /// <summary>
        /// Action :
        ///		value:
        ///			+ get : export report result
        ///		    + create : create data report
        ///		    + author : authorized data report
        /// param : parameters
        ///			value : <key,value>
        /// ExportType : type file export
        ///		value:
        ///			+ xls : excel 97 file
        ///			+ xlsx : excel 2000
        ///			+ pdf : pdf file
        ///			+ csv
        /// </summary>
        public required string Serviceid { get; set; }
		public required string Reportid { get; set; }
		public string Task { get; set; } = "get";
		public Dictionary<string,object>? Param;
        public string? ExportType { get; set; } = "csv";
    }
}

