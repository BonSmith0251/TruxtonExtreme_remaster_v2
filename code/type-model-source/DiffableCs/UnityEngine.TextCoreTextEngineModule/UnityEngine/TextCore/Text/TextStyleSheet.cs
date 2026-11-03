namespace UnityEngine.TextCore.Text;

[ExcludeFromObjectFactory]
[ExcludeFromPreset]
[Token(Token = "0x2000041")]
public class TextStyleSheet : ScriptableObject
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40001C2")]
	private List<TextStyle> m_StyleList; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001C3")]
	private Dictionary<Int32, TextStyle> m_StyleLookupDictionary; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001C4")]
	private object styleLookupLock; //Field offset: 0x28

	[Token(Token = "0x1700005B")]
	internal List<TextStyle> styles
	{
		[Address(RVA = "0x198AF30", Offset = "0x198A330", Length = "0x7")]
		[Token(Token = "0x60001D6")]
		internal get { } //Length: 7
	}

	[Address(RVA = "0x31C3420", Offset = "0x31C2820", Length = "0xB1")]
	[Token(Token = "0x60001DC")]
	public TextStyleSheet() { }

	[Address(RVA = "0x198AF30", Offset = "0x198A330", Length = "0x7")]
	[Token(Token = "0x60001D6")]
	internal List<TextStyle> get_styles() { }

	[Address(RVA = "0x31C2F10", Offset = "0x31C2310", Length = "0x11A")]
	[Token(Token = "0x60001D8")]
	public TextStyle GetStyle(int hashCode) { }

	[Address(RVA = "0x31C3030", Offset = "0x31C2430", Length = "0x91")]
	[Token(Token = "0x60001D9")]
	public TextStyle GetStyle(string name) { }

	[Address(RVA = "0x31C30D0", Offset = "0x31C24D0", Length = "0x33E")]
	[Token(Token = "0x60001DB")]
	private void LoadStyleDictionaryInternal() { }

	[Address(RVA = "0x31C3410", Offset = "0x31C2810", Length = "0x7")]
	[Token(Token = "0x60001DA")]
	public void RefreshStyles() { }

	[Address(RVA = "0x31C3410", Offset = "0x31C2810", Length = "0x7")]
	[Token(Token = "0x60001D7")]
	private void Reset() { }

}

