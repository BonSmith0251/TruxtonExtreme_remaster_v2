namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000096")]
internal class Base64Encoder
{
	[CompilerGenerated]
	[Token(Token = "0x2000097")]
	private struct <EncodeAsync>d__13 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000374")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000375")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000376")]
		public Base64Encoder <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(0)]
		[Token(Token = "0x4000377")]
		public Byte[] buffer; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000378")]
		public int index; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000379")]
		public int count; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400037A")]
		public CancellationToken cancellationToken; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400037B")]
		private int <num4>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x400037C")]
		private int <length>5__3; //Field offset: 0x44
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400037D")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48

		[Address(RVA = "0x2131160", Offset = "0x2130560", Length = "0x44E")]
		[Token(Token = "0x60004F7")]
		private override void MoveNext() { }

		[Address(RVA = "0x21315B0", Offset = "0x21309B0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x60004F8")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x400036E")]
	private const int Base64LineSize = 76; //Field offset: 0x0
	[Token(Token = "0x400036F")]
	private const int LineSizeInBytes = 57; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000370")]
	private readonly Char[] _charsLine; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000371")]
	private readonly TextWriter _writer; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Nullable(2)]
	[Token(Token = "0x4000372")]
	private Byte[] _leftOverBytes; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000373")]
	private int _leftOverBytesCount; //Field offset: 0x28

	[Address(RVA = "0x2117FA0", Offset = "0x21173A0", Length = "0x8F")]
	[Token(Token = "0x60004ED")]
	public Base64Encoder(TextWriter writer) { }

	[Address(RVA = "0x2117780", Offset = "0x2116B80", Length = "0x208")]
	[Token(Token = "0x60004EF")]
	public void Encode(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x2117640", Offset = "0x2116A40", Length = "0x13B")]
	[AsyncStateMachine(typeof(<EncodeAsync>d__13))]
	[Token(Token = "0x60004F4")]
	public Task EncodeAsync(Byte[] buffer, int index, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2117AF0", Offset = "0x2116EF0", Length = "0xCC")]
	[Token(Token = "0x60004F2")]
	public void Flush() { }

	[Address(RVA = "0x2117990", Offset = "0x2116D90", Length = "0x15A")]
	[Token(Token = "0x60004F6")]
	public Task FlushAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2117BC0", Offset = "0x2116FC0", Length = "0xB4")]
	[Token(Token = "0x60004F1")]
	private bool FulfillFromLeftover(Byte[] buffer, int index, ref int count) { }

	[Address(RVA = "0x2117C80", Offset = "0x2117080", Length = "0xFB")]
	[Token(Token = "0x60004F0")]
	private void StoreLeftOverBytes(Byte[] buffer, int index, ref int count) { }

	[Address(RVA = "0x2117D80", Offset = "0x2117180", Length = "0x151")]
	[Token(Token = "0x60004EE")]
	private void ValidateEncode(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x2117F70", Offset = "0x2117370", Length = "0x2F")]
	[Token(Token = "0x60004F3")]
	private void WriteChars(Char[] chars, int index, int count) { }

	[Address(RVA = "0x2117EE0", Offset = "0x21172E0", Length = "0x83")]
	[Token(Token = "0x60004F5")]
	private Task WriteCharsAsync(Char[] chars, int index, int count, CancellationToken cancellationToken) { }

}

