namespace UnityEngine;

[Token(Token = "0x20000BA")]
[UsedByNativeCode(Name = "ExposedReference")]
public struct ExposedReference
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000217")]
	public PropertyName exposedName; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000218")]
	public object defaultValue; //Field offset: 0x0

	[Address(RVA = "0x1BB01A0", Offset = "0x1BAF5A0", Length = "0x127")]
	[Token(Token = "0x6000537")]
	public T Resolve(IExposedPropertyTable resolver) { }

}

