namespace System.Runtime.Serialization.Formatters.Binary;

[DefaultMember("Item")]
[Token(Token = "0x2000433")]
internal sealed class IntSizedArray : ICloneable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400115B")]
	internal Int32[] objects; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400115C")]
	internal Int32[] negObjects; //Field offset: 0x18

	[Token(Token = "0x170003EA")]
	internal int Item
	{
		[Address(RVA = "0x1F36650", Offset = "0x1F35A50", Length = "0x67")]
		[Token(Token = "0x6001FF2")]
		internal get { } //Length: 103
		[Address(RVA = "0x1F366C0", Offset = "0x1F35AC0", Length = "0xAF")]
		[Token(Token = "0x6001FF3")]
		internal set { } //Length: 175
	}

	[Address(RVA = "0x1F365D0", Offset = "0x1F359D0", Length = "0x76")]
	[Token(Token = "0x6001FEF")]
	public IntSizedArray() { }

	[Address(RVA = "0x1F364B0", Offset = "0x1F358B0", Length = "0x114")]
	[Token(Token = "0x6001FF0")]
	private IntSizedArray(IntSizedArray sizedArray) { }

	[Address(RVA = "0x1F36190", Offset = "0x1F35590", Length = "0x140")]
	[Token(Token = "0x6001FF1")]
	public override object Clone() { }

	[Address(RVA = "0x1F36650", Offset = "0x1F35A50", Length = "0x67")]
	[Token(Token = "0x6001FF2")]
	internal int get_Item(int index) { }

	[Address(RVA = "0x1F362E0", Offset = "0x1F356E0", Length = "0x1CF")]
	[Token(Token = "0x6001FF4")]
	internal void IncreaseCapacity(int index) { }

	[Address(RVA = "0x1F366C0", Offset = "0x1F35AC0", Length = "0xAF")]
	[Token(Token = "0x6001FF3")]
	internal void set_Item(int index, int value) { }

}

