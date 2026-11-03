namespace Newtonsoft.Json.Linq;

[DefaultMember("Item")]
[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
[NullableContext(1)]
[Token(Token = "0x2000179")]
internal class JPropertyKeyedCollection : Collection<JToken>
{
	[Token(Token = "0x40006F1")]
	private static readonly IEqualityComparer<String> Comparer; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1})]
	[Token(Token = "0x40006F2")]
	private Dictionary<String, JToken> _dictionary; //Field offset: 0x18

	[Token(Token = "0x17000207")]
	public JToken Item
	{
		[Address(RVA = "0x217BAF0", Offset = "0x217AEF0", Length = "0xE5")]
		[Token(Token = "0x6000C83")]
		 get { } //Length: 229
	}

	[Token(Token = "0x17000208")]
	public ICollection<String> Keys
	{
		[Address(RVA = "0x217BBE0", Offset = "0x217AFE0", Length = "0x4E")]
		[Token(Token = "0x6000C85")]
		 get { } //Length: 78
	}

	[Token(Token = "0x17000209")]
	public ICollection<JToken> Values
	{
		[Address(RVA = "0x217BC30", Offset = "0x217B030", Length = "0x4E")]
		[Token(Token = "0x6000C86")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x217B9C0", Offset = "0x217ADC0", Length = "0xAC")]
	[Token(Token = "0x6000C89")]
	private static JPropertyKeyedCollection() { }

	[Address(RVA = "0x217BA70", Offset = "0x217AE70", Length = "0x7B")]
	[Token(Token = "0x6000C76")]
	public JPropertyKeyedCollection() { }

	[Address(RVA = "0x217A940", Offset = "0x2179D40", Length = "0x6D")]
	[Token(Token = "0x6000C77")]
	private void AddKey(string key, JToken item) { }

	[Address(RVA = "0x217A9B0", Offset = "0x2179DB0", Length = "0x23A")]
	[Token(Token = "0x6000C78")]
	protected void ChangeItemKey(JToken item, string newKey) { }

	[Address(RVA = "0x217ABF0", Offset = "0x2179FF0", Length = "0x60")]
	[Token(Token = "0x6000C79")]
	protected virtual void ClearItems() { }

	[Address(RVA = "0x217AC50", Offset = "0x217A050", Length = "0x39E")]
	[Token(Token = "0x6000C88")]
	public bool Compare(JPropertyKeyedCollection other) { }

	[Address(RVA = "0x217B0C0", Offset = "0x217A4C0", Length = "0xAA")]
	[Token(Token = "0x6000C7A")]
	public bool Contains(string key) { }

	[Address(RVA = "0x217AFF0", Offset = "0x217A3F0", Length = "0xCC")]
	[Token(Token = "0x6000C7B")]
	private bool ContainsItem(JToken item) { }

	[Address(RVA = "0x217B170", Offset = "0x217A570", Length = "0xB8")]
	[Token(Token = "0x6000C7C")]
	private void EnsureDictionary() { }

	[Address(RVA = "0x217BAF0", Offset = "0x217AEF0", Length = "0xE5")]
	[Token(Token = "0x6000C83")]
	public JToken get_Item(string key) { }

	[Address(RVA = "0x217BBE0", Offset = "0x217AFE0", Length = "0x4E")]
	[Token(Token = "0x6000C85")]
	public ICollection<String> get_Keys() { }

	[Address(RVA = "0x217BC30", Offset = "0x217B030", Length = "0x4E")]
	[Token(Token = "0x6000C86")]
	public ICollection<JToken> get_Values() { }

	[Address(RVA = "0x217B230", Offset = "0x217A630", Length = "0x6D")]
	[Token(Token = "0x6000C7D")]
	private string GetKeyForItem(JToken item) { }

	[Address(RVA = "0x217B2A0", Offset = "0x217A6A0", Length = "0x9A")]
	[Token(Token = "0x6000C87")]
	public int IndexOfReference(JToken t) { }

	[Address(RVA = "0x217B340", Offset = "0x217A740", Length = "0x107")]
	[Token(Token = "0x6000C7E")]
	protected virtual void InsertItem(int index, JToken item) { }

	[Address(RVA = "0x217B5C0", Offset = "0x217A9C0", Length = "0xDD")]
	[Token(Token = "0x6000C7F")]
	public bool Remove(string key) { }

	[Address(RVA = "0x217B450", Offset = "0x217A850", Length = "0x11B")]
	[Token(Token = "0x6000C80")]
	protected virtual void RemoveItem(int index) { }

	[Address(RVA = "0x217B570", Offset = "0x217A970", Length = "0x4F")]
	[Token(Token = "0x6000C81")]
	private void RemoveKey(string key) { }

	[Address(RVA = "0x217B6A0", Offset = "0x217AAA0", Length = "0x282")]
	[Token(Token = "0x6000C82")]
	protected virtual void SetItem(int index, JToken item) { }

	[Address(RVA = "0x217B930", Offset = "0x217AD30", Length = "0x83")]
	[Token(Token = "0x6000C84")]
	public bool TryGetValue(string key, out JToken value) { }

}

