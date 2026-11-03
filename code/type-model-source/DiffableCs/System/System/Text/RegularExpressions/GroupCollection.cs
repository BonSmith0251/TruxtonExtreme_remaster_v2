namespace System.Text.RegularExpressions;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(System.Text.RegularExpressions.CollectionDebuggerProxy`1<System.Text.RegularExpressions.Group>))]
[DefaultMember("Item")]
[Token(Token = "0x20000DA")]
public class GroupCollection : IList<Group>, ICollection<Group>, IEnumerable<Group>, IEnumerable, IReadOnlyList<Group>, IReadOnlyCollection<Group>, IList, ICollection
{
	[Token(Token = "0x20000DB")]
	private sealed class Enumerator : IEnumerator<Group>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000356")]
		private readonly GroupCollection _collection; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000357")]
		private int _index; //Field offset: 0x18

		[Token(Token = "0x170000CB")]
		public override Group Current
		{
			[Address(RVA = "0x2616280", Offset = "0x2615680", Length = "0x97")]
			[Token(Token = "0x60004A2")]
			 get { } //Length: 151
		}

		[Token(Token = "0x170000CC")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2616280", Offset = "0x2615680", Length = "0x97")]
			[Token(Token = "0x60004A3")]
			private get { } //Length: 151
		}

		[Address(RVA = "0x1F900F0", Offset = "0x1F8F4F0", Length = "0x39")]
		[Token(Token = "0x60004A0")]
		internal Enumerator(GroupCollection collection) { }

		[Address(RVA = "0x2616280", Offset = "0x2615680", Length = "0x97")]
		[Token(Token = "0x60004A2")]
		public override Group get_Current() { }

		[Address(RVA = "0x26161A0", Offset = "0x26155A0", Length = "0x48")]
		[Token(Token = "0x60004A1")]
		public override bool MoveNext() { }

		[Address(RVA = "0x2616280", Offset = "0x2615680", Length = "0x97")]
		[Token(Token = "0x60004A3")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x195A120", Offset = "0x1959520", Length = "0x8")]
		[Token(Token = "0x60004A4")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60004A5")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000353")]
	private readonly Match _match; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000354")]
	private readonly Hashtable _captureMap; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000355")]
	private Group[] _groups; //Field offset: 0x20

	[Token(Token = "0x170000C3")]
	public override int Count
	{
		[Address(RVA = "0x2617930", Offset = "0x2616D30", Length = "0x23")]
		[Token(Token = "0x6000481")]
		 get { } //Length: 35
	}

	[Token(Token = "0x170000C2")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000480")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000C6")]
	public override bool IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000488")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000C4")]
	public override Group Item
	{
		[Address(RVA = "0x26174B0", Offset = "0x26168B0", Length = "0x8")]
		[Token(Token = "0x6000482")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000C5")]
	public Group Item
	{
		[Address(RVA = "0x2617960", Offset = "0x2616D60", Length = "0x1A6")]
		[Token(Token = "0x6000483")]
		 get { } //Length: 422
	}

	[Token(Token = "0x170000C7")]
	public override object SyncRoot
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000489")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000C8")]
	private override Group System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Item
	{
		[Address(RVA = "0x26174B0", Offset = "0x26168B0", Length = "0x8")]
		[Token(Token = "0x600048F")]
		private get { } //Length: 8
		[Address(RVA = "0x26174C0", Offset = "0x26168C0", Length = "0x4E")]
		[Token(Token = "0x6000490")]
		private set { } //Length: 78
	}

	[Token(Token = "0x170000C9")]
	private override bool System.Collections.IList.IsFixedSize
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x600049A")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170000CA")]
	private override object System.Collections.IList.Item
	{
		[Address(RVA = "0x26174B0", Offset = "0x26168B0", Length = "0x8")]
		[Token(Token = "0x600049D")]
		private get { } //Length: 8
		[Address(RVA = "0x26178B0", Offset = "0x2616CB0", Length = "0x4E")]
		[Token(Token = "0x600049E")]
		private set { } //Length: 78
	}

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x600047F")]
	internal GroupCollection(Match match, Hashtable caps) { }

	[Address(RVA = "0x2617900", Offset = "0x2616D00", Length = "0x2C")]
	[Token(Token = "0x600049F")]
	internal GroupCollection() { }

	[Address(RVA = "0x2616580", Offset = "0x2615980", Length = "0xD1")]
	[Token(Token = "0x600048A")]
	public override void CopyTo(Array array, int arrayIndex) { }

	[Address(RVA = "0x2616660", Offset = "0x2615A60", Length = "0x1ED")]
	[Token(Token = "0x600048B")]
	public override void CopyTo(Group[] array, int arrayIndex) { }

	[Address(RVA = "0x2617930", Offset = "0x2616D30", Length = "0x23")]
	[Token(Token = "0x6000481")]
	public override int get_Count() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000480")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000488")]
	public override bool get_IsSynchronized() { }

	[Address(RVA = "0x26174B0", Offset = "0x26168B0", Length = "0x8")]
	[Token(Token = "0x6000482")]
	public override Group get_Item(int groupnum) { }

	[Address(RVA = "0x2617960", Offset = "0x2616D60", Length = "0x1A6")]
	[Token(Token = "0x6000483")]
	public Group get_Item(string groupname) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000489")]
	public override object get_SyncRoot() { }

	[Address(RVA = "0x2616850", Offset = "0x2615C50", Length = "0x67")]
	[Token(Token = "0x6000484")]
	public override IEnumerator GetEnumerator() { }

	[Address(RVA = "0x2616CB0", Offset = "0x26160B0", Length = "0x4C5")]
	[Token(Token = "0x6000486")]
	private Group GetGroup(int groupnum) { }

	[Address(RVA = "0x26168C0", Offset = "0x2615CC0", Length = "0x3E7")]
	[Token(Token = "0x6000487")]
	private Group GetGroupImpl(int groupnum) { }

	[Address(RVA = "0x2617180", Offset = "0x2616580", Length = "0x4E")]
	[Token(Token = "0x6000491")]
	private override void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Add(Group item) { }

	[Address(RVA = "0x26171D0", Offset = "0x26165D0", Length = "0x4E")]
	[Token(Token = "0x6000492")]
	private override void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Clear() { }

	[Address(RVA = "0x2617220", Offset = "0x2616620", Length = "0x53")]
	[Token(Token = "0x6000493")]
	private override bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Contains(Group item) { }

	[Address(RVA = "0x2617280", Offset = "0x2616680", Length = "0x4E")]
	[Token(Token = "0x6000494")]
	private override bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Remove(Group item) { }

	[Address(RVA = "0x26172D0", Offset = "0x26166D0", Length = "0x67")]
	[Token(Token = "0x6000485")]
	private override IEnumerator<Group> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>.GetEnumerator() { }

	[Address(RVA = "0x26174B0", Offset = "0x26168B0", Length = "0x8")]
	[Token(Token = "0x600048F")]
	private override Group System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.get_Item(int index) { }

	[Address(RVA = "0x2617340", Offset = "0x2616740", Length = "0xC8")]
	[Token(Token = "0x600048C")]
	private override int System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.IndexOf(Group item) { }

	[Address(RVA = "0x2617410", Offset = "0x2616810", Length = "0x4E")]
	[Token(Token = "0x600048D")]
	private override void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Insert(int index, Group item) { }

	[Address(RVA = "0x2617460", Offset = "0x2616860", Length = "0x4E")]
	[Token(Token = "0x600048E")]
	private override void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.RemoveAt(int index) { }

	[Address(RVA = "0x26174C0", Offset = "0x26168C0", Length = "0x4E")]
	[Token(Token = "0x6000490")]
	private override void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.set_Item(int index, Group value) { }

	[Address(RVA = "0x2617510", Offset = "0x2616910", Length = "0x4E")]
	[Token(Token = "0x6000495")]
	private override int System.Collections.IList.Add(object value) { }

	[Address(RVA = "0x2617560", Offset = "0x2616960", Length = "0x4E")]
	[Token(Token = "0x6000496")]
	private override void System.Collections.IList.Clear() { }

	[Address(RVA = "0x26175B0", Offset = "0x26169B0", Length = "0x131")]
	[Token(Token = "0x6000497")]
	private override bool System.Collections.IList.Contains(object value) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600049A")]
	private override bool System.Collections.IList.get_IsFixedSize() { }

	[Address(RVA = "0x26174B0", Offset = "0x26168B0", Length = "0x8")]
	[Token(Token = "0x600049D")]
	private override object System.Collections.IList.get_Item(int index) { }

	[Address(RVA = "0x26176F0", Offset = "0x2616AF0", Length = "0xC2")]
	[Token(Token = "0x6000498")]
	private override int System.Collections.IList.IndexOf(object value) { }

	[Address(RVA = "0x26177C0", Offset = "0x2616BC0", Length = "0x4E")]
	[Token(Token = "0x6000499")]
	private override void System.Collections.IList.Insert(int index, object value) { }

	[Address(RVA = "0x2617860", Offset = "0x2616C60", Length = "0x4E")]
	[Token(Token = "0x600049B")]
	private override void System.Collections.IList.Remove(object value) { }

	[Address(RVA = "0x2617810", Offset = "0x2616C10", Length = "0x4E")]
	[Token(Token = "0x600049C")]
	private override void System.Collections.IList.RemoveAt(int index) { }

	[Address(RVA = "0x26178B0", Offset = "0x2616CB0", Length = "0x4E")]
	[Token(Token = "0x600049E")]
	private override void System.Collections.IList.set_Item(int index, object value) { }

}

