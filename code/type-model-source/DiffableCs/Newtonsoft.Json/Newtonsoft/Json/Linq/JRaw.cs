namespace Newtonsoft.Json.Linq;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x200017A")]
public class JRaw : JValue
{
	[CompilerGenerated]
	[Token(Token = "0x200017B")]
	private struct <CreateAsync>d__0 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006F3")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Nullable(0)]
		[Token(Token = "0x40006F4")]
		public AsyncTaskMethodBuilder<JRaw> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x40006F5")]
		public JsonReader reader; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40006F6")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x40006F7")]
		private StringWriter <sw>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Nullable(0)]
		[Token(Token = "0x40006F8")]
		private JsonTextWriter <jsonWriter>5__3; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40006F9")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		[Address(RVA = "0x2189A70", Offset = "0x2188E70", Length = "0x500")]
		[Token(Token = "0x6000C90")]
		private override void MoveNext() { }

		[Address(RVA = "0x2189F80", Offset = "0x2189380", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x6000C91")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[Address(RVA = "0x217D930", Offset = "0x217CD30", Length = "0xB")]
	[Token(Token = "0x6000C8B")]
	public JRaw(JRaw other) { }

	[Address(RVA = "0x217D940", Offset = "0x217CD40", Length = "0x8")]
	[Token(Token = "0x6000C8C")]
	internal JRaw(JRaw other, JsonCloneSettings settings) { }

	[Address(RVA = "0x217D920", Offset = "0x217CD20", Length = "0xE")]
	[NullableContext(2)]
	[Token(Token = "0x6000C8D")]
	public JRaw(object rawJson) { }

	[Address(RVA = "0x217D560", Offset = "0x217C960", Length = "0x64")]
	[Token(Token = "0x6000C8F")]
	internal virtual JToken CloneToken(JsonCloneSettings settings) { }

	[Address(RVA = "0x217D6F0", Offset = "0x217CAF0", Length = "0x227")]
	[Token(Token = "0x6000C8E")]
	public static JRaw Create(JsonReader reader) { }

	[Address(RVA = "0x217D5D0", Offset = "0x217C9D0", Length = "0x11D")]
	[AsyncStateMachine(typeof(<CreateAsync>d__0))]
	[Token(Token = "0x6000C8A")]
	public static Task<JRaw> CreateAsync(JsonReader reader, CancellationToken cancellationToken = null) { }

}

