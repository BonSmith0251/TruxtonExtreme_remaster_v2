namespace System.Xml.Schema;

[Token(Token = "0x200014C")]
internal class DoubleLinkAxis : Axis
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000706")]
	internal Axis next; //Field offset: 0x40

	[Token(Token = "0x170003B6")]
	internal Axis Next
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6000E67")]
		internal get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[Token(Token = "0x6000E68")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x2582820", Offset = "0x2581C20", Length = "0x97")]
	[Token(Token = "0x6000E69")]
	internal DoubleLinkAxis(Axis axis, DoubleLinkAxis inputaxis) { }

	[Address(RVA = "0x25826F0", Offset = "0x2581AF0", Length = "0x128")]
	[Token(Token = "0x6000E6A")]
	internal static DoubleLinkAxis ConvertTree(Axis axis) { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6000E67")]
	internal Axis get_Next() { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[Token(Token = "0x6000E68")]
	internal void set_Next(Axis value) { }

}

