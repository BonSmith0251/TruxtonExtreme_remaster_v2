namespace Unity.Collections;

[Token(Token = "0x200007B")]
public interface IUTF8Bytes
{

	[Token(Token = "0x170000A7")]
	public bool IsEmpty
	{
		[Token(Token = "0x60006C3")]
		 get { } //Length: 0
	}

	[Token(Token = "0x60006C3")]
	public bool get_IsEmpty() { }

	[Token(Token = "0x60006C4")]
	public Byte* GetUnsafePtr() { }

	[Token(Token = "0x60006C5")]
	public bool TryResize(int newLength, NativeArrayOptions clearOptions = 1) { }

}

