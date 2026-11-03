namespace System.Data;

[Token(Token = "0x200005B")]
internal class BinaryNode : ExpressionNode
{
	[Token(Token = "0x200005C")]
	private enum DataTypePrecedence : int
	{
		SqlDateTime = 25,
		DateTimeOffset = 24,
		DateTime = 23,
		TimeSpan = 20,
		SqlDouble = 19,
		Double = 18,
		SqlSingle = 17,
		Single = 16,
		SqlDecimal = 15,
		Decimal = 14,
		SqlMoney = 13,
		UInt64 = 12,
		SqlInt64 = 11,
		Int64 = 10,
		UInt32 = 9,
		SqlInt32 = 8,
		Int32 = 7,
		UInt16 = 6,
		SqlInt16 = 5,
		Int16 = 4,
		Byte = 3,
		SqlByte = 2,
		SByte = 1,
		Error = 0,
		SqlBoolean = -1,
		Boolean = -2,
		SqlGuid = -3,
		SqlString = -4,
		String = -5,
		SqlXml = -6,
		SqlChars = -7,
		Char = -8,
		SqlBytes = -9,
		SqlBinary = -10,
	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001BE")]
	internal int _op; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001BF")]
	internal ExpressionNode _left; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001C0")]
	internal ExpressionNode _right; //Field offset: 0x28

	[Address(RVA = "0x2332640", Offset = "0x2331A40", Length = "0x70")]
	[Token(Token = "0x6000557")]
	internal BinaryNode(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	[Address(RVA = "0x232B5F0", Offset = "0x232A9F0", Length = "0x1EC")]
	[Token(Token = "0x6000565")]
	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op, CompareInfo comparer) { }

	[Address(RVA = "0x232B5C0", Offset = "0x232A9C0", Length = "0x22")]
	[Token(Token = "0x6000564")]
	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op) { }

	[Address(RVA = "0x232C4D0", Offset = "0x232B8D0", Length = "0x7E")]
	[Token(Token = "0x6000558")]
	internal virtual void Bind(DataTable table, List<DataColumn> list) { }

	[Address(RVA = "0x232C550", Offset = "0x232B950", Length = "0x6C")]
	[Token(Token = "0x6000560")]
	internal virtual bool DependsOn(DataColumn column) { }

	[Address(RVA = "0x230DA20", Offset = "0x230CE20", Length = "0x1C")]
	[Token(Token = "0x6000559")]
	internal virtual object Eval() { }

	[Address(RVA = "0x23313E0", Offset = "0x23307E0", Length = "0x2F")]
	[Token(Token = "0x600055A")]
	internal virtual object Eval(DataRow row, DataRowVersion version) { }

	[Address(RVA = "0x2331350", Offset = "0x2330750", Length = "0x32")]
	[Token(Token = "0x600055B")]
	internal virtual object Eval(Int32[] recordNos) { }

	[Address(RVA = "0x2331390", Offset = "0x2330790", Length = "0x46")]
	[Token(Token = "0x6000563")]
	private static object Eval(ExpressionNode expr, DataRow row, DataRowVersion version, Int32[] recordNos) { }

	[Address(RVA = "0x232C5C0", Offset = "0x232B9C0", Length = "0x1130")]
	[Token(Token = "0x6000566")]
	private object EvalBinaryOp(int op, ExpressionNode left, ExpressionNode right, DataRow row, DataRowVersion version, Int32[] recordNos) { }

	[Address(RVA = "0x2331580", Offset = "0x2330980", Length = "0xE4")]
	[Token(Token = "0x6000567")]
	private DataTypePrecedence GetPrecedence(StorageType storageType) { }

	[Address(RVA = "0x2331410", Offset = "0x2330810", Length = "0x1C")]
	[Token(Token = "0x6000568")]
	private static StorageType GetPrecedenceType(DataTypePrecedence code) { }

	[Address(RVA = "0x2331710", Offset = "0x2330B10", Length = "0x58")]
	[Token(Token = "0x600055E")]
	internal virtual bool HasLocalAggregate() { }

	[Address(RVA = "0x2331770", Offset = "0x2330B70", Length = "0x58")]
	[Token(Token = "0x600055F")]
	internal virtual bool HasRemoteAggregate() { }

	[Address(RVA = "0x23317D0", Offset = "0x2330BD0", Length = "0x56")]
	[Token(Token = "0x600055C")]
	internal virtual bool IsConstant() { }

	[Address(RVA = "0x23318B0", Offset = "0x2330CB0", Length = "0x61")]
	[Token(Token = "0x6000569")]
	private bool IsMixed(StorageType left, StorageType right) { }

	[Address(RVA = "0x2331830", Offset = "0x2330C30", Length = "0x7C")]
	[Token(Token = "0x600056A")]
	private bool IsMixedSql(StorageType left, StorageType right) { }

	[Address(RVA = "0x2331920", Offset = "0x2330D20", Length = "0x56")]
	[Token(Token = "0x600055D")]
	internal virtual bool IsTableConstant() { }

	[Address(RVA = "0x2331980", Offset = "0x2330D80", Length = "0x390")]
	[Token(Token = "0x6000561")]
	internal virtual ExpressionNode Optimize() { }

	[Address(RVA = "0x2331D20", Offset = "0x2331120", Length = "0x424")]
	[Token(Token = "0x600056C")]
	internal StorageType ResultSqlType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	[Address(RVA = "0x23321C0", Offset = "0x23315C0", Length = "0x34D")]
	[Token(Token = "0x600056B")]
	internal StorageType ResultType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	[Address(RVA = "0x2332510", Offset = "0x2331910", Length = "0x36")]
	[Token(Token = "0x6000562")]
	internal void SetTypeMismatchError(int op, Type left, Type right) { }

	[Address(RVA = "0x2332550", Offset = "0x2331950", Length = "0x7C")]
	[Token(Token = "0x600056D")]
	private int SqlResultType(int typeCode) { }

}

