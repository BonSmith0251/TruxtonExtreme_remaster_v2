namespace UnityEngine.TextCore.Text;

[IsReadOnly]
[Token(Token = "0x2000050")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEngine.IMGUIModule", "UnityEditor.GraphToolsFoundationModule"})]
internal struct RenderedText : IEquatable<RenderedText>, IEquatable<String>
{
	[Token(Token = "0x2000051")]
	internal struct Enumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000320")]
		private readonly RenderedText m_Source; //Field offset: 0x0
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000321")]
		private int m_Stage; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000322")]
		private int m_StageIndex; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000323")]
		private char m_Current; //Field offset: 0x28

		[Token(Token = "0x1700006C")]
		public char Current
		{
			[Address(RVA = "0x31AE590", Offset = "0x31AD990", Length = "0x5")]
			[Token(Token = "0x6000233")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x31AE560", Offset = "0x31AD960", Length = "0x2E")]
		[Token(Token = "0x6000234")]
		public Enumerator(in RenderedText source) { }

		[Address(RVA = "0x31AE590", Offset = "0x31AD990", Length = "0x5")]
		[Token(Token = "0x6000233")]
		public char get_Current() { }

		[Address(RVA = "0x31AE480", Offset = "0x31AD880", Length = "0xD7")]
		[Token(Token = "0x6000235")]
		public bool MoveNext() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400031A")]
	public readonly string value; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400031B")]
	public readonly int valueStart; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400031C")]
	public readonly int valueLength; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400031D")]
	public readonly string suffix; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400031E")]
	public readonly char repeat; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400031F")]
	public readonly int repeatCount; //Field offset: 0x1C

	[Token(Token = "0x1700006B")]
	public int CharacterCount
	{
		[Address(RVA = "0x31B0D10", Offset = "0x31B0110", Length = "0x15")]
		[Token(Token = "0x600022C")]
		 get { } //Length: 21
	}

	[Address(RVA = "0x31B0A50", Offset = "0x31AFE50", Length = "0xBF")]
	[Token(Token = "0x6000228")]
	public RenderedText(string value) { }

	[Address(RVA = "0x31B0BD0", Offset = "0x31AFFD0", Length = "0xCF")]
	[Token(Token = "0x6000229")]
	public RenderedText(string value, string suffix) { }

	[Address(RVA = "0x31B0B10", Offset = "0x31AFF10", Length = "0xBB")]
	[Token(Token = "0x600022A")]
	public RenderedText(string value, int start, int length, string suffix = null) { }

	[Address(RVA = "0x31B0CA0", Offset = "0x31B00A0", Length = "0x6F")]
	[Token(Token = "0x600022B")]
	public RenderedText(char repeat, int repeatCount, string suffix = null) { }

	[Address(RVA = "0x31B0460", Offset = "0x31AF860", Length = "0x18A")]
	[Token(Token = "0x600022E")]
	public string CreateString() { }

	[Address(RVA = "0x31B05F0", Offset = "0x31AF9F0", Length = "0x80")]
	[Token(Token = "0x600022F")]
	public override bool Equals(RenderedText other) { }

	[Address(RVA = "0x31B0860", Offset = "0x31AFC60", Length = "0xF6")]
	[Token(Token = "0x6000230")]
	public override bool Equals(string other) { }

	[Address(RVA = "0x31B0670", Offset = "0x31AFA70", Length = "0x1ED")]
	[Token(Token = "0x6000231")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x31B0D10", Offset = "0x31B0110", Length = "0x15")]
	[Token(Token = "0x600022C")]
	public int get_CharacterCount() { }

	[Address(RVA = "0x31B0960", Offset = "0x31AFD60", Length = "0x3F")]
	[Token(Token = "0x600022D")]
	public Enumerator GetEnumerator() { }

	[Address(RVA = "0x31B09A0", Offset = "0x31AFDA0", Length = "0xAC")]
	[Token(Token = "0x6000232")]
	public virtual int GetHashCode() { }

}

