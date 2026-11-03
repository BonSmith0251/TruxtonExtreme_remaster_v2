namespace System.Data;

[Token(Token = "0x200001C")]
internal sealed class FunctionNode : ExpressionNode
{
	[Token(Token = "0x40000A0")]
	private static readonly Function[] s_funcs; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400009B")]
	internal readonly string _name; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400009C")]
	internal readonly int _info; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400009D")]
	internal int _argumentCount; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400009E")]
	internal ExpressionNode[] _arguments; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Nullable(2)]
	[Token(Token = "0x400009F")]
	private readonly TypeLimiter _capturedLimiter; //Field offset: 0x30

	[Token(Token = "0x1700006E")]
	internal FunctionId Aggregate
	{
		[Address(RVA = "0x230ED90", Offset = "0x230E190", Length = "0x93")]
		[Token(Token = "0x60002F6")]
		internal get { } //Length: 147
	}

	[Token(Token = "0x1700006F")]
	internal bool IsAggregate
	{
		[Address(RVA = "0x230EE30", Offset = "0x230E230", Length = "0x247")]
		[Token(Token = "0x60002F7")]
		internal get { } //Length: 583
	}

	[Address(RVA = "0x230E150", Offset = "0x230D550", Length = "0xAD5")]
	[Token(Token = "0x60002F9")]
	private static FunctionNode() { }

	[Address(RVA = "0x230EC30", Offset = "0x230E030", Length = "0x15F")]
	[Token(Token = "0x60002E8")]
	internal FunctionNode(DataTable table, string name) { }

	[Address(RVA = "0x230A9E0", Offset = "0x2309DE0", Length = "0x1EF")]
	[Token(Token = "0x60002E9")]
	internal void AddArgument(ExpressionNode argument) { }

	[Address(RVA = "0x230ABD0", Offset = "0x2309FD0", Length = "0x317")]
	[Token(Token = "0x60002EA")]
	internal virtual void Bind(DataTable table, List<DataColumn> list) { }

	[Address(RVA = "0x230AEF0", Offset = "0x230A2F0", Length = "0x25E")]
	[Token(Token = "0x60002F8")]
	internal void Check() { }

	[Address(RVA = "0x230B150", Offset = "0x230A550", Length = "0x88")]
	[Token(Token = "0x60002F2")]
	internal virtual bool DependsOn(DataColumn column) { }

	[Address(RVA = "0x230DA20", Offset = "0x230CE20", Length = "0x1C")]
	[Token(Token = "0x60002EB")]
	internal virtual object Eval() { }

	[Address(RVA = "0x230CF00", Offset = "0x230C300", Length = "0xADB")]
	[Token(Token = "0x60002EC")]
	internal virtual object Eval(DataRow row, DataRowVersion version) { }

	[Address(RVA = "0x230D9E0", Offset = "0x230CDE0", Length = "0x37")]
	[Token(Token = "0x60002ED")]
	internal virtual object Eval(Int32[] recordNos) { }

	[Address(RVA = "0x230B1E0", Offset = "0x230A5E0", Length = "0x1CC0")]
	[Token(Token = "0x60002F5")]
	private object EvalFunction(FunctionId id, Object[] argumentValues, DataRow row, DataRowVersion version) { }

	[Address(RVA = "0x230ED90", Offset = "0x230E190", Length = "0x93")]
	[Token(Token = "0x60002F6")]
	internal FunctionId get_Aggregate() { }

	[Address(RVA = "0x230EE30", Offset = "0x230E230", Length = "0x247")]
	[Token(Token = "0x60002F7")]
	internal bool get_IsAggregate() { }

	[Address(RVA = "0x230DA40", Offset = "0x230CE40", Length = "0x2B9")]
	[Token(Token = "0x60002F4")]
	private Type GetDataType(ExpressionNode node) { }

	[Address(RVA = "0x230DD00", Offset = "0x230D100", Length = "0x88")]
	[Token(Token = "0x60002F0")]
	internal virtual bool HasLocalAggregate() { }

	[Address(RVA = "0x230DD90", Offset = "0x230D190", Length = "0x88")]
	[Token(Token = "0x60002F1")]
	internal virtual bool HasRemoteAggregate() { }

	[Address(RVA = "0x230DE20", Offset = "0x230D220", Length = "0x80")]
	[Token(Token = "0x60002EE")]
	internal virtual bool IsConstant() { }

	[Address(RVA = "0x230DEB0", Offset = "0x230D2B0", Length = "0x88")]
	[Token(Token = "0x60002EF")]
	internal virtual bool IsTableConstant() { }

	[Address(RVA = "0x230DF40", Offset = "0x230D340", Length = "0x205")]
	[Token(Token = "0x60002F3")]
	internal virtual ExpressionNode Optimize() { }

}

