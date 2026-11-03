namespace Unity.Properties;

[IsReadOnly]
[Token(Token = "0x2000042")]
public struct PropertyCollection : IEnumerable<IProperty`1<TContainer>>, IEnumerable
{
	[Token(Token = "0x2000044")]
	internal struct Enumerator : IEnumerator<IProperty`1<TContainer>>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006A")]
		private readonly EnumeratorType<TContainer> m_Type; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006B")]
		private IEnumerator<IProperty`1<TContainer>> m_Enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006C")]
		private Enumerator<IProperty<TContainer>> m_Properties; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006D")]
		private IndexedCollectionPropertyBagEnumerator<TContainer> m_IndexedCollectionPropertyBag; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006E")]
		private IProperty<TContainer> <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000034")]
		public private override IProperty<TContainer> Current
		{
			[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x600010C")]
			 get { } //Length: 5
			[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x600010D")]
			private set { } //Length: 13
		}

		[Token(Token = "0x17000035")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x195B0D0", Offset = "0x195A4D0", Length = "0x25")]
			[Token(Token = "0x600010E")]
			private get { } //Length: 37
		}

		[Address(RVA = "0x195B380", Offset = "0x195A780", Length = "0x67")]
		[Token(Token = "0x600010F")]
		internal Enumerator(IEnumerator<IProperty`1<TContainer>> enumerator) { }

		[Address(RVA = "0x195B450", Offset = "0x195A850", Length = "0x8C")]
		[Token(Token = "0x6000110")]
		internal Enumerator(Enumerator<IProperty<TContainer>> properties) { }

		[Address(RVA = "0x195B740", Offset = "0x195AB40", Length = "0x8C")]
		[Token(Token = "0x6000111")]
		internal Enumerator(IndexedCollectionPropertyBagEnumerator<TContainer> enumerator) { }

		[Address(RVA = "0x1957B10", Offset = "0x1956F10", Length = "0xD0")]
		[Token(Token = "0x6000114")]
		public override void Dispose() { }

		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600010C")]
		public override IProperty<TContainer> get_Current() { }

		[Address(RVA = "0x19583A0", Offset = "0x19577A0", Length = "0x1DB")]
		[Token(Token = "0x6000112")]
		public override bool MoveNext() { }

		[Address(RVA = "0x1959EC0", Offset = "0x19592C0", Length = "0x127")]
		[Token(Token = "0x6000113")]
		public override void Reset() { }

		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600010D")]
		private void set_Current(IProperty<TContainer> value) { }

		[Address(RVA = "0x195B0D0", Offset = "0x195A4D0", Length = "0x25")]
		[Token(Token = "0x600010E")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[Token(Token = "0x2000043")]
	private enum EnumeratorType : int
	{
		Empty = 0,
		Enumerable = 1,
		List = 2,
		IndexedCollectionPropertyBag = 3,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000064")]
	private static readonly PropertyCollection<TContainer> <Empty>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000060")]
	private readonly EnumeratorType<TContainer> m_Type; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000061")]
	private readonly IEnumerable<IProperty`1<TContainer>> m_Enumerable; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000062")]
	private readonly List<IProperty`1<TContainer>> m_Properties; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000063")]
	private readonly IndexedCollectionPropertyBagEnumerable<TContainer> m_IndexedCollectionPropertyBag; //Field offset: 0x0

	[Token(Token = "0x17000033")]
	public static PropertyCollection<TContainer> Empty
	{
		[Address(RVA = "0xE41CC0", Offset = "0xE410C0", Length = "0xB0")]
		[CompilerGenerated]
		[Token(Token = "0x6000104")]
		 get { } //Length: 176
	}

	[Address(RVA = "0xE40FC0", Offset = "0xE403C0", Length = "0x51")]
	[Token(Token = "0x600010B")]
	private static PropertyCollection`1() { }

	[Address(RVA = "0xE41100", Offset = "0xE40500", Length = "0x3C")]
	[Token(Token = "0x6000105")]
	public PropertyCollection`1(IEnumerable<IProperty`1<TContainer>> enumerable) { }

	[Address(RVA = "0xE416D0", Offset = "0xE40AD0", Length = "0x4B")]
	[Token(Token = "0x6000106")]
	public PropertyCollection`1(List<IProperty`1<TContainer>> properties) { }

	[Address(RVA = "0xE41670", Offset = "0xE40A70", Length = "0x58")]
	[Token(Token = "0x6000107")]
	internal PropertyCollection`1(IndexedCollectionPropertyBagEnumerable<TContainer> enumerable) { }

	[Address(RVA = "0xE41CC0", Offset = "0xE410C0", Length = "0xB0")]
	[CompilerGenerated]
	[Token(Token = "0x6000104")]
	public static PropertyCollection<TContainer> get_Empty() { }

	[Address(RVA = "0xE3CFD0", Offset = "0xE3C3D0", Length = "0x29C")]
	[Token(Token = "0x6000108")]
	public Enumerator<TContainer> GetEnumerator() { }

	[Address(RVA = "0xE3FC20", Offset = "0xE3F020", Length = "0xFE")]
	[Token(Token = "0x6000109")]
	private override IEnumerator<IProperty`1<TContainer>> System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator() { }

	[Address(RVA = "0xE3FC20", Offset = "0xE3F020", Length = "0xFE")]
	[Token(Token = "0x600010A")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

