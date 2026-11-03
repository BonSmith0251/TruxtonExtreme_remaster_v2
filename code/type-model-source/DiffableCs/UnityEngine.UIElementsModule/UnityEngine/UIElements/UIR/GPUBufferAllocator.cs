namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200058D")]
internal class GPUBufferAllocator
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40012D2")]
	private BestFitAllocator m_Low; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40012D3")]
	private BestFitAllocator m_High; //Field offset: 0x18

	[Token(Token = "0x17000A3B")]
	public bool isEmpty
	{
		[Address(RVA = "0x32F66F0", Offset = "0x32F5AF0", Length = "0x35")]
		[Token(Token = "0x6002845")]
		 get { } //Length: 53
	}

	[Address(RVA = "0x32F6640", Offset = "0x32F5A40", Length = "0xA1")]
	[Token(Token = "0x6002842")]
	public GPUBufferAllocator(uint maxSize) { }

	[Address(RVA = "0x32F6380", Offset = "0x32F5780", Length = "0x209")]
	[Token(Token = "0x6002843")]
	public Alloc Allocate(uint size, bool shortLived) { }

	[Address(RVA = "0x32F6590", Offset = "0x32F5990", Length = "0x7D")]
	[Token(Token = "0x6002844")]
	public void Free(Alloc alloc) { }

	[Address(RVA = "0x32F66F0", Offset = "0x32F5AF0", Length = "0x35")]
	[Token(Token = "0x6002845")]
	public bool get_isEmpty() { }

	[Address(RVA = "0x32F6610", Offset = "0x32F5A10", Length = "0x2C")]
	[Token(Token = "0x6002846")]
	private bool HighLowCollide() { }

}

