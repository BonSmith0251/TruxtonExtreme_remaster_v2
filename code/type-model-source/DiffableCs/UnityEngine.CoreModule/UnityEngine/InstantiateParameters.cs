namespace UnityEngine;

[Token(Token = "0x20001CE")]
public struct InstantiateParameters
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006A8")]
	public Transform parent; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40006A9")]
	public Scene scene; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40006AA")]
	public bool worldSpace; //Field offset: 0xC
	[FieldOffset(Offset = "0xD")]
	[Token(Token = "0x40006AB")]
	public bool originalImmutable; //Field offset: 0xD

}

