//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Datetime:2013-01-04T12:21:55
//     Runtime Version:4.0.0.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Landsbanki.Framework.Database.Micro;

namespace MyNamespace
{
	[TableName("sr.sr_dependency")]
	[PrimaryKey("id_dependency", autoIncrement = true)]
	public partial class SrDependency
	{
		[Column("id_dependency")]
		public decimal IdDependency { get; set; }
		[Column("id_software_item_from")]
		public decimal IdSoftwareItemFrom { get; set; }
		[Column("id_software_item_to")]
		public decimal IdSoftwareItemTo { get; set; }
		[Column("source")]
		public int Source { get; set; }
		[Column("type")]
		public int Type { get; set; }
	}
}

