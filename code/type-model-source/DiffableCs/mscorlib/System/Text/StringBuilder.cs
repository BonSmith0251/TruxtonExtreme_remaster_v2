namespace System.Text;

[DefaultMember("Chars")]
[Token(Token = "0x20002B1")]
public sealed class StringBuilder : ISerializable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000BA5")]
	internal Char[] m_ChunkChars; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000BA6")]
	internal StringBuilder m_ChunkPrevious; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000BA7")]
	internal int m_ChunkLength; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000BA8")]
	internal int m_ChunkOffset; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000BA9")]
	internal int m_MaxCapacity; //Field offset: 0x28

	[Token(Token = "0x17000224")]
	public int Capacity
	{
		[Address(RVA = "0x1E94CD0", Offset = "0x1E940D0", Length = "0x1D")]
		[Token(Token = "0x6001614")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000227")]
	public char Chars
	{
		[Address(RVA = "0x1E94CF0", Offset = "0x1E940F0", Length = "0xC8")]
		[Token(Token = "0x600161B")]
		 get { } //Length: 200
		[Address(RVA = "0x1E94E70", Offset = "0x1E94270", Length = "0x116")]
		[Token(Token = "0x600161C")]
		 set { } //Length: 278
	}

	[Token(Token = "0x17000226")]
	public int Length
	{
		[Address(RVA = "0x1E94DC0", Offset = "0x1E941C0", Length = "0x7")]
		[Token(Token = "0x6001619")]
		 get { } //Length: 7
		[Address(RVA = "0x1E94F90", Offset = "0x1E94390", Length = "0x29B")]
		[Token(Token = "0x600161A")]
		 set { } //Length: 667
	}

	[Token(Token = "0x17000225")]
	public int MaxCapacity
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x6001615")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000228")]
	private Span<Char> RemainingCurrentChunk
	{
		[Address(RVA = "0x1E94DD0", Offset = "0x1E941D0", Length = "0x9F")]
		[Token(Token = "0x6001643")]
		private get { } //Length: 159
	}

	[Address(RVA = "0x1E942B0", Offset = "0x1E936B0", Length = "0x5C")]
	[Token(Token = "0x600160C")]
	public StringBuilder() { }

	[Address(RVA = "0x1E94310", Offset = "0x1E93710", Length = "0xE")]
	[Token(Token = "0x600160D")]
	public StringBuilder(int capacity) { }

	[Address(RVA = "0x1E94C50", Offset = "0x1E94050", Length = "0x35")]
	[Token(Token = "0x600160E")]
	public StringBuilder(string value) { }

	[Address(RVA = "0x1E94C90", Offset = "0x1E94090", Length = "0x32")]
	[Token(Token = "0x600160F")]
	public StringBuilder(string value, int capacity) { }

	[Address(RVA = "0x1E94510", Offset = "0x1E93910", Length = "0x2E2")]
	[Token(Token = "0x6001610")]
	public StringBuilder(string value, int startIndex, int length, int capacity) { }

	[Address(RVA = "0x1E94320", Offset = "0x1E93720", Length = "0x1E3")]
	[Token(Token = "0x6001611")]
	public StringBuilder(int capacity, int maxCapacity) { }

	[Address(RVA = "0x1E94800", Offset = "0x1E93C00", Length = "0x33D")]
	[Token(Token = "0x6001612")]
	private StringBuilder(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1E94BE0", Offset = "0x1E93FE0", Length = "0x60")]
	[Token(Token = "0x6001646")]
	private StringBuilder(StringBuilder from) { }

	[Address(RVA = "0x1E94B40", Offset = "0x1E93F40", Length = "0x99")]
	[Token(Token = "0x6001648")]
	private StringBuilder(int size, int maxCapacity, StringBuilder previousBlock) { }

	[Address(RVA = "0x1E91560", Offset = "0x1E90960", Length = "0x37")]
	[Token(Token = "0x6001622")]
	public StringBuilder Append(StringBuilder value) { }

	[Address(RVA = "0x1E914F0", Offset = "0x1E908F0", Length = "0x67")]
	[Token(Token = "0x6001628")]
	public StringBuilder Append(char value) { }

	[Address(RVA = "0x1E91250", Offset = "0x1E90650", Length = "0x48")]
	[Token(Token = "0x6001629")]
	public StringBuilder Append(byte value) { }

	[Address(RVA = "0x1E917C0", Offset = "0x1E90BC0", Length = "0x77")]
	[Token(Token = "0x600162F")]
	public StringBuilder Append(ReadOnlySpan<Char> value) { }

	[Address(RVA = "0x1E912A0", Offset = "0x1E906A0", Length = "0x43")]
	[Token(Token = "0x600162D")]
	public StringBuilder Append(object value) { }

	[Address(RVA = "0x1E915A0", Offset = "0x1E909A0", Length = "0x3C")]
	[Token(Token = "0x600162E")]
	public StringBuilder Append(Char[] value) { }

	[Address(RVA = "0x1E919C0", Offset = "0x1E90DC0", Length = "0x1E5")]
	[Token(Token = "0x6001621")]
	public StringBuilder Append(string value, int startIndex, int count) { }

	[Address(RVA = "0x1E912F0", Offset = "0x1E906F0", Length = "0x1AA")]
	[CLSCompliant(False)]
	[Token(Token = "0x600163B")]
	public StringBuilder Append(Char* value, int valueCount) { }

	[Address(RVA = "0x1E914A0", Offset = "0x1E908A0", Length = "0x46")]
	[CLSCompliant(False)]
	[Token(Token = "0x600162B")]
	public StringBuilder Append(uint value) { }

	[Address(RVA = "0x1E91100", Offset = "0x1E90500", Length = "0xFF")]
	[Token(Token = "0x600161F")]
	public StringBuilder Append(string value) { }

	[Address(RVA = "0x1E91200", Offset = "0x1E90600", Length = "0x46")]
	[Token(Token = "0x600162A")]
	public StringBuilder Append(int value) { }

	[Address(RVA = "0x1E91840", Offset = "0x1E90C40", Length = "0x179")]
	[Token(Token = "0x600161D")]
	public StringBuilder Append(char value, int repeatCount) { }

	[Address(RVA = "0x1E915E0", Offset = "0x1E909E0", Length = "0x1D8")]
	[Token(Token = "0x600161E")]
	public StringBuilder Append(Char[] value, int startIndex, int charCount) { }

	[Address(RVA = "0x1E901A0", Offset = "0x1E8F5A0", Length = "0x251")]
	[Token(Token = "0x6001623")]
	private StringBuilder AppendCore(StringBuilder value, int startIndex, int count) { }

	[Address(RVA = "0x1E90D80", Offset = "0x1E90180", Length = "0xCB")]
	[Token(Token = "0x6001634")]
	public StringBuilder AppendFormat(string format, Object[] args) { }

	[Address(RVA = "0x1E90E50", Offset = "0x1E90250", Length = "0x90")]
	[Token(Token = "0x6001636")]
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0, object arg1, object arg2) { }

	[Address(RVA = "0x1E90EE0", Offset = "0x1E902E0", Length = "0x77")]
	[Token(Token = "0x6001635")]
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0) { }

	[Address(RVA = "0x1E90F60", Offset = "0x1E90360", Length = "0x73")]
	[Token(Token = "0x6001633")]
	public StringBuilder AppendFormat(string format, object arg0, object arg1) { }

	[Address(RVA = "0x1E90FE0", Offset = "0x1E903E0", Length = "0x6D")]
	[Token(Token = "0x6001632")]
	public StringBuilder AppendFormat(string format, object arg0) { }

	[Address(RVA = "0x1E90400", Offset = "0x1E8F800", Length = "0x974")]
	[Token(Token = "0x6001638")]
	internal StringBuilder AppendFormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	[Address(RVA = "0x1E91050", Offset = "0x1E90450", Length = "0x40")]
	[Token(Token = "0x6001620")]
	private void AppendHelper(string value) { }

	[Address(RVA = "0x1E910A0", Offset = "0x1E904A0", Length = "0x23")]
	[Token(Token = "0x6001624")]
	public StringBuilder AppendLine() { }

	[Address(RVA = "0x1E910D0", Offset = "0x1E904D0", Length = "0x2B")]
	[Token(Token = "0x6001625")]
	public StringBuilder AppendLine(string value) { }

	[Address(RVA = "0x9147F0", Offset = "0x913BF0", Length = "0x82")]
	[Token(Token = "0x600162C")]
	private StringBuilder AppendSpanFormattable(T value) { }

	[Address(RVA = "0x1E91BB0", Offset = "0x1E90FB0", Length = "0x1C")]
	[Token(Token = "0x6001618")]
	public StringBuilder Clear() { }

	[Address(RVA = "0x1E91BD0", Offset = "0x1E90FD0", Length = "0x220")]
	[Token(Token = "0x6001626")]
	public void CopyTo(int sourceIndex, Span<Char> destination, int count) { }

	[Address(RVA = "0x1E91E00", Offset = "0x1E91200", Length = "0x1E6")]
	[Token(Token = "0x6001645")]
	private void ExpandByABlock(int minBlockCharCount) { }

	[Address(RVA = "0x1E91FF0", Offset = "0x1E913F0", Length = "0x35")]
	[Token(Token = "0x6001642")]
	private StringBuilder FindChunkForIndex(int index) { }

	[Address(RVA = "0x1E92030", Offset = "0x1E91430", Length = "0x4E")]
	[Token(Token = "0x6001637")]
	private static void FormatError() { }

	[Address(RVA = "0x1E94CD0", Offset = "0x1E940D0", Length = "0x1D")]
	[Token(Token = "0x6001614")]
	public int get_Capacity() { }

	[Address(RVA = "0x1E94CF0", Offset = "0x1E940F0", Length = "0xC8")]
	[Token(Token = "0x600161B")]
	public char get_Chars(int index) { }

	[Address(RVA = "0x1E94DC0", Offset = "0x1E941C0", Length = "0x7")]
	[Token(Token = "0x6001619")]
	public int get_Length() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x6001615")]
	public int get_MaxCapacity() { }

	[Address(RVA = "0x1E94DD0", Offset = "0x1E941D0", Length = "0x9F")]
	[Token(Token = "0x6001643")]
	private Span<Char> get_RemainingCurrentChunk() { }

	[Address(RVA = "0x1E920B0", Offset = "0x1E914B0", Length = "0x64D")]
	[Token(Token = "0x600163C")]
	private void Insert(int index, Char* value, int valueCount) { }

	[Address(RVA = "0x1E92080", Offset = "0x1E91480", Length = "0x30")]
	[Token(Token = "0x6001631")]
	public StringBuilder Insert(int index, char value) { }

	[Address(RVA = "0x1E92700", Offset = "0x1E91B00", Length = "0xB7")]
	[Token(Token = "0x6001630")]
	public StringBuilder Insert(int index, string value) { }

	[Address(RVA = "0x1E927C0", Offset = "0x1E91BC0", Length = "0x489")]
	[Token(Token = "0x6001647")]
	private void MakeRoom(int index, int count, out StringBuilder chunk, out int indexInChunk, bool doNotMoveFollowingChars) { }

	[Address(RVA = "0x1E92C50", Offset = "0x1E92050", Length = "0x4B")]
	[Token(Token = "0x6001644")]
	private StringBuilder Next(StringBuilder chunk) { }

	[Address(RVA = "0x1E92FC0", Offset = "0x1E923C0", Length = "0x1DC")]
	[Token(Token = "0x6001649")]
	private void Remove(int startIndex, int count, out StringBuilder chunk, out int indexInChunk) { }

	[Address(RVA = "0x1E92CA0", Offset = "0x1E920A0", Length = "0x318")]
	[Token(Token = "0x6001627")]
	public StringBuilder Remove(int startIndex, int length) { }

	[Address(RVA = "0x1E93580", Offset = "0x1E92980", Length = "0x50E")]
	[Token(Token = "0x600163A")]
	public StringBuilder Replace(string oldValue, string newValue, int startIndex, int count) { }

	[Address(RVA = "0x1E93A90", Offset = "0x1E92E90", Length = "0x24")]
	[Token(Token = "0x6001639")]
	public StringBuilder Replace(string oldValue, string newValue) { }

	[Address(RVA = "0x1E931A0", Offset = "0x1E925A0", Length = "0x202")]
	[Token(Token = "0x600163D")]
	private void ReplaceAllInChunk(Int32[] replacements, int replacementsCount, StringBuilder sourceChunk, int removeCount, string value) { }

	[Address(RVA = "0x1E933B0", Offset = "0x1E927B0", Length = "0x1C2")]
	[Token(Token = "0x600163F")]
	private void ReplaceInPlaceAtChunk(ref StringBuilder chunk, ref int indexInChunk, Char* value, int count) { }

	[Address(RVA = "0x1E94E70", Offset = "0x1E94270", Length = "0x116")]
	[Token(Token = "0x600161C")]
	public void set_Chars(int index, char value) { }

	[Address(RVA = "0x1E94F90", Offset = "0x1E94390", Length = "0x29B")]
	[Token(Token = "0x600161A")]
	public void set_Length(int value) { }

	[Address(RVA = "0x1E93AC0", Offset = "0x1E92EC0", Length = "0xDB")]
	[Token(Token = "0x600163E")]
	private bool StartsWith(StringBuilder chunk, int indexInChunk, int count, string value) { }

	[Address(RVA = "0x1E93BA0", Offset = "0x1E92FA0", Length = "0x12E")]
	[Token(Token = "0x6001613")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1E93CD0", Offset = "0x1E930D0", Length = "0xC5")]
	[Token(Token = "0x6001640")]
	private static void ThreadSafeCopy(Char* sourcePtr, Char[] destination, int destinationIndex, int count) { }

	[Address(RVA = "0x1E93DA0", Offset = "0x1E931A0", Length = "0x193")]
	[Token(Token = "0x6001641")]
	private static void ThreadSafeCopy(Char[] source, int sourceIndex, Span<Char> destination, int destinationIndex, int count) { }

	[Address(RVA = "0x1E94180", Offset = "0x1E93580", Length = "0x12F")]
	[Token(Token = "0x6001616")]
	public virtual string ToString() { }

	[Address(RVA = "0x1E93F40", Offset = "0x1E93340", Length = "0x237")]
	[Token(Token = "0x6001617")]
	public string ToString(int startIndex, int length) { }

}

