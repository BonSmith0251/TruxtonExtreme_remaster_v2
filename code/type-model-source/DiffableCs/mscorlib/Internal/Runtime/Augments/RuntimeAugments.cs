namespace Internal.Runtime.Augments;

[Token(Token = "0x2000089")]
internal class RuntimeAugments
{
	[Token(Token = "0x400023E")]
	private static ReflectionExecutionDomainCallbacks s_reflectionExecutionDomainCallbacks; //Field offset: 0x0

	[Token(Token = "0x17000034")]
	internal static ReflectionExecutionDomainCallbacks Callbacks
	{
		[Address(RVA = "0x1E7C4F0", Offset = "0x1E7B8F0", Length = "0x4E")]
		[Token(Token = "0x6000234")]
		internal get { } //Length: 78
	}

	[Address(RVA = "0x1E7C470", Offset = "0x1E7B870", Length = "0x73")]
	[Token(Token = "0x6000235")]
	private static RuntimeAugments() { }

	[Address(RVA = "0x1E7C4F0", Offset = "0x1E7B8F0", Length = "0x4E")]
	[Token(Token = "0x6000234")]
	internal static ReflectionExecutionDomainCallbacks get_Callbacks() { }

	[Address(RVA = "0x1E7C440", Offset = "0x1E7B840", Length = "0x23")]
	[Token(Token = "0x6000233")]
	public static void ReportUnhandledException(Exception exception) { }

}

