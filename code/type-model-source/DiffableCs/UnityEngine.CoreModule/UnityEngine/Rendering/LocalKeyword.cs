namespace UnityEngine.Rendering;

[IsReadOnly]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
[Token(Token = "0x2000401")]
[UsedByNativeCode]
public struct LocalKeyword : IEquatable<LocalKeyword>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D78")]
	internal readonly LocalKeywordSpace m_SpaceInfo; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000D79")]
	internal readonly string m_Name; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D7A")]
	internal readonly uint m_Index; //Field offset: 0x10

	[Address(RVA = "0x30C2EA0", Offset = "0x30C22A0", Length = "0x1E5")]
	[Token(Token = "0x6001F01")]
	public LocalKeyword(Shader shader, string name) { }

	[Address(RVA = "0x30C2CB0", Offset = "0x30C20B0", Length = "0x1E5")]
	[Token(Token = "0x6001F02")]
	public LocalKeyword(ComputeShader shader, string name) { }

	[Address(RVA = "0x30C25D0", Offset = "0x30C19D0", Length = "0xA7")]
	[Token(Token = "0x6001F04")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x30C2680", Offset = "0x30C1A80", Length = "0x42")]
	[Token(Token = "0x6001F05")]
	public override bool Equals(LocalKeyword rhs) { }

	[Address(RVA = "0x30C2710", Offset = "0x30C1B10", Length = "0x6B")]
	[FreeFunction("ShaderScripting::GetKeywordCount")]
	[Token(Token = "0x6001EFF")]
	private static uint GetComputeShaderKeywordCount(ComputeShader shader) { }

	[Address(RVA = "0x30C26D0", Offset = "0x30C1AD0", Length = "0x33")]
	[Token(Token = "0x6001F09")]
	private static uint GetComputeShaderKeywordCount_Injected(IntPtr shader) { }

	[Address(RVA = "0x30C27D0", Offset = "0x30C1BD0", Length = "0x1CB")]
	[FreeFunction("ShaderScripting::GetKeywordIndex")]
	[Token(Token = "0x6001F00")]
	private static uint GetComputeShaderKeywordIndex(ComputeShader shader, string keyword) { }

	[Address(RVA = "0x30C2780", Offset = "0x30C1B80", Length = "0x42")]
	[Token(Token = "0x6001F0A")]
	private static uint GetComputeShaderKeywordIndex_Injected(IntPtr shader, ref ManagedSpanWrapper keyword) { }

	[Address(RVA = "0x30C29A0", Offset = "0x30C1DA0", Length = "0x31")]
	[Token(Token = "0x6001F06")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x30C2A20", Offset = "0x30C1E20", Length = "0x6B")]
	[FreeFunction("ShaderScripting::GetKeywordCount")]
	[Token(Token = "0x6001EFD")]
	private static uint GetShaderKeywordCount(Shader shader) { }

	[Address(RVA = "0x30C29E0", Offset = "0x30C1DE0", Length = "0x33")]
	[Token(Token = "0x6001F07")]
	private static uint GetShaderKeywordCount_Injected(IntPtr shader) { }

	[Address(RVA = "0x30C2AE0", Offset = "0x30C1EE0", Length = "0x1CB")]
	[FreeFunction("ShaderScripting::GetKeywordIndex")]
	[Token(Token = "0x6001EFE")]
	private static uint GetShaderKeywordIndex(Shader shader, string keyword) { }

	[Address(RVA = "0x30C2A90", Offset = "0x30C1E90", Length = "0x42")]
	[Token(Token = "0x6001F08")]
	private static uint GetShaderKeywordIndex_Injected(IntPtr shader, ref ManagedSpanWrapper keyword) { }

	[Address(RVA = "0x20939E0", Offset = "0x2092DE0", Length = "0x7")]
	[Token(Token = "0x6001F03")]
	public virtual string ToString() { }

}

