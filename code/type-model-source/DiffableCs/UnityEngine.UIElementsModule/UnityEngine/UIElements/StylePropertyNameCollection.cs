namespace UnityEngine.UIElements;

[Token(Token = "0x2000240")]
public struct StylePropertyNameCollection : IEnumerable<StylePropertyName>, IEnumerable
{
	[Token(Token = "0x2000241")]
	internal struct Enumerator : IEnumerator<StylePropertyName>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008F0")]
		private Enumerator<StylePropertyName> m_Enumerator; //Field offset: 0x0

		[Token(Token = "0x170002DC")]
		public override StylePropertyName Current
		{
			[Address(RVA = "0x33C9C60", Offset = "0x33C9060", Length = "0x41")]
			[Token(Token = "0x6000FA8")]
			 get { } //Length: 65
		}

		[Token(Token = "0x170002DD")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x33C9BF0", Offset = "0x33C8FF0", Length = "0x61")]
			[Token(Token = "0x6000FA9")]
			private get { } //Length: 97
		}

		[Address(RVA = "0x16450D0", Offset = "0x16444D0", Length = "0x15")]
		[Token(Token = "0x6000FA6")]
		internal Enumerator(Enumerator<StylePropertyName> enumerator) { }

		[Address(RVA = "0x33C9B70", Offset = "0x33C8F70", Length = "0x39")]
		[Token(Token = "0x6000FAB")]
		public override void Dispose() { }

		[Address(RVA = "0x33C9C60", Offset = "0x33C9060", Length = "0x41")]
		[Token(Token = "0x6000FA8")]
		public override StylePropertyName get_Current() { }

		[Address(RVA = "0x33C9BB0", Offset = "0x33C8FB0", Length = "0x39")]
		[Token(Token = "0x6000FA7")]
		public override bool MoveNext() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000FAA")]
		public override void Reset() { }

		[Address(RVA = "0x33C9BF0", Offset = "0x33C8FF0", Length = "0x61")]
		[Token(Token = "0x6000FA9")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008EF")]
	internal List<StylePropertyName> propertiesList; //Field offset: 0x0

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[Token(Token = "0x6000FA2")]
	internal StylePropertyNameCollection(List<StylePropertyName> list) { }

	[Address(RVA = "0x33DB620", Offset = "0x33DAA20", Length = "0x93")]
	[Token(Token = "0x6000FA3")]
	public Enumerator GetEnumerator() { }

	[Address(RVA = "0x33DB6C0", Offset = "0x33DAAC0", Length = "0xB0")]
	[Token(Token = "0x6000FA4")]
	private override IEnumerator<StylePropertyName> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StylePropertyName>.GetEnumerator() { }

	[Address(RVA = "0x33DB780", Offset = "0x33DAB80", Length = "0xB0")]
	[Token(Token = "0x6000FA5")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

