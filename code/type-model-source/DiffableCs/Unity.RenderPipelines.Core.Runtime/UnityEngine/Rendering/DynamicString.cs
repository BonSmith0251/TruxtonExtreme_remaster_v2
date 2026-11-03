namespace UnityEngine.Rendering;

[DebuggerDisplay("Size = {size} Capacity = {capacity}")]
[Token(Token = "0x200004A")]
public class DynamicString : DynamicArray<Char>
{

	[Address(RVA = "0x2BE2FB0", Offset = "0x2BE23B0", Length = "0x39")]
	[Token(Token = "0x6000509")]
	public DynamicString() { }

	[Address(RVA = "0x2BE2EF0", Offset = "0x2BE22F0", Length = "0xB2")]
	[Token(Token = "0x600050A")]
	public DynamicString(string s) { }

	[Address(RVA = "0x2BE2FF0", Offset = "0x2BE23F0", Length = "0x49")]
	[Token(Token = "0x600050B")]
	public DynamicString(int capacity) { }

	[Address(RVA = "0x2BE2DA0", Offset = "0x2BE21A0", Length = "0xFB")]
	[Token(Token = "0x600050C")]
	public void Append(string s) { }

	[Address(RVA = "0x2BE2D50", Offset = "0x2BE2150", Length = "0x48")]
	[Token(Token = "0x600050D")]
	public void Append(DynamicString s) { }

	[Address(RVA = "0x2BE2EA0", Offset = "0x2BE22A0", Length = "0x46")]
	[Token(Token = "0x600050E")]
	public virtual string ToString() { }

}

