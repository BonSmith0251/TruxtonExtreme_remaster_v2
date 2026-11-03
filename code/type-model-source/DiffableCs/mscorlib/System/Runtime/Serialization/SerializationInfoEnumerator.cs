namespace System.Runtime.Serialization;

[Token(Token = "0x20003D8")]
public sealed class SerializationInfoEnumerator : IEnumerator
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F26")]
	private readonly String[] _members; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F27")]
	private readonly Object[] _data; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F28")]
	private readonly Type[] _types; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000F29")]
	private readonly int _numItems; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000F2A")]
	private int _currItem; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000F2B")]
	private bool _current; //Field offset: 0x30

	[Token(Token = "0x170003A4")]
	public SerializationEntry Current
	{
		[Address(RVA = "0x1F13C20", Offset = "0x1F13020", Length = "0x119")]
		[Token(Token = "0x6001D91")]
		 get { } //Length: 281
	}

	[Token(Token = "0x170003A5")]
	public string Name
	{
		[Address(RVA = "0x1F13D40", Offset = "0x1F13140", Length = "0x83")]
		[Token(Token = "0x6001D93")]
		 get { } //Length: 131
	}

	[Token(Token = "0x170003A7")]
	public Type ObjectType
	{
		[Address(RVA = "0x1F13DD0", Offset = "0x1F131D0", Length = "0x83")]
		[Token(Token = "0x6001D95")]
		 get { } //Length: 131
	}

	[Token(Token = "0x170003A3")]
	private override object System.Collections.IEnumerator.Current
	{
		[Address(RVA = "0x1F13B40", Offset = "0x1F12F40", Length = "0x5F")]
		[Token(Token = "0x6001D90")]
		private get { } //Length: 95
	}

	[Token(Token = "0x170003A6")]
	public object Value
	{
		[Address(RVA = "0x1F13E60", Offset = "0x1F13260", Length = "0x83")]
		[Token(Token = "0x6001D94")]
		 get { } //Length: 131
	}

	[Address(RVA = "0x1F13BA0", Offset = "0x1F12FA0", Length = "0x80")]
	[Token(Token = "0x6001D8E")]
	internal SerializationInfoEnumerator(String[] members, Object[] info, Type[] types, int numItems) { }

	[Address(RVA = "0x1F13C20", Offset = "0x1F13020", Length = "0x119")]
	[Token(Token = "0x6001D91")]
	public SerializationEntry get_Current() { }

	[Address(RVA = "0x1F13D40", Offset = "0x1F13140", Length = "0x83")]
	[Token(Token = "0x6001D93")]
	public string get_Name() { }

	[Address(RVA = "0x1F13DD0", Offset = "0x1F131D0", Length = "0x83")]
	[Token(Token = "0x6001D95")]
	public Type get_ObjectType() { }

	[Address(RVA = "0x1F13E60", Offset = "0x1F13260", Length = "0x83")]
	[Token(Token = "0x6001D94")]
	public object get_Value() { }

	[Address(RVA = "0x1F13B10", Offset = "0x1F12F10", Length = "0x19")]
	[Token(Token = "0x6001D8F")]
	public override bool MoveNext() { }

	[Address(RVA = "0x1F13B30", Offset = "0x1F12F30", Length = "0xC")]
	[Token(Token = "0x6001D92")]
	public override void Reset() { }

	[Address(RVA = "0x1F13B40", Offset = "0x1F12F40", Length = "0x5F")]
	[Token(Token = "0x6001D90")]
	private override object System.Collections.IEnumerator.get_Current() { }

}

