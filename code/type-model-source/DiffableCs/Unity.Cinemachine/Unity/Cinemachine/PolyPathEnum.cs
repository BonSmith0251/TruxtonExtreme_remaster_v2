namespace Unity.Cinemachine;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000183")]
internal class PolyPathEnum : IEnumerator
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000681")]
	public List<PolyPathBase> _ppbList; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000682")]
	private int position; //Field offset: 0x18

	[Token(Token = "0x17000152")]
	public PolyPathBase Current
	{
		[Address(RVA = "0x28A5C30", Offset = "0x28A5030", Length = "0x9E")]
		[Token(Token = "0x6000813")]
		 get { } //Length: 158
	}

	[Token(Token = "0x17000153")]
	private override object System.Collections.IEnumerator.Current
	{
		[Address(RVA = "0x28A5C30", Offset = "0x28A5030", Length = "0x9E")]
		[Token(Token = "0x6000814")]
		private get { } //Length: 158
	}

	[Address(RVA = "0x2536CB0", Offset = "0x25360B0", Length = "0x38")]
	[Token(Token = "0x6000810")]
	public PolyPathEnum(List<PolyPathBase> childs) { }

	[Address(RVA = "0x28A5C30", Offset = "0x28A5030", Length = "0x9E")]
	[Token(Token = "0x6000813")]
	public PolyPathBase get_Current() { }

	[Address(RVA = "0x28A5BE0", Offset = "0x28A4FE0", Length = "0x47")]
	[Token(Token = "0x6000811")]
	public override bool MoveNext() { }

	[Address(RVA = "0x195A120", Offset = "0x1959520", Length = "0x8")]
	[Token(Token = "0x6000812")]
	public override void Reset() { }

	[Address(RVA = "0x28A5C30", Offset = "0x28A5030", Length = "0x9E")]
	[Token(Token = "0x6000814")]
	private override object System.Collections.IEnumerator.get_Current() { }

}

