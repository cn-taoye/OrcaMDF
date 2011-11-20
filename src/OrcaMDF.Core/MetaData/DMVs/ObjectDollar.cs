using System;
using System.Collections.Generic;
using System.Linq;
using OrcaMDF.Core.Engine;

namespace OrcaMDF.Core.MetaData.DMVs
{
	public class ObjectDollar : Row
	{
		public string Name { get { return Field<string>("Name"); } private set { this["Name"] = value; } }
		public int ObjectID { get { return Field<int>("ObjectID"); } private set { this["ObjectID"] = value; } }
		public int? PrincipalID { get { return Field<int?>("PrincipalID"); } private set { this["PrincipalID"] = value; } }
		public int SchemaID { get { return Field<int>("SchemaID"); } private set { this["SchemaID"] = value; } }
		public int ParentObjectID { get { return Field<int>("ParentObjectID"); } private set { this["ParentObjectID"] = value; } }
		public string Type { get { return Field<string>("Type"); } private set { this["Type"] = value; } }
		public string TypeDesc { get { return Field<string>("TypeDesc"); } private set { this["TypeDesc"] = value; } }
		public int Property { get { return Field<int>("Property"); } private set { this["Property"] = value; } }
		public DateTime CreateDate { get { return Field<DateTime>("CreateDate"); } private set { this["CreateDate"] = value; } }
		public DateTime ModifyDate { get { return Field<DateTime>("ModifyDate"); } private set { this["ModifyDate"] = value; } }
		public bool IsMSShipped { get { return Field<bool>("IsMSShipped"); } private set { this["IsMSShipped"] = value; } }
		public bool IsAutoDropped { get { return Field<bool>("IsAutoDropped"); } private set { this["IsAutoDropped"] = value; } }
		public bool IsSystemNamed { get { return Field<bool>("IsSystemNamed"); } private set { this["IsSystemNamed"] = value; } }
		public bool IsPublished { get { return Field<bool>("IsPublished"); } private set { this["IsPublished"] = value; } }
		public bool IsSchemaPublished { get { return Field<bool>("IsSchemaPublished"); } private set { this["IsSchemaPublished"] = value; } }
		public bool LockOnBulkLoad { get { return Field<bool>("LockOnBulkLoad"); } private set { this["LockOnBulkLoad"] = value; } }
		public bool IsDisabled { get { return Field<bool>("IsDisabled"); } private set { this["IsDisabled"] = value; } }
		public bool IsAutoExecuted { get { return Field<bool>("IsAutoExecuted"); } private set { this["IsAutoExecuted"] = value; } }
		public bool IsActivationEnabled { get { return Field<bool>("IsActivationEnabled"); } private set { this["IsActivationEnabled"] = value; } }
		public bool HasOpaqueMetadata { get { return Field<bool>("HasOpaqueMetadata"); } private set { this["HasOpaqueMetadata"] = value; } }
		public bool IsNotForReplication { get { return Field<bool>("IsNotForReplication"); } private set { this["IsNotForReplication"] = value; } }
		public bool IsReceiveEnabled { get { return Field<bool>("IsReceiveEnabled"); } private set { this["IsReceiveEnabled"] = value; } }
		public bool IsNotTrusted { get { return Field<bool>("IsNotTrusted"); } private set { this["IsNotTrusted"] = value; } }
		public bool IsEnqueueEnabled { get { return Field<bool>("IsEnqueueEnabled"); } private set { this["IsEnqueueEnabled"] = value; } }
		public bool WithCheckOption { get { return Field<bool>("WithCheckOption"); } private set { this["WithCheckOption"] = value; } }
		public bool IsRetentionEnabled { get { return Field<bool>("IsRetentionEnabled"); } private set { this["IsRetentionEnabled"] = value; } }
		public bool HasUncheckedAssemblyData { get { return Field<bool>("HasUncheckedAssemblyData"); } private set { this["HasUncheckedAssemblyData"] = value; } }
		public byte UpdateReferentialAction { get { return Field<byte>("UpdateReferentialAction"); } private set { this["UpdateReferentialAction"] = value; } }
		public byte DeleteReferentialAction { get { return Field<byte>("DeleteReferentialAction"); } private set { this["DeleteReferentialAction"] = value; } }
		public bool IsReplicated { get { return Field<bool>("IsReplicated"); } private set { this["IsReplicated"] = value; } }
		public bool IsExecutionReplicated { get { return Field<bool>("IsExecutionReplicated"); } private set { this["IsExecutionReplicated"] = value; } }
		public bool HasReplicationFilter { get { return Field<bool>("HasReplicationFilter"); } private set { this["HasReplicationFilter"] = value; } }
		public bool IsReplSerializableOnly { get { return Field<bool>("IsReplSerializableOnly"); } private set { this["IsReplSerializableOnly"] = value; } }
		public bool IsMergePublished { get { return Field<bool>("IsMergePublished"); } private set { this["IsMergePublished"] = value; } }
		public bool SkipsReplConstraints { get { return Field<bool>("SkipsReplConstraints"); } private set { this["SkipsReplConstraints"] = value; } }
		public bool IsSyncTranSubscribed { get { return Field<bool>("IsSyncTranSubscribed"); } private set { this["IsSyncTranSubscribed"] = value; } }
		public bool UsesAnsiNulls { get { return Field<bool>("UsesAnsiNulls"); } private set { this["UsesAnsiNulls"] = value; } }
		public bool NullOnNullInput { get { return Field<bool>("NullOnNullInput"); } private set { this["NullOnNullInput"] = value; } }
		public bool UsesDatabaseCollation { get { return Field<bool>("UsesDatabaseCollation"); } private set { this["UsesDatabaseCollation"] = value; } }
		public bool IsTrackedByCdc { get { return Field<bool>("IsTrackedByCdc"); } private set { this["IsTrackedByCdc"] = value; } }
		public bool LargeValueTypesOutOfRow { get { return Field<bool>("LargeValueTypesOutOfRow"); } private set { this["LargeValueTypesOutOfRow"] = value; } }
		public byte LockEscalationOption { get { return Field<byte>("LockEscalationOption"); } private set { this["LockEscalationOption"] = value; } }
		public bool IsPoisonMessageHandlingEnabled { get { return Field<bool>("IsPoisonMessageHandlingEnabled"); } private set { this["IsPoisonMessageHandlingEnabled"] = value; } }

