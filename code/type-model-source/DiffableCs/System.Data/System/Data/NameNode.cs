namespace System.Data;

[Token(Token = "0x200006D")]
internal sealed class NameNode : ExpressionNode
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000236")]
	internal string _name; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000237")]
	internal bool _found; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000238")]
	internal DataColumn _column; //Field offset: 0x28

	[Token(Token = "0x170000F2")]
	internal virtual bool IsSqlColumn
	{
		[Address(RVA = "0x233FFD0", Offset = "0x233F3D0", Length = "0x6A")]
		[Token(Token = "0x600060D")]
		internal get { } //Length: 106
	}

	[Address(RVA = "0x233FF60", Offset = "0x233F360", Length = "0x6D")]
	[Token(Token = "0x600060B")]
	internal NameNode(DataTable table, Char[] text, int start, int pos) { }

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x600060C")]
	internal NameNode(DataTable table, string name) { }

	[Address(RVA = "0x233F770", Offset = "0x233EB70", Length = "0x1DB")]
	[Token(Token = "0x600060E")]
	internal virtual void Bind(DataTable table, List<DataColumn> list) { }

	[Address(RVA = "0x233F950", Offset = "0x233ED50", Length = "0x87")]
	[Token(Token = "0x6000616")]
	internal virtual bool DependsOn(DataColumn column) { }

	[Address(RVA = "0x233FB00", Offset = "0x233EF00", Length = "0x27")]
	[Token(Token = "0x600060F")]
	internal virtual object Eval() { }

	[Address(RVA = "0x233F9E0", Offset = "0x233EDE0", Length = "0xD6")]
	[Token(Token = "0x6000610")]
	internal virtual object Eval(DataRow row, DataRowVersion version) { }

	[Address(RVA = "0x233FAC0", Offset = "0x233EEC0", Length = "0x37")]
	[Token(Token = "0x6000611")]
	internal virtual object Eval(Int32[] records) { }

	[Address(RVA = "0x233FFD0", Offset = "0x233F3D0", Length = "0x6A")]
	[Token(Token = "0x600060D")]
	internal virtual bool get_IsSqlColumn() { }

	[Address(RVA = "0x233FB30", Offset = "0x233EF30", Length = "0x62")]
	[Token(Token = "0x6000614")]
	internal virtual bool HasLocalAggregate() { }

	[Address(RVA = "0x233FBA0", Offset = "0x233EFA0", Length = "0x62")]
	[Token(Token = "0x6000615")]
	internal virtual bool HasRemoteAggregate() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000612")]
	internal virtual bool IsConstant() { }

	[Address(RVA = "0x233FC10", Offset = "0x233F010", Length = "0x62")]
	[Token(Token = "0x6000613")]
	internal virtual bool IsTableConstant() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000617")]
	internal virtual ExpressionNode Optimize() { }

	[Address(RVA = "0x233FC80", Offset = "0x233F080", Length = "0x2D1")]
	[Token(Token = "0x6000618")]
	internal static string ParseName(Char[] text, int start, int pos) { }

}

