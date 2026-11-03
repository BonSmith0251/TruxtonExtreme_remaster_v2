namespace System.Data;

[Token(Token = "0x200006C")]
internal sealed class LookupNode : ExpressionNode
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000232")]
	private readonly string _relationName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000233")]
	private readonly string _columnName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000234")]
	private DataColumn _column; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000235")]
	private DataRelation _relation; //Field offset: 0x30

	[Address(RVA = "0x233F700", Offset = "0x233EB00", Length = "0x6B")]
	[Token(Token = "0x6000600")]
	internal LookupNode(DataTable table, string columnName, string relationName) { }

	[Address(RVA = "0x233F1B0", Offset = "0x233E5B0", Length = "0x3A1")]
	[Token(Token = "0x6000601")]
	internal virtual void Bind(DataTable table, List<DataColumn> list) { }

	[Address(RVA = "0x233F560", Offset = "0x233E960", Length = "0x8")]
	[Token(Token = "0x6000609")]
	internal virtual bool DependsOn(DataColumn column) { }

	[Address(RVA = "0x233F570", Offset = "0x233E970", Length = "0x27")]
	[Token(Token = "0x6000602")]
	internal virtual object Eval() { }

	[Address(RVA = "0x233F5E0", Offset = "0x233E9E0", Length = "0x118")]
	[Token(Token = "0x6000603")]
	internal virtual object Eval(DataRow row, DataRowVersion version) { }

	[Address(RVA = "0x233F5A0", Offset = "0x233E9A0", Length = "0x37")]
	[Token(Token = "0x6000604")]
	internal virtual object Eval(Int32[] recordNos) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000607")]
	internal virtual bool HasLocalAggregate() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000608")]
	internal virtual bool HasRemoteAggregate() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000605")]
	internal virtual bool IsConstant() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000606")]
	internal virtual bool IsTableConstant() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x600060A")]
	internal virtual ExpressionNode Optimize() { }

}