		public ObjectDollar()
		{
			Columns.Add(new DataColumn("Name", "sysname"));
			Columns.Add(new DataColumn("ObjectID", "int"));
			Columns.Add(new DataColumn("PrincipalID", "int", true));
			Columns.Add(new DataColumn("SchemaID", "int"));
			Columns.Add(new DataColumn("ParentObjectID", "int"));
			Columns.Add(new DataColumn("Type", "char(2)"));
			Columns.Add(new DataColumn("TypeDesc", "nvarchar", true));
			Columns.Add(new DataColumn("Property", "int"));
			Columns.Add(new DataColumn("CreateDate", "datetime"));
			Columns.Add(new DataColumn("ModifyDate", "datetime"));
			Columns.Add(new DataColumn("IsMSShipped", "bit"));
			Columns.Add(new DataColumn("IsAutoDropped", "bit"));
			Columns.Add(new DataColumn("IsSystemNamed", "bit"));
			Columns.Add(new DataColumn("IsPublished", "bit"));
			Columns.Add(new DataColumn("IsSchemaPublished", "bit"));
			Columns.Add(new DataColumn("LockOnBulkLoad", "bit"));
			Columns.Add(new DataColumn("IsDisabled", "bit"));
			Columns.Add(new DataColumn("IsAutoExecuted", "bit"));
			Columns.Add(new DataColumn("IsActivationEnabled", "bit"));
			Columns.Add(new DataColumn("HasOpaqueMetadata", "bit"));
			Columns.Add(new DataColumn("IsNotForReplication", "bit"));
			Columns.Add(new DataColumn("IsReceiveEnabled", "bit"));
			Columns.Add(new DataColumn("IsNotTrusted", "bit"));
			Columns.Add(new DataColumn("IsEnqueueEnabled", "bit"));
			Columns.Add(new DataColumn("WithCheckOption", "bit"));
			Columns.Add(new DataColumn("IsRetentionEnabled", "bit"));
			Columns.Add(new DataColumn("HasUncheckedAssemblyData", "bit"));
			Columns.Add(new DataColumn("UpdateReferentialAction", "tinyint"));
			Columns.Add(new DataColumn("DeleteReferentialAction", "tinyint"));
			Columns.Add(new DataColumn("IsReplicated", "bit"));
			Columns.Add(new DataColumn("IsExecutionReplicated", "bit"));
			Columns.Add(new DataColumn("HasReplicationFilter", "bit"));
			Columns.Add(new DataColumn("IsReplSerializableOnly", "bit"));
			Columns.Add(new DataColumn("IsMergePublished", "bit"));
			Columns.Add(new DataColumn("SkipsReplConstraints", "bit"));
			Columns.Add(new DataColumn("IsSyncTranSubscribed", "bit"));
			Columns.Add(new DataColumn("UsesAnsiNulls", "bit"));
			Columns.Add(new DataColumn("NullOnNullInput", "bit"));
			Columns.Add(new DataColumn("UsesDatabaseCollation", "bit"));
			Columns.Add(new DataColumn("IsTrackedByCdc", "bit"));
			Columns.Add(new DataColumn("LargeValueTypesOutOfRow", "bit"));
			Columns.Add(new DataColumn("LockEscalationOption", "tinyint"));
			Columns.Add(new DataColumn("IsPoisonMessageHandlingEnabled", "bit"));
		}

