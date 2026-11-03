namespace System.Net;

[DefaultMember("Item")]
[Token(Token = "0x2000279")]
public class CookieCollection : ICollection, IEnumerable
{
	[Token(Token = "0x200027B")]
	private class CookieCollectionEnumerator : IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A2E")]
		private CookieCollection m_cookies; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000A2F")]
		private int m_count; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000A30")]
		private int m_index; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000A31")]
		private int m_version; //Field offset: 0x20

		[Token(Token = "0x17000384")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x26B4240", Offset = "0x26B3640", Length = "0xF7")]
			[Token(Token = "0x60010A9")]
			private get { } //Length: 247
		}

		[Address(RVA = "0x26B4340", Offset = "0x26B3740", Length = "0x68")]
		[Token(Token = "0x60010A8")]
		internal CookieCollectionEnumerator(CookieCollection cookies) { }

		[Address(RVA = "0x26B4240", Offset = "0x26B3640", Length = "0xF7")]
		[Token(Token = "0x60010A9")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x26B4190", Offset = "0x26B3590", Length = "0xA5")]
		[Token(Token = "0x60010AA")]
		private override bool System.Collections.IEnumerator.MoveNext() { }

		[Address(RVA = "0x265B830", Offset = "0x265AC30", Length = "0x8")]
		[Token(Token = "0x60010AB")]
		private override void System.Collections.IEnumerator.Reset() { }

	}

	[Token(Token = "0x200027A")]
	public enum Stamp : int
	{
		Check = 0,
		Set = 1,
		SetToUnused = 2,
		SetToMaxUsed = 3,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A24")]
	internal int m_version; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A25")]
	private ArrayList m_list; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A26")]
	private DateTime m_TimeStamp; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A27")]
	private bool m_has_other_versions; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[OptionalField]
	[Token(Token = "0x4000A28")]
	private bool m_IsReadOnly; //Field offset: 0x29

	[Token(Token = "0x17000380")]
	public override int Count
	{
		[Address(RVA = "0x1EAA5B0", Offset = "0x1EA99B0", Length = "0x2A")]
		[Token(Token = "0x600109E")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000383")]
	internal bool IsOtherVersionSeen
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x60010A3")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000381")]
	public override bool IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600109F")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700037F")]
	public Cookie Item
	{
		[Address(RVA = "0x26B4FF0", Offset = "0x26B43F0", Length = "0xF3")]
		[Token(Token = "0x600109B")]
		 get { } //Length: 243
	}

	[Token(Token = "0x17000382")]
	public override object SyncRoot
	{
		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[Token(Token = "0x60010A0")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x26B4F40", Offset = "0x26B4340", Length = "0xA5")]
	[Token(Token = "0x600109A")]
	public CookieCollection() { }

	[Address(RVA = "0x26B43B0", Offset = "0x26B37B0", Length = "0xC9")]
	[Token(Token = "0x600109C")]
	public void Add(Cookie cookie) { }

	[Address(RVA = "0x26B4480", Offset = "0x26B3880", Length = "0x349")]
	[Token(Token = "0x600109D")]
	public void Add(CookieCollection cookies) { }

	[Address(RVA = "0x26B47D0", Offset = "0x26B3BD0", Length = "0x2A")]
	[Token(Token = "0x60010A1")]
	public override void CopyTo(Array array, int index) { }

	[Address(RVA = "0x1EAA5B0", Offset = "0x1EA99B0", Length = "0x2A")]
	[Token(Token = "0x600109E")]
	public override int get_Count() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[Token(Token = "0x60010A3")]
	internal bool get_IsOtherVersionSeen() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600109F")]
	public override bool get_IsSynchronized() { }

	[Address(RVA = "0x26B4FF0", Offset = "0x26B43F0", Length = "0xF3")]
	[Token(Token = "0x600109B")]
	public Cookie get_Item(int index) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x60010A0")]
	public override object get_SyncRoot() { }

	[Address(RVA = "0x26B4800", Offset = "0x26B3C00", Length = "0x96")]
	[Token(Token = "0x60010A7")]
	public override IEnumerator GetEnumerator() { }

	[Address(RVA = "0x26B48A0", Offset = "0x26B3CA0", Length = "0x22B")]
	[Token(Token = "0x60010A5")]
	internal int IndexOf(Cookie cookie) { }

	[Address(RVA = "0x26B4AD0", Offset = "0x26B3ED0", Length = "0x33D")]
	[Token(Token = "0x60010A4")]
	internal int InternalAdd(Cookie cookie, bool isStrict) { }

	[Address(RVA = "0x26B4E10", Offset = "0x26B4210", Length = "0x2A")]
	[Token(Token = "0x60010A6")]
	internal void RemoveAt(int idx) { }

	[Address(RVA = "0x26B4E40", Offset = "0x26B4240", Length = "0xF1")]
	[Token(Token = "0x60010A2")]
	internal DateTime TimeStamp(Stamp how) { }

}

