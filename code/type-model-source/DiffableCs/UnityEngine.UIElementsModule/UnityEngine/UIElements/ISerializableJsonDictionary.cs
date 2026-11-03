namespace UnityEngine.UIElements;

[Token(Token = "0x200029B")]
internal interface ISerializableJsonDictionary
{

	[Token(Token = "0x6001236")]
	public bool ContainsKey(string key) { }

	[Token(Token = "0x6001234")]
	public T Get(string key) { }

	[Token(Token = "0x6001235")]
	public void Overwrite(object obj, string key) { }

	[Token(Token = "0x6001233")]
	public void Set(string key, T value) { }

}

