namespace System.IO;

[Token(Token = "0x2000650")]
public abstract class TextReader : MarshalByRefObject, IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x2000653")]
	private sealed class <>c
	{
		[Token(Token = "0x4001963")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4001964")]
		public static Func<Object, Int32> <>9__17_0; //Field offset: 0x8

		[Address(RVA = "0x1FE94C0", Offset = "0x1FE88C0", Length = "0x67")]
		[Token(Token = "0x6002F00")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6002F01")]
		public <>c() { }

		[Address(RVA = "0x1FE9130", Offset = "0x1FE8530", Length = "0xE5")]
		[Token(Token = "0x6002F02")]
		internal int <ReadAsyncInternal>b__17_0(object state) { }

	}

	[Token(Token = "0x2000651")]
	private sealed class NullTextReader : TextReader
	{

		[Address(RVA = "0x1FDCA70", Offset = "0x1FDBE70", Length = "0x49")]
		[Token(Token = "0x6002EF4")]
		public NullTextReader() { }

		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6002EF5")]
		public virtual int Read(Char[] buffer, int index, int count) { }

		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6002EF6")]
		public virtual string ReadLine() { }

	}

	[Token(Token = "0x2000652")]
	public sealed class SyncTextReader : TextReader
	{
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001962")]
		internal readonly TextReader _in; //Field offset: 0x18

		[Address(RVA = "0x1FE3D60", Offset = "0x1FE3160", Length = "0x65")]
		[Token(Token = "0x6002EF7")]
		internal SyncTextReader(TextReader t) { }

		[Address(RVA = "0x1FE3A40", Offset = "0x1FE2E40", Length = "0x2A")]
		[Token(Token = "0x6002EF8")]
		public virtual void Close() { }

		[Address(RVA = "0x1FE3A70", Offset = "0x1FE2E70", Length = "0x57")]
		[Token(Token = "0x6002EF9")]
		protected virtual void Dispose(bool disposing) { }

		[Address(RVA = "0x1E6B860", Offset = "0x1E6AC60", Length = "0x2A")]
		[Token(Token = "0x6002EFA")]
		public virtual int Peek() { }

		[Address(RVA = "0x1FE3D30", Offset = "0x1FE3130", Length = "0x2A")]
		[Token(Token = "0x6002EFB")]
		public virtual int Read() { }

		[Address(RVA = "0x1FE3D00", Offset = "0x1FE3100", Length = "0x2F")]
		[Token(Token = "0x6002EFC")]
		public virtual int Read(Char[] buffer, int index, int count) { }

		[Address(RVA = "0x1FE3AD0", Offset = "0x1FE2ED0", Length = "0x1C5")]
		[Token(Token = "0x6002EFF")]
		public virtual Task<Int32> ReadAsync(Char[] buffer, int index, int count) { }

		[Address(RVA = "0x1FE3CA0", Offset = "0x1FE30A0", Length = "0x2A")]
		[Token(Token = "0x6002EFD")]
		public virtual string ReadLine() { }

		[Address(RVA = "0x1FE3CD0", Offset = "0x1FE30D0", Length = "0x2A")]
		[Token(Token = "0x6002EFE")]
		public virtual string ReadToEnd() { }

	}

	[Token(Token = "0x4001961")]
	public static readonly TextReader Null; //Field offset: 0x0

	[Address(RVA = "0x1FE5010", Offset = "0x1FE4410", Length = "0xA4")]
	[Token(Token = "0x6002EF3")]
	private static TextReader() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6002EE6")]
	protected TextReader() { }

	[Address(RVA = "0x1FE4350", Offset = "0x1FE3750", Length = "0x61")]
	[Token(Token = "0x6002EE7")]
	public override void Close() { }

	[Address(RVA = "0x1FE43C0", Offset = "0x1FE37C0", Length = "0x61")]
	[Token(Token = "0x6002EE8")]
	public override void Dispose() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6002EE9")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1D37710", Offset = "0x1D36B10", Length = "0x6")]
	[Token(Token = "0x6002EEA")]
	public override int Peek() { }

	[Address(RVA = "0x1D37710", Offset = "0x1D36B10", Length = "0x6")]
	[Token(Token = "0x6002EEB")]
	public override int Read() { }

	[Address(RVA = "0x1FE4CF0", Offset = "0x1FE40F0", Length = "0x21A")]
	[Token(Token = "0x6002EEC")]
	public override int Read(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x1FE4AE0", Offset = "0x1FE3EE0", Length = "0x20B")]
	[Token(Token = "0x6002EED")]
	public override int Read(Span<Char> buffer) { }

	[Address(RVA = "0x1FE46A0", Offset = "0x1FE3AA0", Length = "0x21A")]
	[Token(Token = "0x6002EF0")]
	public override Task<Int32> ReadAsync(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x1FE4430", Offset = "0x1FE3830", Length = "0x260")]
	[Token(Token = "0x6002EF1")]
	internal override ValueTask<Int32> ReadAsyncInternal(Memory<Char> buffer, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1FE48C0", Offset = "0x1FE3CC0", Length = "0x11B")]
	[Token(Token = "0x6002EEF")]
	public override string ReadLine() { }

	[Address(RVA = "0x1FE49E0", Offset = "0x1FE3DE0", Length = "0xFC")]
	[Token(Token = "0x6002EEE")]
	public override string ReadToEnd() { }

	[Address(RVA = "0x1FE4F10", Offset = "0x1FE4310", Length = "0xFA")]
	[Token(Token = "0x6002EF2")]
	public static TextReader Synchronized(TextReader reader) { }

}

