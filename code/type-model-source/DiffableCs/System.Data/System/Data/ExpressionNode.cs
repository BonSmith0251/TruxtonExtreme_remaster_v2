namespace System.Data;

[Token(Token = "0x2000060")]
internal abstract class ExpressionNode
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001EF")]
	private DataTable _table; //Field offset: 0x10

	[Token(Token = "0x170000EF")]
	internal IFormatProvider FormatProvider
	{
		[Address(RVA = "0x233B400", Offset = "0x233A800", Length = "0x5D")]
		[Token(Token = "0x600058E")]
		internal get { } //Length: 93
	}

	[Token(Token = "0x170000F0")]
	internal override bool IsSqlColumn
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600058F")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x170000F1")]
	protected DataTable table
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000590")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x600058D")]
	protected ExpressionNode(DataTable table) { }

	[Token(Token = "0x6000592")]
	internal abstract void Bind(DataTable table, List<DataColumn> list) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6000591")]
	protected void BindTable(DataTable table) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600059B")]
	internal override bool DependsOn(DataColumn column) { }

	[Token(Token = "0x6000593")]
	internal abstract object Eval() { }

	[Token(Token = "0x6000594")]
	internal abstract object Eval(DataRow row, DataRowVersion version) { }

	[Token(Token = "0x6000595")]
	internal abstract object Eval(Int32[] recordNos) { }

	[Address(RVA = "0x233B400", Offset = "0x233A800", Length = "0x5D")]
	[Token(Token = "0x600058E")]
	internal IFormatProvider get_FormatProvider() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600058F")]
	internal override bool get_IsSqlColumn() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000590")]
	protected DataTable get_table() { }

	[Token(Token = "0x6000598")]
	internal abstract bool HasLocalAggregate() { }

	[Token(Token = "0x6000599")]
	internal abstract bool HasRemoteAggregate() { }

	[Token(Token = "0x6000596")]
	internal abstract bool IsConstant() { }

	[Address(RVA = "0x233B290", Offset = "0x233A690", Length = "0x12")]
	[Token(Token = "0x60005A4")]
	internal static bool IsFloat(StorageType type) { }

	[Address(RVA = "0x233B270", Offset = "0x233A670", Length = "0x1F")]
	[Token(Token = "0x60005A5")]
	internal static bool IsFloatSql(StorageType type) { }

	[Address(RVA = "0x233B2D0", Offset = "0x233A6D0", Length = "0x19")]
	[Token(Token = "0x600059C")]
	internal static bool IsInteger(StorageType type) { }

	[Address(RVA = "0x233B2B0", Offset = "0x233A6B0", Length = "0x1A")]
	[Token(Token = "0x600059D")]
	internal static bool IsIntegerSql(StorageType type) { }

	[Address(RVA = "0x233B330", Offset = "0x233A730", Length = "0x26")]
	[Token(Token = "0x60005A2")]
	internal static bool IsNumeric(StorageType type) { }

	[Address(RVA = "0x233B2F0", Offset = "0x233A6F0", Length = "0x34")]
	[Token(Token = "0x60005A3")]
	internal static bool IsNumericSql(StorageType type) { }

	[Address(RVA = "0x233B3A0", Offset = "0x233A7A0", Length = "0x1C")]
	[Token(Token = "0x600059E")]
	internal static bool IsSigned(StorageType type) { }

	[Address(RVA = "0x233B360", Offset = "0x233A760", Length = "0x34")]
	[Token(Token = "0x600059F")]
	internal static bool IsSignedSql(StorageType type) { }

	[Token(Token = "0x6000597")]
	internal abstract bool IsTableConstant() { }

	[Address(RVA = "0x233B3E0", Offset = "0x233A7E0", Length = "0x19")]
	[Token(Token = "0x60005A0")]
	internal static bool IsUnsigned(StorageType type) { }

	[Address(RVA = "0x233B3C0", Offset = "0x233A7C0", Length = "0x19")]
	[Token(Token = "0x60005A1")]
	internal static bool IsUnsignedSql(StorageType type) { }

	[Token(Token = "0x600059A")]
	internal abstract ExpressionNode Optimize() { }

}

