namespace UnityEngine.Rendering;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(SerializedDictionaryDebugView`2))]
[Token(Token = "0x2000067")]
public class SerializedDictionary : SerializedDictionary<K, V, K, V>
{

	[Address(RVA = "0xF5A010", Offset = "0xF59410", Length = "0xF4")]
	[Token(Token = "0x6000574")]
	public SerializedDictionary`2() { }

	[Address(RVA = "0xF59E80", Offset = "0xF59280", Length = "0x3")]
	[Token(Token = "0x6000572")]
	public virtual K DeserializeKey(K key) { }

	[Address(RVA = "0xA50320", Offset = "0xA4F720", Length = "0x4")]
	[Token(Token = "0x6000573")]
	public virtual V DeserializeValue(V val) { }

	[Address(RVA = "0xF59E80", Offset = "0xF59280", Length = "0x3")]
	[Token(Token = "0x6000570")]
	public virtual K SerializeKey(K key) { }

	[Address(RVA = "0xA50320", Offset = "0xA4F720", Length = "0x4")]
	[Token(Token = "0x6000571")]
	public virtual V SerializeValue(V val) { }

}

