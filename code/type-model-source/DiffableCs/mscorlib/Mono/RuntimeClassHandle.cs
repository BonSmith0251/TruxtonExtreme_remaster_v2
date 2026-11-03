namespace Mono;

[Token(Token = "0x2000030")]
internal struct RuntimeClassHandle
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000107")]
	private MonoClass* value; //Field offset: 0x0

	[Token(Token = "0x17000005")]
	internal MonoClass* Value
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x600004B")]
		internal get { } //Length: 4
	}

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000049")]
	internal RuntimeClassHandle(MonoClass* value) { }

	[Address(RVA = "0x1E64150", Offset = "0x1E63550", Length = "0x1F")]
	[Token(Token = "0x600004A")]
	internal RuntimeClassHandle(IntPtr ptr) { }

	[Address(RVA = "0x1E64010", Offset = "0x1E63410", Length = "0xE5")]
	[Token(Token = "0x600004C")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x600004B")]
	internal MonoClass* get_Value() { }

	[Address(RVA = "0x1E64100", Offset = "0x1E63500", Length = "0x2D")]
	[Token(Token = "0x600004D")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1E64130", Offset = "0x1E63530", Length = "0x5")]
	[Token(Token = "0x600004E")]
	internal static IntPtr GetTypeFromClass(MonoClass* klass) { }

	[Address(RVA = "0x1E64140", Offset = "0x1E63540", Length = "0x8")]
	[Token(Token = "0x600004F")]
	internal RuntimeTypeHandle GetTypeHandle() { }

}

