namespace System.Runtime.CompilerServices;

[Token(Token = "0x200048B")]
public sealed class RuntimeWrappedException : Exception
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400125A")]
	private object _wrappedException; //Field offset: 0x90

	[Token(Token = "0x17000404")]
	public object WrappedException
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[Token(Token = "0x60020F2")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x1F41A00", Offset = "0x1F40E00", Length = "0x86")]
	[Token(Token = "0x60020EF")]
	public RuntimeWrappedException(object thrownObject) { }

	[Address(RVA = "0x1F41920", Offset = "0x1F40D20", Length = "0xDB")]
	[Token(Token = "0x60020F0")]
	private RuntimeWrappedException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F418F0", Offset = "0x1F40CF0", Length = "0x2C")]
	[Token(Token = "0x60020F3")]
	internal RuntimeWrappedException() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[Token(Token = "0x60020F2")]
	public object get_WrappedException() { }

	[Address(RVA = "0x1F41830", Offset = "0x1F40C30", Length = "0xB5")]
	[Token(Token = "0x60020F1")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

