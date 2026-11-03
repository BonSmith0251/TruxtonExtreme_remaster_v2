namespace TMPro;

[ExcludeFromPreset]
[Token(Token = "0x2000091")]
public class TMP_StyleSheet : ScriptableObject
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40004AB")]
	private List<TMP_Style> m_StyleList; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004AC")]
	private Dictionary<Int32, TMP_Style> m_StyleLookupDictionary; //Field offset: 0x20

	[Token(Token = "0x17000111")]
	internal List<TMP_Style> styles
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60004D3")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x2F133B0", Offset = "0x2F127B0", Length = "0x7C")]
	[Token(Token = "0x60004D9")]
	public TMP_StyleSheet() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60004D3")]
	internal List<TMP_Style> get_styles() { }

	[Address(RVA = "0x2F12FD0", Offset = "0x2F123D0", Length = "0x86")]
	[Token(Token = "0x60004D5")]
	public TMP_Style GetStyle(int hashCode) { }

	[Address(RVA = "0x2F12F10", Offset = "0x2F12310", Length = "0xB1")]
	[Token(Token = "0x60004D6")]
	public TMP_Style GetStyle(string name) { }

	[Address(RVA = "0x2F13060", Offset = "0x2F12460", Length = "0x335")]
	[Token(Token = "0x60004D8")]
	private void LoadStyleDictionaryInternal() { }

	[Address(RVA = "0x2F133A0", Offset = "0x2F127A0", Length = "0x7")]
	[Token(Token = "0x60004D7")]
	public void RefreshStyles() { }

	[Address(RVA = "0x2F133A0", Offset = "0x2F127A0", Length = "0x7")]
	[Token(Token = "0x60004D4")]
	private void Reset() { }

}

