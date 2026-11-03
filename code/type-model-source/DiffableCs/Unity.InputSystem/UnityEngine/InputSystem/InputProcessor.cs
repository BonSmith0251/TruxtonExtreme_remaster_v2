namespace UnityEngine.InputSystem;

[Token(Token = "0x2000085")]
public abstract class InputProcessor
{
	[Token(Token = "0x2000086")]
	internal enum CachingPolicy : int
	{
		CacheResult = 0,
		EvaluateOnEveryRead = 1,
	}

	[Token(Token = "0x40002F4")]
	internal static TypeTable s_Processors; //Field offset: 0x0

	[Token(Token = "0x170001AB")]
	public override CachingPolicy cachingPolicy
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000633")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000634")]
	protected InputProcessor() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000633")]
	public override CachingPolicy get_cachingPolicy() { }

	[Address(RVA = "0x293B930", Offset = "0x293AD30", Length = "0xD9")]
	[Token(Token = "0x6000632")]
	internal static Type GetValueTypeFromType(Type processorType) { }

	[Token(Token = "0x6000631")]
	public abstract void Process(Void* buffer, int bufferSize, InputControl control) { }

	[Token(Token = "0x6000630")]
	public abstract object ProcessAsObject(object value, InputControl control) { }

}

