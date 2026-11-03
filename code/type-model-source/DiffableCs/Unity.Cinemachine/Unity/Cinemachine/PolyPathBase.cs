namespace Unity.Cinemachine;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000182")]
internal abstract class PolyPathBase : IEnumerable
{
	[FieldOffset(Offset = "0x10")]
	[Nullable(2)]
	[Token(Token = "0x400067F")]
	internal PolyPathBase _parent; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000680")]
	internal List<PolyPathBase> _childs; //Field offset: 0x18

	[Token(Token = "0x17000151")]
	public int Count
	{
		[Address(RVA = "0x28A56B0", Offset = "0x28A4AB0", Length = "0x3C")]
		[Token(Token = "0x600080D")]
		 get { } //Length: 60
	}

	[Token(Token = "0x17000150")]
	public bool IsHole
	{
		[Address(RVA = "0x28A55F0", Offset = "0x28A49F0", Length = "0x1C")]
		[Token(Token = "0x600080A")]
		 get { } //Length: 28
	}

	[Address(RVA = "0x28A5610", Offset = "0x28A4A10", Length = "0x94")]
	[NullableContext(2)]
	[Token(Token = "0x600080B")]
	public PolyPathBase(PolyPathBase parent = null) { }

	[Token(Token = "0x600080E")]
	internal abstract PolyPathBase AddChild(List<Point64> p) { }

	[Address(RVA = "0x28A5520", Offset = "0x28A4920", Length = "0x5F")]
	[Token(Token = "0x600080F")]
	public void Clear() { }

	[Address(RVA = "0x28A56B0", Offset = "0x28A4AB0", Length = "0x3C")]
	[Token(Token = "0x600080D")]
	public int get_Count() { }

	[Address(RVA = "0x28A55F0", Offset = "0x28A49F0", Length = "0x1C")]
	[Token(Token = "0x600080A")]
	public bool get_IsHole() { }

	[Address(RVA = "0x28A5580", Offset = "0x28A4980", Length = "0x6B")]
	[Token(Token = "0x6000808")]
	public PolyPathEnum GetEnumerator() { }

	[Address(RVA = "0x28A55F0", Offset = "0x28A49F0", Length = "0x1C")]
	[Token(Token = "0x600080C")]
	private bool GetIsHole() { }

	[Address(RVA = "0x28A5580", Offset = "0x28A4980", Length = "0x6B")]
	[Token(Token = "0x6000809")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

