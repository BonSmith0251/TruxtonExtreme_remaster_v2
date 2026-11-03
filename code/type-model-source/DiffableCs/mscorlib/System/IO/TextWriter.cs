namespace System.IO;

[Token(Token = "0x2000654")]
public abstract class TextWriter : MarshalByRefObject, IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x2000657")]
	private sealed class <>c
	{
		[Token(Token = "0x400196B")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400196C")]
		public static Action<Object> <>9__56_0; //Field offset: 0x8
		[Token(Token = "0x400196D")]
		public static Action<Object> <>9__57_0; //Field offset: 0x10
		[Token(Token = "0x400196E")]
		public static Action<Object> <>9__59_0; //Field offset: 0x18
		[Token(Token = "0x400196F")]
		public static Action<Object> <>9__67_0; //Field offset: 0x20

		[Address(RVA = "0x1FE9450", Offset = "0x1FE8850", Length = "0x67")]
		[Token(Token = "0x6002F34")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6002F35")]
		public <>c() { }

		[Address(RVA = "0x1FE90B0", Offset = "0x1FE84B0", Length = "0x7C")]
		[Token(Token = "0x6002F39")]
		internal void <FlushAsync>b__67_0(object state) { }

		[Address(RVA = "0x1FE9220", Offset = "0x1FE8620", Length = "0xA1")]
		[Token(Token = "0x6002F36")]
		internal void <WriteAsync>b__56_0(object state) { }

		[Address(RVA = "0x1FE92D0", Offset = "0x1FE86D0", Length = "0xA1")]
		[Token(Token = "0x6002F37")]
		internal void <WriteAsync>b__57_0(object state) { }

		[Address(RVA = "0x1FE9380", Offset = "0x1FE8780", Length = "0xC7")]
		[Token(Token = "0x6002F38")]
		internal void <WriteAsync>b__59_0(object state) { }

	}

	[Token(Token = "0x2000655")]
	private sealed class NullTextWriter : TextWriter
	{

		[Token(Token = "0x17000760")]
		public virtual Encoding Encoding
		{
			[Address(RVA = "0x1FDCA60", Offset = "0x1FDBE60", Length = "0x7")]
			[Token(Token = "0x6002F1B")]
			 get { } //Length: 7
		}

		[Address(RVA = "0x1FDCAC0", Offset = "0x1FDBEC0", Length = "0x81")]
		[Token(Token = "0x6002F1A")]
		internal NullTextWriter() { }

		[Address(RVA = "0x1FDCA60", Offset = "0x1FDBE60", Length = "0x7")]
		[Token(Token = "0x6002F1B")]
		public virtual Encoding get_Encoding() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6002F1C")]
		public virtual void Write(Char[] buffer, int index, int count) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6002F1D")]
		public virtual void Write(string value) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6002F20")]
		public virtual void Write(char value) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6002F1E")]
		public virtual void WriteLine() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6002F1F")]
		public virtual void WriteLine(string value) { }

	}

	[Token(Token = "0x2000656")]
	public sealed class SyncTextWriter : TextWriter, IDisposable
	{
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400196A")]
		private readonly TextWriter _out; //Field offset: 0x30

		[Token(Token = "0x17000761")]
		public virtual Encoding Encoding
		{
			[Address(RVA = "0x1FE42F0", Offset = "0x1FE36F0", Length = "0x2A")]
			[Token(Token = "0x6002F22")]
			 get { } //Length: 42
		}

		[Token(Token = "0x17000762")]
		public virtual IFormatProvider FormatProvider
		{
			[Address(RVA = "0x1F2EC70", Offset = "0x1F2E070", Length = "0x2A")]
			[Token(Token = "0x6002F23")]
			 get { } //Length: 42
		}

		[Token(Token = "0x17000763")]
		public virtual string NewLine
		{
			[Address(RVA = "0x1FE4320", Offset = "0x1FE3720", Length = "0x2A")]
			[Token(Token = "0x6002F24")]
			 get { } //Length: 42
		}

		[Address(RVA = "0x1FE4260", Offset = "0x1FE3660", Length = "0x89")]
		[Token(Token = "0x6002F21")]
		internal SyncTextWriter(TextWriter t) { }

		[Address(RVA = "0x1FE3DD0", Offset = "0x1FE31D0", Length = "0x2A")]
		[Token(Token = "0x6002F25")]
		public virtual void Close() { }

		[Address(RVA = "0x1FE3E00", Offset = "0x1FE3200", Length = "0x57")]
		[Token(Token = "0x6002F26")]
		protected virtual void Dispose(bool disposing) { }

		[Address(RVA = "0x1FE3F10", Offset = "0x1FE3310", Length = "0x2A")]
		[Token(Token = "0x6002F27")]
		public virtual void Flush() { }

		[Address(RVA = "0x1FE3E60", Offset = "0x1FE3260", Length = "0xA6")]
		[Token(Token = "0x6002F33")]
		public virtual Task FlushAsync() { }

		[Address(RVA = "0x1FE42F0", Offset = "0x1FE36F0", Length = "0x2A")]
		[Token(Token = "0x6002F22")]
		public virtual Encoding get_Encoding() { }

		[Address(RVA = "0x1F2EC70", Offset = "0x1F2E070", Length = "0x2A")]
		[Token(Token = "0x6002F23")]
		public virtual IFormatProvider get_FormatProvider() { }

		[Address(RVA = "0x1FE4320", Offset = "0x1FE3720", Length = "0x2A")]
		[Token(Token = "0x6002F24")]
		public virtual string get_NewLine() { }

		[Address(RVA = "0x1F2EA90", Offset = "0x1F2DE90", Length = "0x2A")]
		[Token(Token = "0x6002F28")]
		public virtual void Write(char value) { }

		[Address(RVA = "0x1F2EAC0", Offset = "0x1F2DEC0", Length = "0x2A")]
		[Token(Token = "0x6002F29")]
		public virtual void Write(Char[] buffer) { }

		[Address(RVA = "0x1F2ECA0", Offset = "0x1F2E0A0", Length = "0x2A")]
		[Token(Token = "0x6002F2B")]
		public virtual void Write(string value) { }

		[Address(RVA = "0x1FE4230", Offset = "0x1FE3630", Length = "0x2F")]
		[Token(Token = "0x6002F2A")]
		public virtual void Write(Char[] buffer, int index, int count) { }

		[Address(RVA = "0x1FE3F40", Offset = "0x1FE3340", Length = "0xDB")]
		[Token(Token = "0x6002F32")]
		public virtual Task WriteAsync(Char[] buffer, int index, int count) { }

		[Address(RVA = "0x1FE40E0", Offset = "0x1FE34E0", Length = "0xB5")]
		[Token(Token = "0x6002F30")]
		public virtual Task WriteAsync(char value) { }

		[Address(RVA = "0x1FE4020", Offset = "0x1FE3420", Length = "0xB5")]
		[Token(Token = "0x6002F31")]
		public virtual Task WriteAsync(string value) { }

		[Address(RVA = "0x1FE4200", Offset = "0x1FE3600", Length = "0x2A")]
		[Token(Token = "0x6002F2C")]
		public virtual void WriteLine() { }

		[Address(RVA = "0x1F2ECD0", Offset = "0x1F2E0D0", Length = "0x2A")]
		[Token(Token = "0x6002F2D")]
		public virtual void WriteLine(string value) { }

		[Address(RVA = "0x1FE41A0", Offset = "0x1FE35A0", Length = "0x2A")]
		[Token(Token = "0x6002F2E")]
		public virtual void WriteLine(string format, object arg0) { }

		[Address(RVA = "0x1FE41D0", Offset = "0x1FE35D0", Length = "0x2F")]
		[Token(Token = "0x6002F2F")]
		public virtual void WriteLine(string format, object arg0, object arg1, object arg2) { }

	}

	[Token(Token = "0x4001965")]
	public static readonly TextWriter Null; //Field offset: 0x0
	[Token(Token = "0x4001966")]
	private static readonly Char[] s_coreNewLine; //Field offset: 0x8
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001967")]
	protected Char[] CoreNewLine; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001968")]
	private string CoreNewLineStr; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001969")]
	private IFormatProvider _internalFormatProvider; //Field offset: 0x28

	[Token(Token = "0x1700075E")]
	public abstract Encoding Encoding
	{
		[Token(Token = "0x6002F0A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700075D")]
	public override IFormatProvider FormatProvider
	{
		[Address(RVA = "0x1FE6280", Offset = "0x1FE5680", Length = "0x57")]
		[Token(Token = "0x6002F05")]
		 get { } //Length: 87
	}

	[Token(Token = "0x1700075F")]
	public override string NewLine
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6002F0B")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1FE6010", Offset = "0x1FE5410", Length = "0x123")]
	[Token(Token = "0x6002F19")]
	private static TextWriter() { }

	[Address(RVA = "0x1FE6140", Offset = "0x1FE5540", Length = "0x95")]
	[Token(Token = "0x6002F03")]
	protected TextWriter() { }

	[Address(RVA = "0x1FE61E0", Offset = "0x1FE55E0", Length = "0x9E")]
	[Token(Token = "0x6002F04")]
	protected TextWriter(IFormatProvider formatProvider) { }

	[Address(RVA = "0x1FE50C0", Offset = "0x1FE44C0", Length = "0x61")]
	[Token(Token = "0x6002F06")]
	public override void Close() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6002F07")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1FE5130", Offset = "0x1FE4530", Length = "0x61")]
	[Token(Token = "0x6002F08")]
	public override void Dispose() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6002F09")]
	public override void Flush() { }

	[Address(RVA = "0x1FE51A0", Offset = "0x1FE45A0", Length = "0x21D")]
	[Token(Token = "0x6002F17")]
	public override Task FlushAsync() { }

	[Token(Token = "0x6002F0A")]
	public abstract Encoding get_Encoding() { }

	[Address(RVA = "0x1FE6280", Offset = "0x1FE5680", Length = "0x57")]
	[Token(Token = "0x6002F05")]
	public override IFormatProvider get_FormatProvider() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6002F0B")]
	public override string get_NewLine() { }

	[Address(RVA = "0x1FE53C0", Offset = "0x1FE47C0", Length = "0x114")]
	[Token(Token = "0x6002F18")]
	public static TextWriter Synchronized(TextWriter writer) { }

	[Address(RVA = "0x1FE5FD0", Offset = "0x1FE53D0", Length = "0x3A")]
	[Token(Token = "0x6002F0F")]
	public override void Write(string value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6002F0C")]
	public override void Write(char value) { }

	[Address(RVA = "0x1FE5D90", Offset = "0x1FE5190", Length = "0x2E")]
	[Token(Token = "0x6002F0D")]
	public override void Write(Char[] buffer) { }

	[Address(RVA = "0x1FE5DC0", Offset = "0x1FE51C0", Length = "0x207")]
	[Token(Token = "0x6002F0E")]
	public override void Write(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x1FE54E0", Offset = "0x1FE48E0", Length = "0x25D")]
	[Token(Token = "0x6002F14")]
	public override Task WriteAsync(char value) { }

	[Address(RVA = "0x1FE59C0", Offset = "0x1FE4DC0", Length = "0x25C")]
	[Token(Token = "0x6002F15")]
	public override Task WriteAsync(string value) { }

	[Address(RVA = "0x1FE5740", Offset = "0x1FE4B40", Length = "0x27A")]
	[Token(Token = "0x6002F16")]
	public override Task WriteAsync(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x1FE5D00", Offset = "0x1FE5100", Length = "0x18")]
	[Token(Token = "0x6002F10")]
	public override void WriteLine() { }

	[Address(RVA = "0x1FE5C20", Offset = "0x1FE5020", Length = "0x41")]
	[Token(Token = "0x6002F11")]
	public override void WriteLine(string value) { }

	[Address(RVA = "0x1FE5D20", Offset = "0x1FE5120", Length = "0x65")]
	[Token(Token = "0x6002F12")]
	public override void WriteLine(string format, object arg0) { }

	[Address(RVA = "0x1FE5C70", Offset = "0x1FE5070", Length = "0x87")]
	[Token(Token = "0x6002F13")]
	public override void WriteLine(string format, object arg0, object arg1, object arg2) { }

}

