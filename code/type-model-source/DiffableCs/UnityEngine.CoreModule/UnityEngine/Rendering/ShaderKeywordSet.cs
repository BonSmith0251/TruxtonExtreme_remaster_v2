namespace UnityEngine.Rendering;

[NativeHeader("Editor/Src/Graphics/ShaderCompilerData.h")]
[Token(Token = "0x2000406")]
[UsedByNativeCode]
public struct ShaderKeywordSet
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D81")]
	private IntPtr m_KeywordState; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000D82")]
	private IntPtr m_Shader; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D83")]
	private IntPtr m_ComputeShader; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000D84")]
	private ulong m_StateIndex; //Field offset: 0x18

	[Address(RVA = "0x30CB880", Offset = "0x30CAC80", Length = "0x90")]
	[Token(Token = "0x6001F1E")]
	private void CheckKeywordCompatible(ShaderKeyword keyword) { }

	[Address(RVA = "0x30CB950", Offset = "0x30CAD50", Length = "0x33")]
	[FreeFunction("keywords::GetEnabledKeywords")]
	[Token(Token = "0x6001F1D")]
	private static ShaderKeyword[] GetEnabledKeywords(ShaderKeywordSet state) { }

	[Address(RVA = "0x30CB910", Offset = "0x30CAD10", Length = "0x33")]
	[Token(Token = "0x6001F23")]
	private static ShaderKeyword[] GetEnabledKeywords_Injected(in ShaderKeywordSet state) { }

	[Address(RVA = "0x30CB990", Offset = "0x30CAD90", Length = "0xC7")]
	[Token(Token = "0x6001F1F")]
	public bool IsEnabled(ShaderKeyword keyword) { }

	[Address(RVA = "0x30CBAB0", Offset = "0x30CAEB0", Length = "0x19C")]
	[FreeFunction("keywords::IsKeywordEnabled")]
	[Token(Token = "0x6001F1C")]
	private static bool IsKeywordNameEnabled(ShaderKeywordSet state, string name) { }

	[Address(RVA = "0x30CBA60", Offset = "0x30CAE60", Length = "0x42")]
	[Token(Token = "0x6001F22")]
	private static bool IsKeywordNameEnabled_Injected(in ShaderKeywordSet state, ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x30CBC50", Offset = "0x30CB050", Length = "0x20")]
	[Token(Token = "0x6001F21")]
	private static int ShaderKeywordComparer(ShaderKeyword kw1, ShaderKeyword kw2) { }

	[Address(RVA = "0x30CBC80", Offset = "0x30CB080", Length = "0xDB")]
	[Token(Token = "0x6001F20")]
	public virtual string ToString() { }

}

