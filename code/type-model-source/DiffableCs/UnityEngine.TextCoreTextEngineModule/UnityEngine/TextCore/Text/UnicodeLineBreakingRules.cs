namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000071")]
public class UnicodeLineBreakingRules
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x40004CD")]
	private TextAsset m_UnicodeLineBreakingRules; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40004CE")]
	private TextAsset m_LeadingCharacters; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40004CF")]
	private TextAsset m_FollowingCharacters; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40004D0")]
	private bool m_UseModernHangulLineBreakingRules; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004D1")]
	private HashSet<UInt32> m_LeadingCharactersLookup; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40004D2")]
	private HashSet<UInt32> m_FollowingCharactersLookup; //Field offset: 0x38

	[Token(Token = "0x1700008D")]
	internal HashSet<UInt32> followingCharactersLookup
	{
		[Address(RVA = "0x31C9AA0", Offset = "0x31C8EA0", Length = "0x2B")]
		[Token(Token = "0x6000348")]
		internal get { } //Length: 43
	}

	[Token(Token = "0x1700008C")]
	internal HashSet<UInt32> leadingCharactersLookup
	{
		[Address(RVA = "0x31C9AD0", Offset = "0x31C8ED0", Length = "0x78")]
		[Token(Token = "0x6000347")]
		internal get { } //Length: 120
	}

	[Token(Token = "0x1700008E")]
	public bool useModernHangulLineBreakingRules
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x6000349")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600034C")]
	public UnicodeLineBreakingRules() { }

	[Address(RVA = "0x31C9AA0", Offset = "0x31C8EA0", Length = "0x2B")]
	[Token(Token = "0x6000348")]
	internal HashSet<UInt32> get_followingCharactersLookup() { }

	[Address(RVA = "0x31C9AD0", Offset = "0x31C8ED0", Length = "0x78")]
	[Token(Token = "0x6000347")]
	internal HashSet<UInt32> get_leadingCharactersLookup() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[Token(Token = "0x6000349")]
	public bool get_useModernHangulLineBreakingRules() { }

	[Address(RVA = "0x31C97E0", Offset = "0x31C8BE0", Length = "0xC7")]
	[Token(Token = "0x600034B")]
	private static HashSet<UInt32> GetCharacters(TextAsset file) { }

	[Address(RVA = "0x31C98B0", Offset = "0x31C8CB0", Length = "0x1E6")]
	[Token(Token = "0x600034A")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal void LoadLineBreakingRules() { }

}

