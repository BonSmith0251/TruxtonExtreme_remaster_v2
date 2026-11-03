namespace System.Text.RegularExpressions;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(System.Text.RegularExpressions.CollectionDebuggerProxy`1<System.Text.RegularExpressions.Capture>))]
[DefaultMember("Item")]
[Token(Token = "0x20000D6")]
public class CaptureCollection : IList<Capture>, ICollection<Capture>, IEnumerable<Capture>, IEnumerable, IReadOnlyList<Capture>, IReadOnlyCollection<Capture>, IList, ICollection
{
	[Token(Token = "0x20000D7")]
	private sealed class Enumerator : IEnumerator<Capture>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400034C")]
		private readonly CaptureCollection _collection; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400034D")]
		private int _index; //Field offset: 0x18

		[Token(Token = "0x170000BF")]
		public override Capture Current
		{
			[Address(RVA = "0x2616320", Offset = "0x2615720", Length = "0x85")]
			[Token(Token = "0x6000477")]
			 get { } //Length: 133
		}

		[Token(Token = "0x170000C0")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2616320", Offset = "0x2615720", Length = "0x85")]
			[Token(Token = "0x6000478")]
			private get { } //Length: 133
		}

		[Address(RVA = "0x1F900F0", Offset = "0x1F8F4F0", Length = "0x39")]
		[Token(Token = "0x6000475")]
		internal Enumerator(CaptureCollection collection) { }

		[Address(RVA = "0x2616320", Offset = "0x2615720", Length = "0x85")]
		[Token(Token = "0x6000477")]
		public override Capture get_Current() { }

		[Address(RVA = "0x26161F0", Offset = "0x26155F0", Length = "0x33")]
		[Token(Token = "0x6000476")]
		public override bool MoveNext() { }

		[Address(RVA = "0x2616320", Offset = "0x2615720", Length = "0x85")]
		[Token(Token = "0x6000478")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x195A120", Offset = "0x1959520", Length = "0x8")]
		[Token(Token = "0x6000479")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x600047A")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000349")]
	private readonly Group _group; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400034A")]
	private readonly int _capcount; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400034B")]
	private Capture[] _captures; //Field offset: 0x20

	[Token(Token = "0x170000B8")]
	public override int Count
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000457")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000B7")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000456")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000BA")]
	public override bool IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600045D")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000B9")]
	public override Capture Item
	{
		[Address(RVA = "0x2614C20", Offset = "0x2614020", Length = "0x8")]
		[Token(Token = "0x6000458")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000BB")]
	public override object SyncRoot
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600045E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000BC")]
	private override Capture System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Item
	{
		[Address(RVA = "0x2614C20", Offset = "0x2614020", Length = "0x8")]
		[Token(Token = "0x6000464")]
		private get { } //Length: 8
		[Address(RVA = "0x2614C30", Offset = "0x2614030", Length = "0x4E")]
		[Token(Token = "0x6000465")]
		private set { } //Length: 78
	}

	[Token(Token = "0x170000BD")]
	private override bool System.Collections.IList.IsFixedSize
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x600046F")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170000BE")]
	private override object System.Collections.IList.Item
	{
		[Address(RVA = "0x2614C20", Offset = "0x2614020", Length = "0x8")]
		[Token(Token = "0x6000472")]
		private get { } //Length: 8
		[Address(RVA = "0x2615020", Offset = "0x2614420", Length = "0x4E")]
		[Token(Token = "0x6000473")]
		private set { } //Length: 78
	}

	[Address(RVA = "0x2615070", Offset = "0x2614470", Length = "0x2C")]
	[Token(Token = "0x6000474")]
	internal CaptureCollection() { }

	[Address(RVA = "0x2614220", Offset = "0x2613620", Length = "0x1C5")]
	[Token(Token = "0x6000460")]
	public override void CopyTo(Capture[] array, int arrayIndex) { }

	[Address(RVA = "0x26143F0", Offset = "0x26137F0", Length = "0xB3")]
	[Token(Token = "0x600045F")]
	public override void CopyTo(Array array, int arrayIndex) { }

	[Address(RVA = "0x26144B0", Offset = "0x26138B0", Length = "0x195")]
	[Token(Token = "0x600045C")]
	internal void ForceInitialized() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000457")]
	public override int get_Count() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000456")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600045D")]
	public override bool get_IsSynchronized() { }

	[Address(RVA = "0x2614C20", Offset = "0x2614020", Length = "0x8")]
	[Token(Token = "0x6000458")]
	public override Capture get_Item(int i) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600045E")]
	public override object get_SyncRoot() { }

	[Address(RVA = "0x2614650", Offset = "0x2613A50", Length = "0x249")]
	[Token(Token = "0x600045B")]
	private Capture GetCapture(int i) { }

	[Address(RVA = "0x26148A0", Offset = "0x2613CA0", Length = "0x67")]
	[Token(Token = "0x6000459")]
	public override IEnumerator GetEnumerator() { }

	[Address(RVA = "0x2614910", Offset = "0x2613D10", Length = "0x4E")]
	[Token(Token = "0x6000466")]
	private override void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Add(Capture item) { }

	[Address(RVA = "0x2614960", Offset = "0x2613D60", Length = "0x4E")]
	[Token(Token = "0x6000467")]
	private override void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Clear() { }

	[Address(RVA = "0x26149B0", Offset = "0x2613DB0", Length = "0x53")]
	[Token(Token = "0x6000468")]
	private override bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Contains(Capture item) { }

	[Address(RVA = "0x2614A10", Offset = "0x2613E10", Length = "0x4E")]
	[Token(Token = "0x6000469")]
	private override bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Remove(Capture item) { }

	[Address(RVA = "0x2614A60", Offset = "0x2613E60", Length = "0x67")]
	[Token(Token = "0x600045A")]
	private override IEnumerator<Capture> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>.GetEnumerator() { }

	[Address(RVA = "0x2614C20", Offset = "0x2614020", Length = "0x8")]
	[Token(Token = "0x6000464")]
	private override Capture System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.get_Item(int index) { }

	[Address(RVA = "0x2614AD0", Offset = "0x2613ED0", Length = "0xAB")]
	[Token(Token = "0x6000461")]
	private override int System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.IndexOf(Capture item) { }

	[Address(RVA = "0x2614B80", Offset = "0x2613F80", Length = "0x4E")]
	[Token(Token = "0x6000462")]
	private override void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Insert(int index, Capture item) { }

	[Address(RVA = "0x2614BD0", Offset = "0x2613FD0", Length = "0x4E")]
	[Token(Token = "0x6000463")]
	private override void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.RemoveAt(int index) { }

	[Address(RVA = "0x2614C30", Offset = "0x2614030", Length = "0x4E")]
	[Token(Token = "0x6000465")]
	private override void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.set_Item(int index, Capture value) { }

	[Address(RVA = "0x2614C80", Offset = "0x2614080", Length = "0x4E")]
	[Token(Token = "0x600046A")]
	private override int System.Collections.IList.Add(object value) { }

	[Address(RVA = "0x2614CD0", Offset = "0x26140D0", Length = "0x4E")]
	[Token(Token = "0x600046B")]
	private override void System.Collections.IList.Clear() { }

	[Address(RVA = "0x2614D20", Offset = "0x2614120", Length = "0x131")]
	[Token(Token = "0x600046C")]
	private override bool System.Collections.IList.Contains(object value) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600046F")]
	private override bool System.Collections.IList.get_IsFixedSize() { }

	[Address(RVA = "0x2614C20", Offset = "0x2614020", Length = "0x8")]
	[Token(Token = "0x6000472")]
	private override object System.Collections.IList.get_Item(int index) { }

	[Address(RVA = "0x2614E60", Offset = "0x2614260", Length = "0xC2")]
	[Token(Token = "0x600046D")]
	private override int System.Collections.IList.IndexOf(object value) { }

	[Address(RVA = "0x2614F30", Offset = "0x2614330", Length = "0x4E")]
	[Token(Token = "0x600046E")]
	private override void System.Collections.IList.Insert(int index, object value) { }

	[Address(RVA = "0x2614FD0", Offset = "0x26143D0", Length = "0x4E")]
	[Token(Token = "0x6000470")]
	private override void System.Collections.IList.Remove(object value) { }

	[Address(RVA = "0x2614F80", Offset = "0x2614380", Length = "0x4E")]
	[Token(Token = "0x6000471")]
	private override void System.Collections.IList.RemoveAt(int index) { }

	[Address(RVA = "0x2615020", Offset = "0x2614420", Length = "0x4E")]
	[Token(Token = "0x6000473")]
	private override void System.Collections.IList.set_Item(int index, object value) { }

}

