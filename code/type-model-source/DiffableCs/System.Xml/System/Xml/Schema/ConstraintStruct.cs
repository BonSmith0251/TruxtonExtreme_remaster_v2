namespace System.Xml.Schema;

[Token(Token = "0x2000156")]
internal sealed class ConstraintStruct
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000735")]
	internal CompiledIdentityConstraint constraint; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000736")]
	internal SelectorActiveAxis axisSelector; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000737")]
	internal ArrayList axisFields; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000738")]
	internal Hashtable qualifiedTable; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000739")]
	internal Hashtable keyrefTable; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400073A")]
	private int tableDim; //Field offset: 0x38

	[Token(Token = "0x170003D4")]
	internal int TableDim
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x6000ECD")]
		internal get { } //Length: 4
	}

	[Address(RVA = "0x25818B0", Offset = "0x2580CB0", Length = "0x17B")]
	[Token(Token = "0x6000ECE")]
	internal ConstraintStruct(CompiledIdentityConstraint constraint) { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x6000ECD")]
	internal int get_TableDim() { }

}

