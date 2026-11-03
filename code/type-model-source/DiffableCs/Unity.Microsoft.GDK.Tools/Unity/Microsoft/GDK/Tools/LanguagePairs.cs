namespace Unity.Microsoft.GDK.Tools;

[Token(Token = "0x2000033")]
public class LanguagePairs : ISerializationCallbackReceiver
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000125")]
	private Dictionary<String, Boolean> _dict; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000126")]
	private List<String> keys; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000127")]
	private List<Boolean> values; //Field offset: 0x20

	[Address(RVA = "0x2B6DCD0", Offset = "0x2B6D0D0", Length = "0x10D")]
	[Token(Token = "0x60001C8")]
	public LanguagePairs() { }

	[Address(RVA = "0x2B6CD40", Offset = "0x2B6C140", Length = "0x317")]
	[Token(Token = "0x60001C9")]
	public void Clear() { }

	[Address(RVA = "0x2B6D060", Offset = "0x2B6C460", Length = "0xA3")]
	[Token(Token = "0x60001D0")]
	private string EnumName(GameConfigLanguages lang) { }

	[Address(RVA = "0x2B6D110", Offset = "0x2B6C510", Length = "0x4D4")]
	[Token(Token = "0x60001CF")]
	public void ExportToXml(Game xmlGameConfig) { }

	[Address(RVA = "0x2B6D5F0", Offset = "0x2B6C9F0", Length = "0x144")]
	[Token(Token = "0x60001CE")]
	public void ImportFromXml(Game xmlGameConfig) { }

	[Address(RVA = "0x2B6D7B0", Offset = "0x2B6CBB0", Length = "0x75")]
	[Token(Token = "0x60001CC")]
	public bool IsLanguagePairSet(GameConfigLanguages lang) { }

	[Address(RVA = "0x2B6D740", Offset = "0x2B6CB40", Length = "0x6D")]
	[Token(Token = "0x60001CD")]
	public bool IsLanguagePairSet(string langName) { }

	[Address(RVA = "0x2B6D830", Offset = "0x2B6CC30", Length = "0x10E")]
	[Token(Token = "0x60001C7")]
	public override void OnAfterDeserialize() { }

	[Address(RVA = "0x2B6D940", Offset = "0x2B6CD40", Length = "0x2B2")]
	[Token(Token = "0x60001C6")]
	public override void OnBeforeSerialize() { }

	[Address(RVA = "0x2B6DC00", Offset = "0x2B6D000", Length = "0x35")]
	[Token(Token = "0x60001CA")]
	public void SetLanguagePair(GameConfigLanguages lang, bool isActive) { }

	[Address(RVA = "0x2B6DC40", Offset = "0x2B6D040", Length = "0x8E")]
	[Token(Token = "0x60001CB")]
	public void SetLanguagePair(string langName, bool isActive) { }

}

