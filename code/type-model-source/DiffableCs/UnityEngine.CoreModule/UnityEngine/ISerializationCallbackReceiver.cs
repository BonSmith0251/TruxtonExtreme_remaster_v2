namespace UnityEngine;

[RequiredByNativeCode]
[Token(Token = "0x20001DF")]
public interface ISerializationCallbackReceiver
{

	[RequiredByNativeCode]
	[Token(Token = "0x60014D0")]
	public void OnAfterDeserialize() { }

	[RequiredByNativeCode]
	[Token(Token = "0x60014CF")]
	public void OnBeforeSerialize() { }

}

