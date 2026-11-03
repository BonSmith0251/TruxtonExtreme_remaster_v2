namespace System.Data;

[Token(Token = "0x200005A")]
internal sealed class AggregateNode : ExpressionNode
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001B6")]
	private readonly AggregateType _type; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40001B7")]
	private readonly Aggregate _aggregate; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001B8")]
	private readonly bool _local; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001B9")]
	private readonly string _relationName; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001BA")]
	private readonly string _columnName; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001BB")]
	private DataTable _childTable; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001BC")]
	private DataColumn _column; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001BD")]
	private DataRelation _relation; //Field offset: 0x48

	[Address(RVA = "0x232B5A0", Offset = "0x232A9A0", Length = "0x1F")]
	[Token(Token = "0x600054A")]
	internal AggregateNode(DataTable table, FunctionId aggregateType, string columnName) { }

	[Address(RVA = "0x232B460", Offset = "0x232A860", Length = "0x13A")]
	[Token(Token = "0x600054B")]
	internal AggregateNode(DataTable table, FunctionId aggregateType, string columnName, bool local, string relationName) { }

	[Address(RVA = "0x232AAD0", Offset = "0x2329ED0", Length = "0x3DF")]
	[Token(Token = "0x600054C")]
	internal virtual void Bind(DataTable table, List<DataColumn> list) { }

	[Address(RVA = "0x232AEB0", Offset = "0x232A2B0", Length = "0x150")]
	[Token(Token = "0x600054D")]
	internal static void Bind(DataRelation relation, List<DataColumn> list) { }

	[Address(RVA = "0x232B010", Offset = "0x232A410", Length = "0x87")]
	[Token(Token = "0x6000555")]
	internal virtual bool DependsOn(DataColumn column) { }

	[Address(RVA = "0x230DA20", Offset = "0x230CE20", Length = "0x1C")]
	[Token(Token = "0x600054E")]
	internal virtual object Eval() { }

	[Address(RVA = "0x232B140", Offset = "0x232A540", Length = "0x30A")]
	[Token(Token = "0x600054F")]
	internal virtual object Eval(DataRow row, DataRowVersion version) { }

	[Address(RVA = "0x232B0A0", Offset = "0x232A4A0", Length = "0x99")]
	[Token(Token = "0x6000550")]
	internal virtual object Eval(Int32[] records) { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[Token(Token = "0x6000553")]
	internal virtual bool HasLocalAggregate() { }

	[Address(RVA = "0x232B450", Offset = "0x232A850", Length = "0x8")]
	[Token(Token = "0x6000554")]
	internal virtual bool HasRemoteAggregate() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000551")]
	internal virtual bool IsConstant() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[Token(Token = "0x6000552")]
	internal virtual bool IsTableConstant() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000556")]
	internal virtual ExpressionNode Optimize() { }

}

