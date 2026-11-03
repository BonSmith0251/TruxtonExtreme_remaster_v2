namespace System.Data;

[Token(Token = "0x200005F")]
internal sealed class DataExpression : IFilter
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001E7")]
	internal string _originalExpression; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001E8")]
	private bool _parsed; //Field offset: 0x18
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x40001E9")]
	private bool _bound; //Field offset: 0x19
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001EA")]
	private ExpressionNode _expr; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001EB")]
	private DataTable _table; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001EC")]
	private readonly StorageType _storageType; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001ED")]
	private readonly Type _dataType; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001EE")]
	private DataColumn[] _dependency; //Field offset: 0x40

	[Token(Token = "0x170000ED")]
	internal string Expression
	{
		[Address(RVA = "0x2333AA0", Offset = "0x2332EA0", Length = "0x43")]
		[Token(Token = "0x6000580")]
		internal get { } //Length: 67
	}

	[Token(Token = "0x170000EE")]
	internal bool HasValue
	{
		[Address(RVA = "0x227B4E0", Offset = "0x227A8E0", Length = "0x9")]
		[Token(Token = "0x6000581")]
		internal get { } //Length: 9
	}

	[Address(RVA = "0x2333660", Offset = "0x2332A60", Length = "0x1A")]
	[Token(Token = "0x600057E")]
	internal DataExpression(DataTable table, string expression) { }

	[Address(RVA = "0x2333680", Offset = "0x2332A80", Length = "0x412")]
	[Token(Token = "0x600057F")]
	internal DataExpression(DataTable table, string expression, Type type) { }

	[Address(RVA = "0x2332FA0", Offset = "0x23323A0", Length = "0x12B")]
	[Token(Token = "0x6000582")]
	internal void Bind(DataTable table) { }

	[Address(RVA = "0x23330D0", Offset = "0x23324D0", Length = "0x22")]
	[Token(Token = "0x6000583")]
	internal bool DependsOn(DataColumn column) { }

	[Address(RVA = "0x2333270", Offset = "0x2332670", Length = "0x10")]
	[Token(Token = "0x6000584")]
	internal object Evaluate() { }

	[Address(RVA = "0x2333100", Offset = "0x2332500", Length = "0x16A")]
	[Token(Token = "0x6000585")]
	internal object Evaluate(DataRow row, DataRowVersion version) { }

	[Address(RVA = "0x2333AA0", Offset = "0x2332EA0", Length = "0x43")]
	[Token(Token = "0x6000580")]
	internal string get_Expression() { }

	[Address(RVA = "0x227B4E0", Offset = "0x227A8E0", Length = "0x9")]
	[Token(Token = "0x6000581")]
	internal bool get_HasValue() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6000587")]
	internal DataColumn[] GetDependency() { }

	[Address(RVA = "0x2333280", Offset = "0x2332680", Length = "0x22")]
	[Token(Token = "0x600058A")]
	internal bool HasLocalAggregate() { }

	[Address(RVA = "0x23332B0", Offset = "0x23326B0", Length = "0x22")]
	[Token(Token = "0x600058B")]
	internal bool HasRemoteAggregate() { }

	[Address(RVA = "0x23332E0", Offset = "0x23326E0", Length = "0xA1")]
	[Token(Token = "0x6000586")]
	public override bool Invoke(DataRow row, DataRowVersion version) { }

	[Address(RVA = "0x2333390", Offset = "0x2332790", Length = "0x22")]
	[Token(Token = "0x6000588")]
	internal bool IsTableAggregate() { }

	[Address(RVA = "0x23333C0", Offset = "0x23327C0", Length = "0x49")]
	[Token(Token = "0x6000589")]
	internal static bool IsUnknown(object value) { }

	[Address(RVA = "0x2333410", Offset = "0x2332810", Length = "0x24A")]
	[Token(Token = "0x600058C")]
	internal static bool ToBoolean(object value) { }

}

