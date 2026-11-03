namespace UnityEngine.Splines;

[Token(Token = "0x2000035")]
internal class SplineDataKeyValuePair
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000C4")]
	public string Key; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000C5")]
	public SplineData<T> Value; //Field offset: 0x0

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60001D7")]
	public SplineDataKeyValuePair`1() { }

}

