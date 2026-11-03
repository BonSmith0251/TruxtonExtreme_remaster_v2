namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x20002ED")]
public abstract class AsymmetricAlgorithm : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000CB3")]
	protected int KeySizeValue; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000CB4")]
	protected KeySizes[] LegalKeySizesValue; //Field offset: 0x18

	[Token(Token = "0x1700026B")]
	public override int KeySize
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6001848")]
		 get { } //Length: 85
		[Address(RVA = "0x1EB6050", Offset = "0x1EB5450", Length = "0x114")]
		[Token(Token = "0x6001849")]
		 set { } //Length: 276
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001844")]
	protected AsymmetricAlgorithm() { }

	[Address(RVA = "0x1EB5F60", Offset = "0x1EB5360", Length = "0x61")]
	[Token(Token = "0x6001846")]
	public void Clear() { }

	[Address(RVA = "0x1EB5F60", Offset = "0x1EB5360", Length = "0x61")]
	[Token(Token = "0x6001845")]
	public override void Dispose() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001847")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1EB5FD0", Offset = "0x1EB53D0", Length = "0x3E")]
	[Token(Token = "0x600184A")]
	public override void FromXmlString(string xmlString) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6001848")]
	public override int get_KeySize() { }

	[Address(RVA = "0x1EB6050", Offset = "0x1EB5450", Length = "0x114")]
	[Token(Token = "0x6001849")]
	public override void set_KeySize(int value) { }

	[Address(RVA = "0x1EB6010", Offset = "0x1EB5410", Length = "0x3E")]
	[Token(Token = "0x600184B")]
	public override string ToXmlString(bool includePrivateParameters) { }

}

