using System;
using System.Collections.Generic;
using System.Linq;
using OrcaMDF.Core.Engine;

namespace OrcaMDF.Core.MetaData.DMVs
{
	public class ForeignKey : Row
	{
		public string Name { get { return Field<string>("Name"); } private set { this["Name"] = value; } }
		public int ObjectID { get { return Field<int>("ObjectID"); } private set { this["ObjectID"] = value; } }
		public int? PrincipalID { get { return Field<int?>("PrincipalID"); } private set { this["PrincipalID"] = value; } }
		public int SchemaID { get { return Field<int>("SchemaID"); } private set { this["SchemaID"] = value; } }
		public int ParentObjectID { get { return Field<int>("ParentObjectID"); } private set { this["ParentObjectID"] = value; } }
		public string Type { get { return Field<string>("Type"); } private set { this["Type"] = value; } }
		public string TypeDesc { get { return Field<string>("TypeDesc"); } private set { this["TypeDesc"] = value; } }
		public DateTime CreateDate { get { return Field<DateTime>("CreateDate"); } private set { this["CreateDate"] = value; } }
		public DateTime ModifyDate { get { return Field<DateTime>("ModifyDate"); } private set { this["ModifyDate"] = value; } }
		public bool IsMSShipped { get { return Field<bool>("IsMSShipped"); } private set { this["IsMSShipped"] = value; } }
		public bool IsPublished { get { return Field<bool>("IsPublished"); } private set { this["IsPublished"] = value; } }
		public bool IsSchemaPublished { get { return Field<bool>("IsSchemaPublished"); } private set { this["IsSchemaPublished"] = value; } }
		public int? ReferencedObjectID { get { return Field<int?>("ReferencedObjectID"); } private set { this["ReferencedObjectID"] = value; } }
		public int? KeyIndexID { get { return Field<int?>("KeyIndexID"); } private set { this["KeyIndexID"] = value; } }
		public bool IsDisabled { get { return Field<bool>("IsDisabled"); } private set { this["IsDisabled"] = value; } }
		public bool IsNotForReplication { get { return Field<bool>("IsNotForReplication"); } private set { this["IsNotForReplication"] = value; } }
		public bool IsNotTrusted { get { return Field<bool>("IsNotTrusted"); } private set { this["IsNotTrusted"] = value; } }
		public byte? DeleteReferentialAction { get { return Field<byte?>("DeleteReferentialAction"); } private set { this["DeleteReferentialAction"] = value; } }
		public string DeleteReferentialActionDesc { get { return Field<string>("DeleteReferentialActionDesc"); } private set { this["DeleteReferentialActionDesc"] = value; } }
		public byte? UpdateReferentialAction { get { return Field<byte?>("UpdateReferentialAction"); } private set { this["UpdateReferentialAction"] = value; } }
		public string UpdateReferentialActionDesc { get { return Field<string>("UpdateReferentialActionDesc"); } private set { this["UpdateReferentialActionDesc"] = value; } }
		public bool IsSystemNamed { get { return Field<bool>("IsSystemNamed"); } private set { this["IsSystemNamed"] = value; } }

		public ForeignKey()
		{
			Columns.Add(new DataColumn("Name", "sysname"));
			Columns.Add(new DataColumn("ObjectID", "int"));
			Columns.Add(new DataColumn("PrincipalID", "int", true));
			Columns.Add(new DataColumn("SchemaID", "int"));
			Columns.Add(new DataColumn("ParentObjectID", "int"));
			Columns.Add(new DataColumn("Type", "char(2)"));
			Columns.Add(new DataColumn("TypeDesc", "nvarchar", true));
			Columns.Add(new DataColumn("CreateDate", "datetime"));
			Columns.Add(new DataColumn("ModifyDate", "datetime"));
			Columns.Add(new DataColumn("IsMSShipped", "bit"));
			Columns.Add(new DataColumn("IsPublished", "bit"));
			Columns.Add(new DataColumn("IsSchemaPublished", "bit"));
			Columns.Add(new DataColumn("ReferencedObjectID", "int", true));
			Columns.Add(new DataColumn("KeyIndexID", "int", true));
			Columns.Add(new DataColumn("IsDisabled", "bit"));
			Columns.Add(new DataColumn("IsNotForReplication", "bit"));
			Columns.Add(new DataColumn("IsNotTrusted", "bit"));
			Columns.Add(new DataColumn("DeleteReferentialAction", "tinyint", true));
			Columns.Add(new DataColumn("DeleteReferentialActionDesc", "nvarchar", true));
			Columns.Add(new DataColumn("UpdateReferentialAction", "tinyint", true));
			Columns.Add(new DataColumn("UpdateReferentialActionDesc", "nvarchar", true));
			Columns.Add(new DataColumn("IsSystemNamed", "bit"));
		}

		public override Row NewRow()
		{
			return new ForeignKey();
		}

		internal static IEnumerable<ForeignKey> GetDmvData(Database db)
		{
			return db.Dmvs.ObjectsDollar
				.Where(o => o.Type == "F")
				.Select(o => new ForeignKey
				    {
						Name = o.Name,
						ObjectID = o.ObjectID,
						PrincipalID = o.PrincipalID,
						SchemaID = o.SchemaID,
						ParentObjectID = o.ParentObjectID,
						Type = o.Type,
						TypeDesc = o.TypeDesc,
						CreateDate = o.CreateDate,
						ModifyDate = o.ModifyDate,
						IsMSShipped = o.IsMSShipped,
						IsPublished = o.IsPublished,
						IsSchemaPublished = o.IsSchemaPublished,
						ReferencedObjectID = db.BaseTables.syssingleobjrefs
							.Where(f => f.depid == o.ObjectID && f.@class == 27 && f.depsubid == 0)
							.Select(f => f.indepid)
							.Single(),
						KeyIndexID= db.BaseTables.syssingleobjrefs
							.Where(f => f.depid == o.ObjectID && f.@class == 27 && f.depsubid == 0)
							.Select(f => f.indepsubid)
							.Single(),
						IsDisabled = o.IsDisabled,
						IsNotForReplication = o.IsNotForReplication,
						IsNotTrusted = o.IsNotTrusted,
						DeleteReferentialAction = o.DeleteReferentialAction,
						DeleteReferentialActionDesc = db.BaseTables.syspalvalues
							.Where(d => d.@class == "FKRA" && d.value == o.DeleteReferentialAction)
							.Select(d => d.name)
							.Single(),
						UpdateReferentialAction = o.UpdateReferentialAction,
						UpdateReferentialActionDesc = db.BaseTables.syspalvalues
							.Where(u => u.@class == "FKRA" && u.value == o.UpdateReferentialAction)
							.Select(u => u.name)
							.Single(),
						IsSystemNamed = o.IsSystemNamed
				    });
		}
	}
}