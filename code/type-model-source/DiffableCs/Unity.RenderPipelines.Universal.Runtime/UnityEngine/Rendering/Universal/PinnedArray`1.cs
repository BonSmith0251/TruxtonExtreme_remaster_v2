namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20000F4")]
internal struct PinnedArray : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400058D")]
	public T[] managedArray; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400058E")]
	public GCHandle handle; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400058F")]
	public NativeArray<T> nativeArray; //Field offset: 0x0

	[Token(Token = "0x170001C6")]
	public int length
	{
		[Address(RVA = "0xE22AD0", Offset = "0xE21ED0", Length = "0x10")]
		[Token(Token = "0x6000694")]
		 get { } //Length: 16
	}

	[Address(RVA = "0xE229B0", Offset = "0xE21DB0", Length = "0x114")]
	[Token(Token = "0x6000695")]
	public PinnedArray`1(int length) { }

	[Address(RVA = "0xE22980", Offset = "0xE21D80", Length = "0x2A")]
	[Token(Token = "0x6000696")]
	public override void Dispose() { }

	[Address(RVA = "0xE22AD0", Offset = "0xE21ED0", Length = "0x10")]
	[Token(Token = "0x6000694")]
	public int get_length() { }

}

