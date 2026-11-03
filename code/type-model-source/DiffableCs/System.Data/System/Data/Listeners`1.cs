namespace System.Data;

[Token(Token = "0x200008C")]
internal sealed class Listeners
{
	[Token(Token = "0x200008D")]
	public sealed class Action : MulticastDelegate
	{

		[Address(RVA = "0x1C4D500", Offset = "0x1C4C900", Length = "0x125")]
		[Token(Token = "0x6000735")]
		public Action`4(object object, IntPtr method) { }

		[Address(RVA = "0x1C4CE30", Offset = "0x1C4C230", Length = "0x1D")]
		[Token(Token = "0x6000736")]
		public override void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

	}

	[Token(Token = "0x200008E")]
	public sealed class Func : MulticastDelegate
	{

		[Address(RVA = "0xE2CCE0", Offset = "0xE2C0E0", Length = "0x124")]
		[Token(Token = "0x6000737")]
		public Func`2(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6000738")]
		public override TResult Invoke(T1 arg1) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002B9")]
	private readonly List<TElem> _listeners; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002BA")]
	private readonly Func<TElem, TElem, Boolean> _filter; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002BB")]
	private readonly int _objectID; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002BC")]
	private int _listenerReaderCount; //Field offset: 0x0

	[Token(Token = "0x17000117")]
	internal bool HasListeners
	{
		[Address(RVA = "0xCEED00", Offset = "0xCEE100", Length = "0x1E")]
		[Token(Token = "0x600072F")]
		internal get { } //Length: 30
	}

	[Address(RVA = "0xCEEC40", Offset = "0xCEE040", Length = "0xB4")]
	[Token(Token = "0x600072E")]
	internal Listeners`1(int ObjectID, Func<TElem, TElem, Boolean> notifyFilter) { }

	[Address(RVA = "0xCEEA60", Offset = "0xCEDE60", Length = "0x7C")]
	[Token(Token = "0x6000730")]
	internal void Add(TElem listener) { }

	[Address(RVA = "0xCEED00", Offset = "0xCEE100", Length = "0x1E")]
	[Token(Token = "0x600072F")]
	internal bool get_HasListeners() { }

	[Address(RVA = "0xCEEAE0", Offset = "0xCEDEE0", Length = "0x18")]
	[Token(Token = "0x6000731")]
	internal int IndexOfReference(TElem listener) { }

	[Address(RVA = "0x69C650", Offset = "0x69BA50", Length = "0x1EB")]
	[Token(Token = "0x6000733")]
	internal void Notify(T1 arg1, T2 arg2, T3 arg3, Action<TElem, TElem, T1, T2, T3> action) { }

	[Address(RVA = "0xCEEB80", Offset = "0xCEDF80", Length = "0xB7")]
	[Token(Token = "0x6000732")]
	internal void Remove(TElem listener) { }

	[Address(RVA = "0xCEEB00", Offset = "0xCEDF00", Length = "0x7D")]
	[Token(Token = "0x6000734")]
	private void RemoveNullListeners(int nullIndex) { }

}

