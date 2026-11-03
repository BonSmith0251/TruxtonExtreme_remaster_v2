namespace UnityEngine.InputSystem.EnhancedTouch;

[DefaultMember("Item")]
[Token(Token = "0x2000159")]
public struct TouchHistory : IReadOnlyList<Touch>, IEnumerable<Touch>, IEnumerable, IReadOnlyCollection<Touch>
{
	[Token(Token = "0x200015A")]
	private class Enumerator : IEnumerator<Touch>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40008A7")]
		private readonly TouchHistory m_Owner; //Field offset: 0x10
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40008A8")]
		private int m_Index; //Field offset: 0x30

		[Token(Token = "0x17000413")]
		public override Touch Current
		{
			[Address(RVA = "0x29EF8C0", Offset = "0x29EECC0", Length = "0x4A")]
			[Token(Token = "0x6000F1F")]
			 get { } //Length: 74
		}

		[Token(Token = "0x17000414")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x29EF6F0", Offset = "0x29EEAF0", Length = "0x77")]
			[Token(Token = "0x6000F20")]
			private get { } //Length: 119
		}

		[Address(RVA = "0x29EF800", Offset = "0x29EEC00", Length = "0x43")]
		[Token(Token = "0x6000F1C")]
		internal Enumerator(TouchHistory owner) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000F21")]
		public override void Dispose() { }

		[Address(RVA = "0x29EF8C0", Offset = "0x29EECC0", Length = "0x4A")]
		[Token(Token = "0x6000F1F")]
		public override Touch get_Current() { }

		[Address(RVA = "0x29EF5E0", Offset = "0x29EE9E0", Length = "0x20")]
		[Token(Token = "0x6000F1D")]
		public override bool MoveNext() { }

		[Address(RVA = "0x29EF680", Offset = "0x29EEA80", Length = "0x8")]
		[Token(Token = "0x6000F1E")]
		public override void Reset() { }

		[Address(RVA = "0x29EF6F0", Offset = "0x29EEAF0", Length = "0x77")]
		[Token(Token = "0x6000F20")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008A2")]
	private readonly InputStateHistory<TouchState> m_History; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40008A3")]
	private readonly Finger m_Finger; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40008A4")]
	private readonly int m_Count; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40008A5")]
	private readonly int m_StartIndex; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40008A6")]
	private readonly uint m_Version; //Field offset: 0x18

	[Token(Token = "0x17000411")]
	public override int Count
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000F19")]
		 get { } //Length: 85
	}

	[Token(Token = "0x17000412")]
	public override Touch Item
	{
		[Address(RVA = "0x29FCD00", Offset = "0x29FC100", Length = "0x154")]
		[Token(Token = "0x6000F1A")]
		 get { } //Length: 340
	}

	[Address(RVA = "0x29FCC80", Offset = "0x29FC080", Length = "0x7D")]
	[Token(Token = "0x6000F16")]
	internal TouchHistory(Finger finger, InputStateHistory<TouchState> history, int startIndex = -1, int count = -1) { }

	[Address(RVA = "0x29FCB30", Offset = "0x29FBF30", Length = "0xB5")]
	[Token(Token = "0x6000F1B")]
	internal void CheckValid() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000F19")]
	public override int get_Count() { }

	[Address(RVA = "0x29FCD00", Offset = "0x29FC100", Length = "0x154")]
	[Token(Token = "0x6000F1A")]
	public override Touch get_Item(int index) { }

	[Address(RVA = "0x29FCBF0", Offset = "0x29FBFF0", Length = "0x7C")]
	[Token(Token = "0x6000F17")]
	public override IEnumerator<Touch> GetEnumerator() { }

	[Address(RVA = "0x29FCC70", Offset = "0x29FC070", Length = "0x7")]
	[Token(Token = "0x6000F18")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

