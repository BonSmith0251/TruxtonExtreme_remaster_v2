namespace UnityEngine.InputSystem.LowLevel;

[DefaultMember("Item")]
[Token(Token = "0x20001B6")]
public struct IMECompositionString : IEnumerable<Char>, IEnumerable
{
	[CompilerGenerated]
	[Token(Token = "0x20001B8")]
	[UnsafeValueType]
	internal struct <buffer>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A1E")]
		public char FixedElementField; //Field offset: 0x0

	}

	[Token(Token = "0x20001B7")]
	public struct Enumerator : IEnumerator<Char>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A1B")]
		private IMECompositionString m_CompositionString; //Field offset: 0x0
		[FieldOffset(Offset = "0x84")]
		[Token(Token = "0x4000A1C")]
		private char m_CurrentCharacter; //Field offset: 0x84
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000A1D")]
		private int m_CurrentIndex; //Field offset: 0x88

		[Token(Token = "0x170004A1")]
		public override char Current
		{
			[Address(RVA = "0x2144730", Offset = "0x2143B30", Length = "0x8")]
			[Token(Token = "0x600106A")]
			 get { } //Length: 8
		}

		[Token(Token = "0x170004A2")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x29EF770", Offset = "0x29EEB70", Length = "0x26")]
			[Token(Token = "0x600106B")]
			private get { } //Length: 38
		}

		[Address(RVA = "0x29EF7A0", Offset = "0x29EEBA0", Length = "0x5E")]
		[Token(Token = "0x6001066")]
		public Enumerator(IMECompositionString compositionString) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6001069")]
		public override void Dispose() { }

		[Address(RVA = "0x2144730", Offset = "0x2143B30", Length = "0x8")]
		[Token(Token = "0x600106A")]
		public override char get_Current() { }

		[Address(RVA = "0x29EF650", Offset = "0x29EEA50", Length = "0x2C")]
		[Token(Token = "0x6001067")]
		public override bool MoveNext() { }

		[Address(RVA = "0x29EF690", Offset = "0x29EEA90", Length = "0xB")]
		[Token(Token = "0x6001068")]
		public override void Reset() { }

		[Address(RVA = "0x29EF770", Offset = "0x29EEB70", Length = "0x26")]
		[Token(Token = "0x600106B")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A19")]
	private int size; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[FixedBuffer(typeof(char), 64)]
	[Token(Token = "0x4000A1A")]
	private <buffer>e__FixedBuffer buffer; //Field offset: 0x4

	[Token(Token = "0x1700049F")]
	public int Count
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x6001060")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170004A0")]
	public char Item
	{
		[Address(RVA = "0x29F65F0", Offset = "0x29F59F0", Length = "0x6B")]
		[Token(Token = "0x6001061")]
		 get { } //Length: 107
	}

	[Address(RVA = "0x29F6560", Offset = "0x29F5960", Length = "0x88")]
	[Token(Token = "0x6001062")]
	public IMECompositionString(string characters) { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x6001060")]
	public int get_Count() { }

	[Address(RVA = "0x29F65F0", Offset = "0x29F59F0", Length = "0x6B")]
	[Token(Token = "0x6001061")]
	public char get_Item(int index) { }

	[Address(RVA = "0x29F6450", Offset = "0x29F5850", Length = "0xCA")]
	[Token(Token = "0x6001064")]
	public override IEnumerator<Char> GetEnumerator() { }

	[Address(RVA = "0x29F6520", Offset = "0x29F5920", Length = "0x7")]
	[Token(Token = "0x6001065")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x29F6530", Offset = "0x29F5930", Length = "0x23")]
	[Token(Token = "0x6001063")]
	public virtual string ToString() { }

}

