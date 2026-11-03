namespace UnityEngine.Rendering;

[IsReadOnly]
[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
[Token(Token = "0x2000402")]
public struct LocalKeywordSpace : IEquatable<LocalKeywordSpace>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D7B")]
	private readonly IntPtr m_KeywordSpace; //Field offset: 0x0

	[Token(Token = "0x1700049D")]
	public uint keywordCount
	{
		[Address(RVA = "0x30C2580", Offset = "0x30C1980", Length = "0x33")]
		[Token(Token = "0x6001F0C")]
		 get { } //Length: 51
	}

	[Address(RVA = "0x30C24F0", Offset = "0x30C18F0", Length = "0x83")]
	[Token(Token = "0x6001F0D")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0xFD2260", Offset = "0xFD1660", Length = "0x9")]
	[Token(Token = "0x6001F0E")]
	public override bool Equals(LocalKeywordSpace rhs) { }

	[Address(RVA = "0x30C2580", Offset = "0x30C1980", Length = "0x33")]
	[Token(Token = "0x6001F0C")]
	public uint get_keywordCount() { }

	[Address(RVA = "0x2FF3D00", Offset = "0x2FF3100", Length = "0x9")]
	[Token(Token = "0x6001F10")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x30C2580", Offset = "0x30C1980", Length = "0x33")]
	[FreeFunction("keywords::GetKeywordCount", HasExplicitThis = True)]
	[Token(Token = "0x6001F0B")]
	private uint GetKeywordCount() { }

	[Address(RVA = "0x30C25C0", Offset = "0x30C19C0", Length = "0x9")]
	[Token(Token = "0x6001F0F")]
	public static bool op_Equality(LocalKeywordSpace lhs, LocalKeywordSpace rhs) { }

}

