//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Datetime:2013-06-02T14:37:37
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
using PetaPoco;

namespace Knightrunner.WorkTrack2013.Database.Entities
{
	[TableName(_Names._Table)]
	[PrimaryKey(_Names.Id, autoIncrement = true)]
	public partial class User
	{
		public static class _Names
		{
			public const string _Table = "dbo.Users";
			public const string Id = "Id";
			public const string PublicId = "PublicId";
			public const string Active = "Active";
		}

		[Column(_Names.Id)]
		public long Id { get; set; }
		[Column(_Names.PublicId)]
		public string PublicId { get; set; }
		[Column(_Names.Active)]
		public bool Active { get; set; }
	}
}

