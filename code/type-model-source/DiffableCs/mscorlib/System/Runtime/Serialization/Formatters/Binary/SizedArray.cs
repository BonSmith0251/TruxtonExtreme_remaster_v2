namespace System.Runtime.Serialization.Formatters.Binary;

[DefaultMember("Item")]
[Token(Token = "0x2000432")]
internal sealed class SizedArray : ICloneable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001159")]
	internal Object[] objects; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400115A")]
	internal Object[] negObjects; //Field offset: 0x18

	[Token(Token = "0x170003E9")]
	internal object Item
	{
		[Address(RVA = "0x1F429C0", Offset = "0x1F41DC0", Length = "0x68")]
		[Token(Token = "0x6001FEC")]
		internal get { } //Length: 104
		[Address(RVA = "0x1F42A30", Offset = "0x1F41E30", Length = "0x12B")]
		[Token(Token = "0x6001FED")]
		internal set { } //Length: 299
	}

	[Address(RVA = "0x1F427E0", Offset = "0x1F41BE0", Length = "0x76")]
	[Token(Token = "0x6001FE8")]
	internal SizedArray() { }

	[Address(RVA = "0x1F42860", Offset = "0x1F41C60", Length = "0x7B")]
	[Token(Token = "0x6001FE9")]
	internal SizedArray(int length) { }

	[Address(RVA = "0x1F428E0", Offset = "0x1F41CE0", Length = "0xD2")]
	[Token(Token = "0x6001FEA")]
	private SizedArray(SizedArray sizedArray) { }

	[Address(RVA = "0x1F42510", Offset = "0x1F41910", Length = "0xFE")]
	[Token(Token = "0x6001FEB")]
	public override object Clone() { }

	[Address(RVA = "0x1F429C0", Offset = "0x1F41DC0", Length = "0x68")]
	[Token(Token = "0x6001FEC")]
	internal object get_Item(int index) { }

	[Address(RVA = "0x1F42610", Offset = "0x1F41A10", Length = "0x1CF")]
	[Token(Token = "0x6001FEE")]
	internal void IncreaseCapacity(int index) { }

	[Address(RVA = "0x1F42A30", Offset = "0x1F41E30", Length = "0x12B")]
	[Token(Token = "0x6001FED")]
	internal void set_Item(int index, object value) { }

}

