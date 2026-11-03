namespace UnityEngine.Rendering.UnifiedRayTracing;

[Token(Token = "0x200005E")]
public class UnifiedRayTracingException : Exception
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40001FD")]
	private UnifiedRayTracingError <errorCode>k__BackingField; //Field offset: 0x90

	[Token(Token = "0x17000038")]
	public private UnifiedRayTracingError errorCode
	{
		[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60001B8")]
		 get { } //Length: 7
		[Address(RVA = "0x1E26130", Offset = "0x1E25530", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60001B9")]
		private set { } //Length: 7
	}

	[Address(RVA = "0x2F64AD0", Offset = "0x2F63ED0", Length = "0x6D")]
	[Token(Token = "0x60001B7")]
	public UnifiedRayTracingException(string message, UnifiedRayTracingError errorCode) { }

	[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x60001B8")]
	public UnifiedRayTracingError get_errorCode() { }

	[Address(RVA = "0x1E26130", Offset = "0x1E25530", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x60001B9")]
	private void set_errorCode(UnifiedRayTracingError value) { }

}

