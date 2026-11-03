namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[Token(Token = "0x2000405")]
[UsedByNativeCode]
public struct ShaderKeyword
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D7C")]
	internal string m_Name; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000D7D")]
	internal uint m_Index; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000D7E")]
	internal bool m_IsLocal; //Field offset: 0xC
	[FieldOffset(Offset = "0xD")]
	[Token(Token = "0x4000D7F")]
	internal bool m_IsCompute; //Field offset: 0xD
	[FieldOffset(Offset = "0xE")]
	[Token(Token = "0x4000D80")]
	internal bool m_IsValid; //Field offset: 0xE

	[Token(Token = "0x1700049F")]
	public string name
	{
		[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
		[Token(Token = "0x6001F17")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x30CC120", Offset = "0x30CB520", Length = "0x82")]
	[Token(Token = "0x6001F18")]
	public ShaderKeyword(string keywordName) { }

	[Address(RVA = "0x30CBDA0", Offset = "0x30CB1A0", Length = "0x178")]
	[FreeFunction("ShaderScripting::CreateGlobalKeyword")]
	[Token(Token = "0x6001F16")]
	internal static void CreateGlobalKeyword(string keyword) { }

	[Address(RVA = "0x30CBD60", Offset = "0x30CB160", Length = "0x33")]
	[Token(Token = "0x6001F1B")]
	private static void CreateGlobalKeyword_Injected(ref ManagedSpanWrapper keyword) { }

	[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
	[Token(Token = "0x6001F17")]
	public string get_name() { }

	[Address(RVA = "0x30CBF20", Offset = "0x30CB320", Length = "0x2A")]
	[FreeFunction("ShaderScripting::GetGlobalKeywordCount")]
	[Token(Token = "0x6001F14")]
	internal static uint GetGlobalKeywordCount() { }

	[Address(RVA = "0x30CBF90", Offset = "0x30CB390", Length = "0x18C")]
	[FreeFunction("ShaderScripting::GetGlobalKeywordIndex")]
	[Token(Token = "0x6001F15")]
	internal static uint GetGlobalKeywordIndex(string keyword) { }

	[Address(RVA = "0x30CBF50", Offset = "0x30CB350", Length = "0x33")]
	[Token(Token = "0x6001F1A")]
	private static uint GetGlobalKeywordIndex_Injected(ref ManagedSpanWrapper keyword) { }

	[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
	[Token(Token = "0x6001F19")]
	public virtual string ToString() { }

}

