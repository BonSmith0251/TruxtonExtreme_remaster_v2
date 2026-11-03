namespace UnityEngine.UIElements;

[Token(Token = "0x2000182")]
internal class AncestorFilter
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400076E")]
	private CountingBloomFilter m_CountingBloomFilter; //Field offset: 0x10
	[FieldOffset(Offset = "0x4010")]
	[Token(Token = "0x400076F")]
	private Stack<Int32> m_HashStack; //Field offset: 0x4010

	[Address(RVA = "0x33ABF70", Offset = "0x33AB370", Length = "0x82")]
	[Token(Token = "0x6000B81")]
	public AncestorFilter() { }

	[Address(RVA = "0x33ABB90", Offset = "0x33AAF90", Length = "0x7B")]
	[Token(Token = "0x6000B82")]
	private void AddHash(int hash) { }

	[Address(RVA = "0x33ABC10", Offset = "0x33AB010", Length = "0x67")]
	[Token(Token = "0x6000B83")]
	public bool IsCandidate(StyleComplexSelector complexSel) { }

	[Address(RVA = "0x33ABC80", Offset = "0x33AB080", Length = "0xDC")]
	[Token(Token = "0x6000B85")]
	public void PopElement() { }

	[Address(RVA = "0x33ABD60", Offset = "0x33AB160", Length = "0x205")]
	[Token(Token = "0x6000B84")]
	public void PushElement(VisualElement element) { }

}

