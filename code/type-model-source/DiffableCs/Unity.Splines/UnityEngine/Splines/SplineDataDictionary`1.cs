namespace UnityEngine.Splines;

[DefaultMember("Item")]
[Token(Token = "0x2000036")]
internal class SplineDataDictionary : IEnumerable<SplineDataKeyValuePair`1<T>>, IEnumerable
{
	[CompilerGenerated]
	[Token(Token = "0x2000037")]
	private sealed class <>c
	{
		[Token(Token = "0x40000C7")]
		public static readonly <>c<T> <>9; //Field offset: 0x0
		[Token(Token = "0x40000C8")]
		public static Func<SplineDataKeyValuePair`1<T>, String> <>9__2_0; //Field offset: 0x0
		[Token(Token = "0x40000C9")]
		public static Func<SplineDataKeyValuePair`1<T>, SplineData`1<T>> <>9__4_0; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x60001E5")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60001E6")]
		public <>c() { }

		[Address(RVA = "0xA503D0", Offset = "0xA4F7D0", Length = "0x17")]
		[Token(Token = "0x60001E7")]
		internal string <get_Keys>b__2_0(SplineDataKeyValuePair<T> x) { }

		[Address(RVA = "0xA503F0", Offset = "0xA4F7F0", Length = "0x17")]
		[Token(Token = "0x60001E8")]
		internal SplineData<T> <get_Values>b__4_0(SplineDataKeyValuePair<T> x) { }

	}

	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40000C6")]
	private List<SplineDataKeyValuePair`1<T>> m_Data; //Field offset: 0x0

	[Token(Token = "0x1700005D")]
	public SplineData<T> Item
	{
		[Address(RVA = "0xFAEFE0", Offset = "0xFAE3E0", Length = "0xB1")]
		[Token(Token = "0x60001DD")]
		 get { } //Length: 177
		[Address(RVA = "0xFAF930", Offset = "0xFAED30", Length = "0x16D")]
		[Token(Token = "0x60001DE")]
		 set { } //Length: 365
	}

	[Token(Token = "0x1700005B")]
	public IEnumerable<String> Keys
	{
		[Address(RVA = "0xFAF0E0", Offset = "0xFAE4E0", Length = "0x1B0")]
		[Token(Token = "0x60001D8")]
		 get { } //Length: 432
	}

	[Token(Token = "0x1700005C")]
	public IEnumerable<SplineData`1<T>> Values
	{
		[Address(RVA = "0xFAF450", Offset = "0xFAE850", Length = "0x1B0")]
		[Token(Token = "0x60001D9")]
		 get { } //Length: 432
	}

	[Address(RVA = "0xFAEEC0", Offset = "0xFAE2C0", Length = "0x83")]
	[Token(Token = "0x60001E4")]
	public SplineDataDictionary`1() { }

	[Address(RVA = "0xFAD570", Offset = "0xFAC970", Length = "0x25")]
	[Token(Token = "0x60001DF")]
	public bool Contains(string key) { }

	[Address(RVA = "0xFAD5D0", Offset = "0xFAC9D0", Length = "0x9B")]
	[Token(Token = "0x60001DA")]
	private int FindIndex(string key) { }

	[Address(RVA = "0xFAEFE0", Offset = "0xFAE3E0", Length = "0xB1")]
	[Token(Token = "0x60001DD")]
	public SplineData<T> get_Item(string key) { }

	[Address(RVA = "0xFAF0E0", Offset = "0xFAE4E0", Length = "0x1B0")]
	[Token(Token = "0x60001D8")]
	public IEnumerable<String> get_Keys() { }

	[Address(RVA = "0xFAF450", Offset = "0xFAE850", Length = "0x1B0")]
	[Token(Token = "0x60001D9")]
	public IEnumerable<SplineData`1<T>> get_Values() { }

	[Address(RVA = "0xFAD7E0", Offset = "0xFACBE0", Length = "0x6B")]
	[Token(Token = "0x60001E0")]
	public override IEnumerator<SplineDataKeyValuePair`1<T>> GetEnumerator() { }

	[Address(RVA = "0xFAD850", Offset = "0xFACC50", Length = "0x250")]
	[Token(Token = "0x60001DC")]
	public SplineData<T> GetOrCreate(string key) { }

	[Address(RVA = "0xFAEAE0", Offset = "0xFADEE0", Length = "0x6C")]
	[Token(Token = "0x60001E2")]
	public bool Remove(string key) { }

	[Address(RVA = "0xFAE910", Offset = "0xFADD10", Length = "0x1C6")]
	[Token(Token = "0x60001E3")]
	public void RemoveEmpty() { }

	[Address(RVA = "0xFAF930", Offset = "0xFAED30", Length = "0x16D")]
	[Token(Token = "0x60001DE")]
	public void set_Item(string key, SplineData<T> value) { }

	[Address(RVA = "0xFAEC20", Offset = "0xFAE020", Length = "0x46")]
	[Token(Token = "0x60001E1")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xFAED60", Offset = "0xFAE160", Length = "0x94")]
	[Token(Token = "0x60001DB")]
	public bool TryGetValue(string key, out SplineData<T>& value) { }

}

