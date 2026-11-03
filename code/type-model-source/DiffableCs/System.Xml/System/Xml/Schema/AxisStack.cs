namespace System.Xml.Schema;

[Token(Token = "0x200014A")]
internal class AxisStack
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006FF")]
	private ArrayList _stack; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000700")]
	private ForwardAxis _subtree; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000701")]
	private ActiveAxis _parent; //Field offset: 0x20

	[Token(Token = "0x170003B4")]
	internal int Length
	{
		[Address(RVA = "0x1FC0C30", Offset = "0x1FC0030", Length = "0x2A")]
		[Token(Token = "0x6000E59")]
		internal get { } //Length: 42
	}

	[Token(Token = "0x170003B3")]
	internal ForwardAxis Subtree
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000E58")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x257BA30", Offset = "0x257AE30", Length = "0xC1")]
	[Token(Token = "0x6000E5A")]
	public AxisStack(ForwardAxis faxis, ActiveAxis parent) { }

	[Address(RVA = "0x257B1E0", Offset = "0x257A5E0", Length = "0x78")]
	[Token(Token = "0x6000E5D")]
	internal static bool Equal(string thisname, string thisURN, string name, string URN) { }

	[Address(RVA = "0x1FC0C30", Offset = "0x1FC0030", Length = "0x2A")]
	[Token(Token = "0x6000E59")]
	internal int get_Length() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000E58")]
	internal ForwardAxis get_Subtree() { }

	[Address(RVA = "0x257B260", Offset = "0x257A660", Length = "0x1F6")]
	[Token(Token = "0x6000E60")]
	internal bool MoveToAttribute(string name, string URN, int depth) { }

	[Address(RVA = "0x257B460", Offset = "0x257A860", Length = "0x1BD")]
	[Token(Token = "0x6000E5F")]
	internal bool MoveToChild(string name, string URN, int depth) { }

	[Address(RVA = "0x257B620", Offset = "0x257AA20", Length = "0x304")]
	[Token(Token = "0x6000E5E")]
	internal void MoveToParent(string name, string URN, int depth) { }

	[Address(RVA = "0x257B930", Offset = "0x257AD30", Length = "0x49")]
	[Token(Token = "0x6000E5C")]
	internal void Pop() { }

	[Address(RVA = "0x257B980", Offset = "0x257AD80", Length = "0xAE")]
	[Token(Token = "0x6000E5B")]
	internal void Push(int depth) { }

}

