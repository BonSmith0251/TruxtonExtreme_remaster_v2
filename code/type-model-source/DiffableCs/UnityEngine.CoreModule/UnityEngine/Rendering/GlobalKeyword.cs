namespace UnityEngine.Rendering;

[IsReadOnly]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
[Token(Token = "0x2000400")]
[UsedByNativeCode]
public struct GlobalKeyword
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D77")]
	internal readonly uint m_Index; //Field offset: 0x0

	[Token(Token = "0x1700049C")]
	public string name
	{
		[Address(RVA = "0x30BF120", Offset = "0x30BE520", Length = "0x9")]
		[Token(Token = "0x6001EF8")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x30BF130", Offset = "0x30BE530", Length = "0x116")]
	[Token(Token = "0x6001EF7")]
	public GlobalKeyword(string name) { }

	[Address(RVA = "0x30BEDF0", Offset = "0x30BE1F0", Length = "0x32")]
	[Token(Token = "0x6001EF6")]
	public static GlobalKeyword Create(string name) { }

	[Address(RVA = "0x30BEC70", Offset = "0x30BE070", Length = "0x178")]
	[FreeFunction("ShaderScripting::CreateGlobalKeyword")]
	[Token(Token = "0x6001EF4")]
	private static void CreateGlobalKeyword(string keyword) { }

	[Address(RVA = "0x30BEC30", Offset = "0x30BE030", Length = "0x33")]
	[Token(Token = "0x6001EFB")]
	private static void CreateGlobalKeyword_Injected(ref ManagedSpanWrapper keyword) { }

	[Address(RVA = "0x30BF120", Offset = "0x30BE520", Length = "0x9")]
	[Token(Token = "0x6001EF8")]
	public string get_name() { }

	[Address(RVA = "0x30BEE30", Offset = "0x30BE230", Length = "0x2A")]
	[FreeFunction("ShaderScripting::GetGlobalKeywordCount")]
	[Token(Token = "0x6001EF2")]
	private static uint GetGlobalKeywordCount() { }

	[Address(RVA = "0x30BEEA0", Offset = "0x30BE2A0", Length = "0x18C")]
	[FreeFunction("ShaderScripting::GetGlobalKeywordIndex")]
	[Token(Token = "0x6001EF3")]
	private static uint GetGlobalKeywordIndex(string keyword) { }

	[Address(RVA = "0x30BEE60", Offset = "0x30BE260", Length = "0x33")]
	[Token(Token = "0x6001EFA")]
	private static uint GetGlobalKeywordIndex_Injected(ref ManagedSpanWrapper keyword) { }

	[Address(RVA = "0x30BF070", Offset = "0x30BE470", Length = "0xAA")]
	[FreeFunction("ShaderScripting::GetGlobalKeywordName")]
	[Token(Token = "0x6001EF5")]
	private static string GetGlobalKeywordName(uint keywordIndex) { }

	[Address(RVA = "0x30BF030", Offset = "0x30BE430", Length = "0x40")]
	[Token(Token = "0x6001EFC")]
	private static void GetGlobalKeywordName_Injected(uint keywordIndex, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x30BF120", Offset = "0x30BE520", Length = "0x9")]
	[Token(Token = "0x6001EF9")]
	public virtual string ToString() { }

}

