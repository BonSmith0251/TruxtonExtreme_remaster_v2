namespace System.Text.RegularExpressions;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(System.Text.RegularExpressions.CollectionDebuggerProxy`1<System.Text.RegularExpressions.Match>))]
[DefaultMember("Item")]
[Token(Token = "0x20000DE")]
public class MatchCollection : IList<Match>, ICollection<Match>, IEnumerable<Match>, IEnumerable, IReadOnlyList<Match>, IReadOnlyCollection<Match>, IList, ICollection
{
	[Token(Token = "0x20000DF")]
	private sealed class Enumerator : IEnumerator<Match>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400036B")]
		private readonly MatchCollection _collection; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400036C")]
		private int _index; //Field offset: 0x18

		[Token(Token = "0x170000D8")]
		public override Match Current
		{
			[Address(RVA = "0x26163B0", Offset = "0x26157B0", Length = "0x7C")]
			[Token(Token = "0x60004DA")]
			 get { } //Length: 124
		}

		[Token(Token = "0x170000D9")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x26163B0", Offset = "0x26157B0", Length = "0x7C")]
			[Token(Token = "0x60004DB")]
			private get { } //Length: 124
		}

		[Address(RVA = "0x1F900F0", Offset = "0x1F8F4F0", Length = "0x39")]
		[Token(Token = "0x60004D8")]
		internal Enumerator(MatchCollection collection) { }

		[Address(RVA = "0x26163B0", Offset = "0x26157B0", Length = "0x7C")]
		[Token(Token = "0x60004DA")]
		public override Match get_Current() { }

		[Address(RVA = "0x2616230", Offset = "0x2615630", Length = "0x49")]
		[Token(Token = "0x60004D9")]
		public override bool MoveNext() { }

		[Address(RVA = "0x26163B0", Offset = "0x26157B0", Length = "0x7C")]
		[Token(Token = "0x60004DB")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x195A120", Offset = "0x1959520", Length = "0x8")]
		[Token(Token = "0x60004DC")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60004DD")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000363")]
	private readonly Regex _regex; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000364")]
	private readonly List<Match> _matches; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000365")]
	private bool _done; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000366")]
	private readonly string _input; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000367")]
	private readonly int _beginning; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000368")]
	private readonly int _length; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000369")]
	private int _startat; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400036A")]
	private int _prevlen; //Field offset: 0x3C

	[Token(Token = "0x170000D1")]
	public override int Count
	{
		[Address(RVA = "0x2618CB0", Offset = "0x26180B0", Length = "0x52")]
		[Token(Token = "0x60004BA")]
		 get { } //Length: 82
	}

	[Token(Token = "0x170000D0")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60004B9")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000D3")]
	public override bool IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60004C0")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000D2")]
	public override Match Item
	{
		[Address(RVA = "0x2618D10", Offset = "0x2618110", Length = "0xAE")]
		[Token(Token = "0x60004BB")]
		 get { } //Length: 174
	}

	[Token(Token = "0x170000D4")]
	public override object SyncRoot
	{
		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[Token(Token = "0x60004C1")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000D5")]
	private override Match System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Item
	{
		[Address(RVA = "0x2618650", Offset = "0x2617A50", Length = "0x14")]
		[Token(Token = "0x60004C7")]
		private get { } //Length: 20
		[Address(RVA = "0x2618670", Offset = "0x2617A70", Length = "0x4E")]
		[Token(Token = "0x60004C8")]
		private set { } //Length: 78
	}

	[Token(Token = "0x170000D6")]
	private override bool System.Collections.IList.IsFixedSize
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60004D2")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170000D7")]
	private override object System.Collections.IList.Item
	{
		[Address(RVA = "0x2618650", Offset = "0x2617A50", Length = "0x14")]
		[Token(Token = "0x60004D5")]
		private get { } //Length: 20
		[Address(RVA = "0x2618AD0", Offset = "0x2617ED0", Length = "0x4E")]
		[Token(Token = "0x60004D6")]
		private set { } //Length: 78
	}

	[Address(RVA = "0x2618B50", Offset = "0x2617F50", Length = "0x158")]
	[Token(Token = "0x60004B8")]
	internal MatchCollection(Regex regex, string input, int beginning, int length, int startat) { }

	[Address(RVA = "0x2618B20", Offset = "0x2617F20", Length = "0x2C")]
	[Token(Token = "0x60004D7")]
	internal MatchCollection() { }

	[Address(RVA = "0x2618070", Offset = "0x2617470", Length = "0xD6")]
	[Token(Token = "0x60004C2")]
	public override void CopyTo(Array array, int arrayIndex) { }

	[Address(RVA = "0x2617FF0", Offset = "0x26173F0", Length = "0x79")]
	[Token(Token = "0x60004C3")]
	public override void CopyTo(Match[] array, int arrayIndex) { }

	[Address(RVA = "0x2618150", Offset = "0x2617550", Length = "0x14")]
	[Token(Token = "0x60004BF")]
	private void EnsureInitialized() { }

	[Address(RVA = "0x2618CB0", Offset = "0x26180B0", Length = "0x52")]
	[Token(Token = "0x60004BA")]
	public override int get_Count() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60004B9")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60004C0")]
	public override bool get_IsSynchronized() { }

	[Address(RVA = "0x2618D10", Offset = "0x2618110", Length = "0xAE")]
	[Token(Token = "0x60004BB")]
	public override Match get_Item(int i) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x60004C1")]
	public override object get_SyncRoot() { }

	[Address(RVA = "0x2618170", Offset = "0x2617570", Length = "0x67")]
	[Token(Token = "0x60004BC")]
	public override IEnumerator GetEnumerator() { }

	[Address(RVA = "0x26181E0", Offset = "0x26175E0", Length = "0x187")]
	[Token(Token = "0x60004BE")]
	private Match GetMatch(int i) { }

	[Address(RVA = "0x2618370", Offset = "0x2617770", Length = "0x4E")]
	[Token(Token = "0x60004C9")]
	private override void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Add(Match item) { }

	[Address(RVA = "0x26183C0", Offset = "0x26177C0", Length = "0x4E")]
	[Token(Token = "0x60004CA")]
	private override void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Clear() { }

	[Address(RVA = "0x2618410", Offset = "0x2617810", Length = "0x69")]
	[Token(Token = "0x60004CB")]
	private override bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Contains(Match item) { }

	[Address(RVA = "0x2618480", Offset = "0x2617880", Length = "0x4E")]
	[Token(Token = "0x60004CC")]
	private override bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Remove(Match item) { }

	[Address(RVA = "0x26184D0", Offset = "0x26178D0", Length = "0x67")]
	[Token(Token = "0x60004BD")]
	private override IEnumerator<Match> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>.GetEnumerator() { }

	[Address(RVA = "0x2618650", Offset = "0x2617A50", Length = "0x14")]
	[Token(Token = "0x60004C7")]
	private override Match System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.get_Item(int index) { }

	[Address(RVA = "0x2618540", Offset = "0x2617940", Length = "0x69")]
	[Token(Token = "0x60004C4")]
	private override int System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.IndexOf(Match item) { }

	[Address(RVA = "0x26185B0", Offset = "0x26179B0", Length = "0x4E")]
	[Token(Token = "0x60004C5")]
	private override void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Insert(int index, Match item) { }

	[Address(RVA = "0x2618600", Offset = "0x2617A00", Length = "0x4E")]
	[Token(Token = "0x60004C6")]
	private override void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.RemoveAt(int index) { }

	[Address(RVA = "0x2618670", Offset = "0x2617A70", Length = "0x4E")]
	[Token(Token = "0x60004C8")]
	private override void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.set_Item(int index, Match value) { }

	[Address(RVA = "0x26186C0", Offset = "0x2617AC0", Length = "0x4E")]
	[Token(Token = "0x60004CD")]
	private override int System.Collections.IList.Add(object value) { }

	[Address(RVA = "0x2618710", Offset = "0x2617B10", Length = "0x4E")]
	[Token(Token = "0x60004CE")]
	private override void System.Collections.IList.Clear() { }

	[Address(RVA = "0x2618760", Offset = "0x2617B60", Length = "0x131")]
	[Token(Token = "0x60004CF")]
	private override bool System.Collections.IList.Contains(object value) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60004D2")]
	private override bool System.Collections.IList.get_IsFixedSize() { }

	[Address(RVA = "0x2618650", Offset = "0x2617A50", Length = "0x14")]
	[Token(Token = "0x60004D5")]
	private override object System.Collections.IList.get_Item(int index) { }

	[Address(RVA = "0x26188A0", Offset = "0x2617CA0", Length = "0x134")]
	[Token(Token = "0x60004D0")]
	private override int System.Collections.IList.IndexOf(object value) { }

	[Address(RVA = "0x26189E0", Offset = "0x2617DE0", Length = "0x4E")]
	[Token(Token = "0x60004D1")]
	private override void System.Collections.IList.Insert(int index, object value) { }

	[Address(RVA = "0x2618A80", Offset = "0x2617E80", Length = "0x4E")]
	[Token(Token = "0x60004D3")]
	private override void System.Collections.IList.Remove(object value) { }

	[Address(RVA = "0x2618A30", Offset = "0x2617E30", Length = "0x4E")]
	[Token(Token = "0x60004D4")]
	private override void System.Collections.IList.RemoveAt(int index) { }

	[Address(RVA = "0x2618AD0", Offset = "0x2617ED0", Length = "0x4E")]
	[Token(Token = "0x60004D6")]
	private override void System.Collections.IList.set_Item(int index, object value) { }

}

