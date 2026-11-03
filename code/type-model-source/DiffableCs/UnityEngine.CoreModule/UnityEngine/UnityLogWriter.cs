namespace UnityEngine;

[NativeHeader("Runtime/Export/Logging/UnityLogWriter.bindings.h")]
[Token(Token = "0x200014B")]
internal class UnityLogWriter : TextWriter
{

	[Token(Token = "0x17000274")]
	public virtual Encoding Encoding
	{
		[Address(RVA = "0x3050E30", Offset = "0x3050230", Length = "0x9")]
		[Token(Token = "0x6000FD8")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x3050DE0", Offset = "0x30501E0", Length = "0x49")]
	[Token(Token = "0x6000FDC")]
	public UnityLogWriter() { }

	[Address(RVA = "0x3050E30", Offset = "0x3050230", Length = "0x9")]
	[Token(Token = "0x6000FD8")]
	public virtual Encoding get_Encoding() { }

	[Address(RVA = "0x3050AA0", Offset = "0x304FEA0", Length = "0xD4")]
	[Token(Token = "0x6000FD7")]
	public static void Init() { }

	[Address(RVA = "0x3050D70", Offset = "0x3050170", Length = "0x3E")]
	[Token(Token = "0x6000FD9")]
	public virtual void Write(char value) { }

	[Address(RVA = "0x3050D50", Offset = "0x3050150", Length = "0x13")]
	[Token(Token = "0x6000FDA")]
	public virtual void Write(string s) { }

	[Address(RVA = "0x3050DB0", Offset = "0x30501B0", Length = "0x22")]
	[Token(Token = "0x6000FDB")]
	public virtual void Write(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x3050D40", Offset = "0x3050140", Length = "0xD")]
	[ThreadAndSerializationSafe]
	[Token(Token = "0x6000FD5")]
	public static void WriteStringToUnityLog(string s) { }

	[Address(RVA = "0x3050BC0", Offset = "0x304FFC0", Length = "0x178")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6000FD6")]
	private static void WriteStringToUnityLogImpl(string s) { }

	[Address(RVA = "0x3050B80", Offset = "0x304FF80", Length = "0x33")]
	[Token(Token = "0x6000FDD")]
	private static void WriteStringToUnityLogImpl_Injected(ref ManagedSpanWrapper s) { }

}

