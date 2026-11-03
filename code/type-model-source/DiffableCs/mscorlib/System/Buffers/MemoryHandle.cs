namespace System.Buffers;

[Token(Token = "0x200062B")]
public struct MemoryHandle : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40018B7")]
	private Void* _pointer; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40018B8")]
	private GCHandle _handle; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40018B9")]
	private IPinnable _pinnable; //Field offset: 0x10

	[CLSCompliant(False)]
	[Token(Token = "0x17000740")]
	public Void* Pointer
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x6002DE6")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x1FD9EA0", Offset = "0x1FD92A0", Length = "0x17")]
	[CLSCompliant(False)]
	[Token(Token = "0x6002DE5")]
	public MemoryHandle(Void* pointer, GCHandle handle = null, IPinnable pinnable = null) { }

	[Address(RVA = "0x1FD9E30", Offset = "0x1FD9230", Length = "0x70")]
	[Token(Token = "0x6002DE7")]
	public override void Dispose() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6002DE6")]
	public Void* get_Pointer() { }

}