		public override Row NewRow()
		{
			return new ObjectDollar();
		}

		internal static IEnumerable<ObjectDollar> GetDmvData(Database db)
		{
			return db.BaseTables.sysschobjs
				.Where(o => o.nsclass == 0 && o.pclass == 1)
				.Select(o => new ObjectDollar
					{
						Name = o.name,
						ObjectID = o.id,
						PrincipalID = db.BaseTables.syssingleobjrefs
							.Where(r => r.depid == o.id && r.@class == 97 && r.depsubid == 0)
							.Select(r => r.indepid)
							.SingleOrDefault(),
						SchemaID = o.nsid,
						ParentObjectID = o.pid,
						Type = o.type.Trim(),
						TypeDesc = db.BaseTables.syspalnames
							.Where(n => n.@class == "OBTY" && n.value.Trim() == o.type.Trim())
							.Select(n => n.name)
							.Single(),
						Property = o.intprop,
						CreateDate = o.created,
						ModifyDate = o.modified,
						IsMSShipped = Convert.ToBoolean(o.status & 1),
						IsAutoDropped = Convert.ToBoolean(o.status & 2),
						IsSystemNamed = Convert.ToBoolean(o.status & 4),
						IsPublished = Convert.ToBoolean(o.status & 16),
						IsSchemaPublished = Convert.ToBoolean(o.status & 64),
						LockOnBulkLoad = Convert.ToBoolean(o.status & 256),
						IsDisabled = Convert.ToBoolean(o.status & 256),
						IsAutoExecuted = Convert.ToBoolean(o.status & 256),
						IsActivationEnabled = Convert.ToBoolean(o.status & 256),
						HasOpaqueMetadata = Convert.ToBoolean(o.status & 512),
						IsNotForReplication = Convert.ToBoolean(o.status & 512),
						IsReceiveEnabled = Convert.ToBoolean(o.status & 512),
						IsNotTrusted = Convert.ToBoolean(o.status & 1024),
						IsEnqueueEnabled = Convert.ToBoolean(o.status & 1024),
						WithCheckOption = Convert.ToBoolean(o.status & 1024),
						IsRetentionEnabled = Convert.ToBoolean(o.status & 2048),
						HasUncheckedAssemblyData = Convert.ToBoolean(o.status & 2048),
						UpdateReferentialAction = Convert.ToByte((o.status / 4096) & 3),
						DeleteReferentialAction = Convert.ToByte((o.status / 16384) & 3),
						IsReplicated = Convert.ToBoolean(o.status & 0x1000),
						IsExecutionReplicated = Convert.ToBoolean(o.status & 0x1000),
						HasReplicationFilter = Convert.ToBoolean(o.status & 0x2000),
						IsReplSerializableOnly = Convert.ToBoolean(o.status & 0x2000),
						IsMergePublished = Convert.ToBoolean(o.status & 0x4000),
						SkipsReplConstraints = Convert.ToBoolean(o.status & 0x4000),
						IsSyncTranSubscribed = Convert.ToBoolean(o.status & 0x8000),
						UsesAnsiNulls = Convert.ToBoolean(o.status & 0x40000),
						NullOnNullInput = Convert.ToBoolean(o.status & 0x200000),
						UsesDatabaseCollation = Convert.ToBoolean(o.status & 0x100000),
						IsTrackedByCdc = Convert.ToBoolean(o.status & 0x01000000),
						LargeValueTypesOutOfRow = Convert.ToBoolean(o.status & 0x02000000),
						LockEscalationOption = Convert.ToByte((o.status & 0x30000000) / 0x10000000),
						IsPoisonMessageHandlingEnabled = Convert.ToBoolean(o.status & 0x04000000)
					});
		}
	}
}