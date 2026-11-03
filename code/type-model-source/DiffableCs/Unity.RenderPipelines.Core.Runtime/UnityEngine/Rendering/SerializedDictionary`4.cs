namespace UnityEngine.Rendering;

[Token(Token = "0x2000068")]
public abstract class SerializedDictionary : Dictionary<K, V>, ISerializationCallbackReceiver
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000159")]
	private List<SK> m_Keys; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x400015A")]
	private List<SV> m_Values; //Field offset: 0x0

	[Address(RVA = "0xF5C5D0", Offset = "0xF5B9D0", Length = "0xE8")]
	[Token(Token = "0x600057B")]
	protected SerializedDictionary`4() { }

	[Token(Token = "0x6000577")]
	public abstract K DeserializeKey(SK serializedKey) { }

	[Token(Token = "0x6000578")]
	public abstract V DeserializeValue(SV serializedValue) { }

	[Address(RVA = "0xF5A470", Offset = "0xF59870", Length = "0x121")]
	[Token(Token = "0x600057A")]
	public override void OnAfterDeserialize() { }

	[Address(RVA = "0xF5B210", Offset = "0xF5A610", Length = "0x2D5")]
	[Token(Token = "0x6000579")]
	public override void OnBeforeSerialize() { }

	[Token(Token = "0x6000575")]
	public abstract SK SerializeKey(K key) { }

	[Token(Token = "0x6000576")]
	public abstract SV SerializeValue(V value) { }

}

