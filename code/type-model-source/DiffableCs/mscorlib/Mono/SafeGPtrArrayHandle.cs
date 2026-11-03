namespace Mono;

[DefaultMember("Item")]
[Token(Token = "0x2000044")]
internal struct SafeGPtrArrayHandle : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000136")]
	private RuntimeGPtrArrayHandle handle; //Field offset: 0x0

	[Token(Token = "0x1700000E")]
	internal IntPtr Item
	{
		[Address(RVA = "0x1E64310", Offset = "0x1E63710", Length = "0x8")]
		[Token(Token = "0x600006D")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x1700000D")]
	internal int Length
	{
		[Address(RVA = "0x1E64320", Offset = "0x1E63720", Length = "0x19")]
		[Token(Token = "0x600006C")]
		internal get { } //Length: 25
	}

	[Address(RVA = "0x1E64150", Offset = "0x1E63550", Length = "0x1F")]
	[Token(Token = "0x600006A")]
	internal SafeGPtrArrayHandle(IntPtr ptr) { }

	[Address(RVA = "0x1E64260", Offset = "0x1E63660", Length = "0x1E")]
	[Token(Token = "0x600006B")]
	public override void Dispose() { }

	[Address(RVA = "0x1E64310", Offset = "0x1E63710", Length = "0x8")]
	[Token(Token = "0x600006D")]
	internal IntPtr get_Item(int i) { }

	[Address(RVA = "0x1E64320", Offset = "0x1E63720", Length = "0x19")]
	[Token(Token = "0x600006C")]
	internal int get_Length() { }

}

