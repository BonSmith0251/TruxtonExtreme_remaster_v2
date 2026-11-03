namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000035")]
public class JsonTextReader : JsonReader, IJsonLineInfo
{
	[CompilerGenerated]
	[Token(Token = "0x2000036")]
	private struct <DoReadAsBooleanAsync>d__40 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000103")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Nullable(0)]
		[Token(Token = "0x4000104")]
		public AsyncTaskMethodBuilder<Nullable`1<Boolean>> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000105")]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000106")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x4000107")]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000108")]
		private BigInteger <i>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000109")]
		private bool <isTrue>5__3; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400010A")]
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x58

		[Address(RVA = "0x20F1D50", Offset = "0x20F1150", Length = "0x6CC")]
		[Token(Token = "0x600026D")]
		private override void MoveNext() { }

		[Address(RVA = "0x20F2C20", Offset = "0x20F2020", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x600026E")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000037")]
	private struct <DoReadAsBytesAsync>d__42 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400010B")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Nullable(0)]
		[Token(Token = "0x400010C")]
		public AsyncTaskMethodBuilder<Byte[]> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x400010D")]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400010E")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400010F")]
		private bool <isWrapped>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Nullable(0)]
		[Token(Token = "0x4000110")]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x38
		[FieldOffset(Offset = "0x48")]
		[Nullable(0)]
		[Token(Token = "0x4000111")]
		private Byte[] <data>5__3; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000112")]
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 2})]
		[Token(Token = "0x4000113")]
		private ConfiguredTaskAwaiter<Byte[]> <>u__3; //Field offset: 0x60

		[Address(RVA = "0x20F2C90", Offset = "0x20F2090", Length = "0xDFC")]
		[Token(Token = "0x600026F")]
		private override void MoveNext() { }

		[Address(RVA = "0x20F3AF0", Offset = "0x20F2EF0", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x6000270")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000038")]
	private struct <DoReadAsDateTimeAsync>d__45 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000114")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Nullable(0)]
		[Token(Token = "0x4000115")]
		public AsyncTaskMethodBuilder<Nullable`1<DateTime>> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000116")]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000117")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 2})]
		[Token(Token = "0x4000118")]
		private ConfiguredTaskAwaiter<Object> <>u__1; //Field offset: 0x30

		[Address(RVA = "0x20F3B60", Offset = "0x20F2F60", Length = "0x249")]
		[Token(Token = "0x6000271")]
		private override void MoveNext() { }

		[Address(RVA = "0x20F3DB0", Offset = "0x20F31B0", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x6000272")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000039")]
	private struct <DoReadAsDateTimeOffsetAsync>d__47 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000119")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Nullable(0)]
		[Token(Token = "0x400011A")]
		public AsyncTaskMethodBuilder<Nullable`1<DateTimeOffset>> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x400011B")]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400011C")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 2})]
		[Token(Token = "0x400011D")]
		private ConfiguredTaskAwaiter<Object> <>u__1; //Field offset: 0x30

		[Address(RVA = "0x20F3E20", Offset = "0x20F3220", Length = "0x25D")]
		[Token(Token = "0x6000273")]
		private override void MoveNext() { }

		[Address(RVA = "0x20F4080", Offset = "0x20F3480", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x6000274")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200003A")]
	private struct <DoReadAsDecimalAsync>d__49 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400011E")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Nullable(0)]
		[Token(Token = "0x400011F")]
		public AsyncTaskMethodBuilder<Nullable`1<Decimal>> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000120")]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000121")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 2})]
		[Token(Token = "0x4000122")]
		private ConfiguredTaskAwaiter<Object> <>u__1; //Field offset: 0x30

		[Address(RVA = "0x20F40F0", Offset = "0x20F34F0", Length = "0x25D")]
		[Token(Token = "0x6000275")]
		private override void MoveNext() { }

		[Address(RVA = "0x20F4350", Offset = "0x20F3750", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x6000276")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200003B")]
	private struct <DoReadAsDoubleAsync>d__51 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000123")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Nullable(0)]
		[Token(Token = "0x4000124")]
		public AsyncTaskMethodBuilder<Nullable`1<Double>> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000125")]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000126")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 2})]
		[Token(Token = "0x4000127")]
		private ConfiguredTaskAwaiter<Object> <>u__1; //Field offset: 0x30

		[Address(RVA = "0x20F43C0", Offset = "0x20F37C0", Length = "0x249")]
		[Token(Token = "0x6000277")]
		private override void MoveNext() { }

		[Address(RVA = "0x20F4610", Offset = "0x20F3A10", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x6000278")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200003C")]
	private struct <DoReadAsInt32Async>d__53 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000128")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Nullable(0)]
		[Token(Token = "0x4000129")]
		public AsyncTaskMethodBuilder<Nullable`1<Int32>> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x400012A")]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400012B")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 2})]
		[Token(Token = "0x400012C")]
		private ConfiguredTaskAwaiter<Object> <>u__1; //Field offset: 0x30

		[Address(RVA = "0x20F4680", Offset = "0x20F3A80", Length = "0x237")]
		[Token(Token = "0x6000279")]
		private override void MoveNext() { }

		[Address(RVA = "0x20F48C0", Offset = "0x20F3CC0", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x600027A")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200003D")]
	private struct <DoReadAsStringAsync>d__55 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400012D")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Nullable(0)]
		[Token(Token = "0x400012E")]
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x400012F")]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000130")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 2})]
		[Token(Token = "0x4000131")]
		private ConfiguredTaskAwaiter<Object> <>u__1; //Field offset: 0x30

		[Address(RVA = "0x20F4930", Offset = "0x20F3D30", Length = "0x20B")]
		[Token(Token = "0x600027B")]
		private override void MoveNext() { }

		[Address(RVA = "0x20F4B40", Offset = "0x20F3F40", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x600027C")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200003E")]
	private struct <DoReadAsync>d__3 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000132")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Nullable(0)]
		[Token(Token = "0x4000133")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000134")]
		public Task<Boolean> task; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(0)]
		[Token(Token = "0x4000135")]
		public JsonTextReader <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000136")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Nullable(0)]
		[Token(Token = "0x4000137")]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x38

		[Address(RVA = "0x20F4BB0", Offset = "0x20F3FB0", Length = "0x2BD")]
		[Token(Token = "0x600027D")]
		private override void MoveNext() { }

		[Address(RVA = "0x20F4E70", Offset = "0x20F4270", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x600027E")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200003F")]
	private struct <EatWhitespaceAsync>d__17 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000138")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000139")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x400013A")]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400013B")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x400013C")]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400013D")]
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x40

		[Address(RVA = "0x20F4EE0", Offset = "0x20F42E0", Length = "0x37E")]
		[Token(Token = "0x600027F")]
		private override void MoveNext() { }

		[Address(RVA = "0x20F5260", Offset = "0x20F4660", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6000280")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000040")]
	private struct <HandleNullAsync>d__35 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400013E")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400013F")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000140")]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000141")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x4000142")]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000143")]
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x40

		[Address(RVA = "0x20F52C0", Offset = "0x20F46C0", Length = "0x3E8")]
		[Token(Token = "0x6000281")]
		private override void MoveNext() { }

		[Address(RVA = "0x20F56B0", Offset = "0x20F4AB0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6000282")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000041")]
	private struct <MatchAndSetAsync>d__21 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000144")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000145")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000146")]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(0)]
		[Token(Token = "0x4000147")]
		public string value; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000148")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000149")]
		public JsonToken newToken; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Nullable(0)]
		[Token(Token = "0x400014A")]
		public object tokenValue; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Nullable(0)]
		[Token(Token = "0x400014B")]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x48

		[Address(RVA = "0x20F5710", Offset = "0x20F4B10", Length = "0x2A0")]
		[Token(Token = "0x6000283")]
		private override void MoveNext() { }

		[Address(RVA = "0x20F59C0", Offset = "0x20F4DC0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6000284")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000042")]
	private struct <MatchValueAsync>d__19 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400014C")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Nullable(0)]
		[Token(Token = "0x400014D")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x400014E")]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(0)]
		[Token(Token = "0x400014F")]
		public string value; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000150")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Nullable(0)]
		[Token(Token = "0x4000151")]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x38

		[Address(RVA = "0x20F5A20", Offset = "0x20F4E20", Length = "0x22E")]
		[Token(Token = "0x6000285")]
		private override void MoveNext() { }

		[Address(RVA = "0x20F5C50", Offset = "0x20F5050", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x6000286")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000043")]
	private struct <MatchValueWithTrailingSeparatorAsync>d__20 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000152")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Nullable(0)]
		[Token(Token = "0x4000153")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000154")]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(0)]
		[Token(Token = "0x4000155")]
		public string value; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000156")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Nullable(0)]
		[Token(Token = "0x4000157")]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x38

		[Address(RVA = "0x20F5CC0", Offset = "0x20F50C0", Length = "0x38E")]
		[Token(Token = "0x6000287")]
		private override void MoveNext() { }

		[Address(RVA = "0x20F6050", Offset = "0x20F5450", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x6000288")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000044")]
	private struct <ParseCommentAsync>d__16 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000158")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000159")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x400015A")]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400015B")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400015C")]
		public bool setToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x31")]
		[Token(Token = "0x400015D")]
		private bool <singlelineComment>5__2; //Field offset: 0x31
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x400015E")]
		private int <initialPosition>5__3; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Nullable(0)]
		[Token(Token = "0x400015F")]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x38
		[FieldOffset(Offset = "0x48")]
		[Nullable(0)]
		[Token(Token = "0x4000160")]
		private ConfiguredTaskAwaiter<Int32> <>u__2; //Field offset: 0x48
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000161")]
		private ConfiguredTaskAwaiter <>u__3; //Field offset: 0x58

		[Address(RVA = "0x20F60C0", Offset = "0x20F54C0", Length = "0x838")]
		[Token(Token = "0x6000289")]
		private override void MoveNext() { }

		[Address(RVA = "0x20F6900", Offset = "0x20F5D00", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x600028A")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000045")]
	private struct <ParseConstructorAsync>d__25 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000162")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000163")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000164")]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000165")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x4000166")]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000167")]
		private int <initialPosition>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x4000168")]
		private int <endPosition>5__3; //Field offset: 0x44
		[FieldOffset(Offset = "0x48")]
		[Nullable(0)]
		[Token(Token = "0x4000169")]
		private string <constructorName>5__4; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400016A")]
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Nullable(0)]
		[Token(Token = "0x400016B")]
		private ConfiguredTaskAwaiter<Int32> <>u__3; //Field offset: 0x60

		[Address(RVA = "0x20F6960", Offset = "0x20F5D60", Length = "0x969")]
		[Token(Token = "0x600028B")]
		private override void MoveNext() { }

		[Address(RVA = "0x20F72D0", Offset = "0x20F66D0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x600028C")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000046")]
	private struct <ParseNumberAsync>d__29 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400016C")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400016D")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x400016E")]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400016F")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000170")]
		public ReadType readType; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000171")]
		private char <firstChar>5__2; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000172")]
		private int <initialPosition>5__3; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000173")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		[Address(RVA = "0x20F7330", Offset = "0x20F6730", Length = "0x1FE")]
		[Token(Token = "0x600028D")]
		private override void MoveNext() { }

		[Address(RVA = "0x20F7530", Offset = "0x20F6930", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x600028E")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000047")]
	private struct <ParseNumberNaNAsync>d__26 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000174")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Nullable(0)]
		[Token(Token = "0x4000175")]
		public AsyncTaskMethodBuilder<Object> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000176")]
		public ReadType readType; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(0)]
		[Token(Token = "0x4000177")]
		public JsonTextReader <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000178")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000179")]
		private ReadType <>7__wrap1; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Nullable(0)]
		[Token(Token = "0x400017A")]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x40

		[Address(RVA = "0x20F7590", Offset = "0x20F6990", Length = "0x249")]
		[Token(Token = "0x600028F")]
		private override void MoveNext() { }

		[Address(RVA = "0x20F77E0", Offset = "0x20F6BE0", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x6000290")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000048")]
	private struct <ParseNumberNegativeInfinityAsync>d__28 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400017B")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Nullable(0)]
		[Token(Token = "0x400017C")]
		public AsyncTaskMethodBuilder<Object> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400017D")]
		public ReadType readType; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(0)]
		[Token(Token = "0x400017E")]
		public JsonTextReader <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400017F")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000180")]
		private ReadType <>7__wrap1; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Nullable(0)]
		[Token(Token = "0x4000181")]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x40

		[Address(RVA = "0x20F7850", Offset = "0x20F6C50", Length = "0x249")]
		[Token(Token = "0x6000291")]
		private override void MoveNext() { }

		[Address(RVA = "0x20F7AA0", Offset = "0x20F6EA0", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x6000292")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000049")]
	private struct <ParseNumberPositiveInfinityAsync>d__27 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000182")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Nullable(0)]
		[Token(Token = "0x4000183")]
		public AsyncTaskMethodBuilder<Object> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000184")]
		public ReadType readType; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(0)]
		[Token(Token = "0x4000185")]
		public JsonTextReader <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000186")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000187")]
		private ReadType <>7__wrap1; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Nullable(0)]
		[Token(Token = "0x4000188")]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x40

		[Address(RVA = "0x20F7B10", Offset = "0x20F6F10", Length = "0x249")]
		[Token(Token = "0x6000293")]
		private override void MoveNext() { }

		[Address(RVA = "0x20F7D60", Offset = "0x20F7160", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x6000294")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200004A")]
	private struct <ParseObjectAsync>d__15 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000189")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Nullable(0)]
		[Token(Token = "0x400018A")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x400018B")]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400018C")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x400018D")]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400018E")]
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Nullable(0)]
		[Token(Token = "0x400018F")]
		private ConfiguredTaskAwaiter<Boolean> <>u__3; //Field offset: 0x50

		[Address(RVA = "0x20F7DD0", Offset = "0x20F71D0", Length = "0x5D3")]
		[Token(Token = "0x6000295")]
		private override void MoveNext() { }

		[Address(RVA = "0x20F83B0", Offset = "0x20F77B0", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x6000296")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200004B")]
	private struct <ParsePostValueAsync>d__4 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000190")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Nullable(0)]
		[Token(Token = "0x4000191")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000192")]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000193")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000194")]
		public bool ignoreComments; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Nullable(0)]
		[Token(Token = "0x4000195")]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x38
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000196")]
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x48

		[Address(RVA = "0x20F8420", Offset = "0x20F7820", Length = "0x5FE")]
		[Token(Token = "0x6000297")]
		private override void MoveNext() { }

		[Address(RVA = "0x20F8A20", Offset = "0x20F7E20", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x6000298")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200004C")]
	private struct <ParsePropertyAsync>d__31 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000197")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Nullable(0)]
		[Token(Token = "0x4000198")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000199")]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400019A")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400019B")]
		private char <quoteChar>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Nullable(0)]
		[Token(Token = "0x400019C")]
		private string <propertyName>5__3; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400019D")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		[Address(RVA = "0x20F8A90", Offset = "0x20F7E90", Length = "0x666")]
		[Token(Token = "0x6000299")]
		private override void MoveNext() { }

		[Address(RVA = "0x20F9100", Offset = "0x20F8500", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x600029A")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200004D")]
	private struct <ParseStringAsync>d__18 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400019E")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400019F")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001A0")]
		public CancellationToken cancellationToken; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(0)]
		[Token(Token = "0x40001A1")]
		public JsonTextReader <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001A2")]
		public char quote; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x40001A3")]
		public ReadType readType; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40001A4")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		[Address(RVA = "0x20F9170", Offset = "0x20F8570", Length = "0x1EB")]
		[Token(Token = "0x600029B")]
		private override void MoveNext() { }

		[Address(RVA = "0x20F9360", Offset = "0x20F8760", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x600029C")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200004E")]
	private struct <ParseUnicodeAsync>d__12 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001A5")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Nullable(0)]
		[Token(Token = "0x40001A6")]
		public AsyncTaskMethodBuilder<Char> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x40001A7")]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001A8")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x40001A9")]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		[Address(RVA = "0x20F93C0", Offset = "0x20F87C0", Length = "0x217")]
		[Token(Token = "0x600029D")]
		private override void MoveNext() { }

		[Address(RVA = "0x20F95E0", Offset = "0x20F89E0", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x600029E")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200004F")]
	private struct <ParseUnquotedPropertyAsync>d__33 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001AA")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001AB")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x40001AC")]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001AD")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001AE")]
		private int <initialPosition>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Nullable(0)]
		[Token(Token = "0x40001AF")]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x38

		[Address(RVA = "0x20F9650", Offset = "0x20F8A50", Length = "0x2F2")]
		[Token(Token = "0x600029F")]
		private override void MoveNext() { }

		[Address(RVA = "0x20F9950", Offset = "0x20F8D50", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x60002A0")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000050")]
	private struct <ParseValueAsync>d__8 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001B0")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Nullable(0)]
		[Token(Token = "0x40001B1")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x40001B2")]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001B3")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x40001B4")]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40001B5")]
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Nullable(0)]
		[Token(Token = "0x40001B6")]
		private ConfiguredTaskAwaiter<Boolean> <>u__3; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x40001B7")]
		private ConfiguredTaskAwaiter<Object> <>u__4; //Field offset: 0x60

		[Address(RVA = "0x20F99B0", Offset = "0x20F8DB0", Length = "0x126C")]
		[Token(Token = "0x60002A1")]
		private override void MoveNext() { }

		[Address(RVA = "0x20FAC80", Offset = "0x20FA080", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x60002A2")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000051")]
	private struct <ProcessCarriageReturnAsync>d__11 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001B8")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001B9")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x40001BA")]
		public Task<Boolean> task; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(0)]
		[Token(Token = "0x40001BB")]
		public JsonTextReader <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x40001BC")]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		[Address(RVA = "0x20FACF0", Offset = "0x20FA0F0", Length = "0x1C8")]
		[Token(Token = "0x60002A3")]
		private override void MoveNext() { }

		[Address(RVA = "0x20FAEC0", Offset = "0x20FA2C0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x60002A4")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000052")]
	private struct <ReadCharsAsync>d__14 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001BD")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Nullable(0)]
		[Token(Token = "0x40001BE")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x40001BF")]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001C0")]
		public int relativePosition; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40001C1")]
		public bool append; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001C2")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40001C3")]
		private int <charsRequired>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Nullable(0)]
		[Token(Token = "0x40001C4")]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x40

		[Address(RVA = "0x20FAF20", Offset = "0x20FA320", Length = "0x269")]
		[Token(Token = "0x60002A5")]
		private override void MoveNext() { }

		[Address(RVA = "0x20FB190", Offset = "0x20FA590", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x60002A6")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000053")]
	private struct <ReadDataAsync>d__7 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001C5")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Nullable(0)]
		[Token(Token = "0x40001C6")]
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x40001C7")]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001C8")]
		public bool append; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40001C9")]
		public int charsRequired; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001CA")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Nullable(0)]
		[Token(Token = "0x40001CB")]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x38

		[Address(RVA = "0x20FB200", Offset = "0x20FA600", Length = "0x2E4")]
		[Token(Token = "0x60002A7")]
		private override void MoveNext() { }

		[Address(RVA = "0x20FB4F0", Offset = "0x20FA8F0", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x60002A8")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000054")]
	private struct <ReadFinishedAsync>d__36 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001CC")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001CD")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x40001CE")]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001CF")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x40001D0")]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40001D1")]
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x40

		[Address(RVA = "0x20FB560", Offset = "0x20FA960", Length = "0x4C7")]
		[Token(Token = "0x60002A9")]
		private override void MoveNext() { }

		[Address(RVA = "0x20FBA30", Offset = "0x20FAE30", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x60002AA")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000055")]
	private struct <ReadFromFinishedAsync>d__5 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001D2")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Nullable(0)]
		[Token(Token = "0x40001D3")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x40001D4")]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001D5")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x40001D6")]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40001D7")]
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x40

		[Address(RVA = "0x20FBA90", Offset = "0x20FAE90", Length = "0x4ED")]
		[Token(Token = "0x60002AB")]
		private override void MoveNext() { }

		[Address(RVA = "0x20FBF80", Offset = "0x20FB380", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x60002AC")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000056")]
	private struct <ReadIntoWrappedTypeObjectAsync>d__43 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001D8")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001D9")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x40001DA")]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001DB")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001DC")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30

		[Address(RVA = "0x20FBFF0", Offset = "0x20FB3F0", Length = "0x553")]
		[Token(Token = "0x60002AD")]
		private override void MoveNext() { }

		[Address(RVA = "0x20FC550", Offset = "0x20FB950", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x60002AE")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000057")]
	private struct <ReadNullCharAsync>d__34 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001DD")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Nullable(0)]
		[Token(Token = "0x40001DE")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x40001DF")]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001E0")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x40001E1")]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x30

		[Address(RVA = "0x20FC5B0", Offset = "0x20FB9B0", Length = "0x221")]
		[Token(Token = "0x60002AF")]
		private override void MoveNext() { }

		[Address(RVA = "0x20FC7E0", Offset = "0x20FBBE0", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x60002B0")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000058")]
	private struct <ReadNumberIntoBufferAsync>d__32 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001E2")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001E3")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x40001E4")]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001E5")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001E6")]
		private int <charPos>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Nullable(0)]
		[Token(Token = "0x40001E7")]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x38

		[Address(RVA = "0x20FC850", Offset = "0x20FBC50", Length = "0x26D")]
		[Token(Token = "0x60002B1")]
		private override void MoveNext() { }

		[Address(RVA = "0x20FCAC0", Offset = "0x20FBEC0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x60002B2")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000059")]
	private struct <ReadNumberValueAsync>d__38 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001E8")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Nullable(0)]
		[Token(Token = "0x40001E9")]
		public AsyncTaskMethodBuilder<Object> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x40001EA")]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001EB")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001EC")]
		public ReadType readType; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Nullable(0)]
		[Token(Token = "0x40001ED")]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x38
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40001EE")]
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x48
		[FieldOffset(Offset = "0x58")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x40001EF")]
		private ConfiguredTaskAwaiter<Object> <>u__3; //Field offset: 0x58

		[Address(RVA = "0x20FCB20", Offset = "0x20FBF20", Length = "0x2A0")]
		[Token(Token = "0x60002B3")]
		private override void MoveNext() { }

		[Address(RVA = "0x20FDB50", Offset = "0x20FCF50", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x60002B4")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200005A")]
	private struct <ReadStringIntoBufferAsync>d__9 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001F0")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001F1")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x40001F2")]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001F3")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001F4")]
		public char quote; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x40001F5")]
		private int <charPos>5__2; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40001F6")]
		private int <initialPosition>5__3; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x40001F7")]
		private int <lastWritePosition>5__4; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40001F8")]
		private int <escapeStartPos>5__5; //Field offset: 0x40
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x40001F9")]
		private char <writeChar>5__6; //Field offset: 0x44
		[FieldOffset(Offset = "0x48")]
		[Nullable(0)]
		[Token(Token = "0x40001FA")]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x48
		[FieldOffset(Offset = "0x58")]
		[Nullable(0)]
		[Token(Token = "0x40001FB")]
		private ConfiguredTaskAwaiter<Boolean> <>u__2; //Field offset: 0x58
		[FieldOffset(Offset = "0x68")]
		[Nullable(0)]
		[Token(Token = "0x40001FC")]
		private ConfiguredTaskAwaiter<Char> <>u__3; //Field offset: 0x68
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x40001FD")]
		private bool <anotherHighSurrogate>5__7; //Field offset: 0x78
		[FieldOffset(Offset = "0x7A")]
		[Token(Token = "0x40001FE")]
		private char <highSurrogate>5__8; //Field offset: 0x7A
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x40001FF")]
		private ConfiguredTaskAwaiter <>u__4; //Field offset: 0x80

		[Address(RVA = "0x20FDBC0", Offset = "0x20FCFC0", Length = "0x144")]
		[Token(Token = "0x60002B5")]
		private override void MoveNext() { }

		[Address(RVA = "0x20FE920", Offset = "0x20FDD20", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x60002B6")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200005B")]
	private struct <ReadStringValueAsync>d__37 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000200")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Nullable(0)]
		[Token(Token = "0x4000201")]
		public AsyncTaskMethodBuilder<Object> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000202")]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000203")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000204")]
		public ReadType readType; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Nullable(0)]
		[Token(Token = "0x4000205")]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x38
		[FieldOffset(Offset = "0x48")]
		[Nullable(0)]
		[Token(Token = "0x4000206")]
		private string <expected>5__2; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000207")]
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x4000208")]
		private ConfiguredTaskAwaiter<Object> <>u__3; //Field offset: 0x60

		[Address(RVA = "0x20FE980", Offset = "0x20FDD80", Length = "0x698")]
		[Token(Token = "0x60002B7")]
		private override void MoveNext() { }

		[Address(RVA = "0x20FFB90", Offset = "0x20FEF90", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x60002B8")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x40000F5")]
	private const char UnicodeReplacementChar = '\uFFFD'; //Field offset: 0x0
	[Token(Token = "0x40000F6")]
	private const int MaximumJavascriptIntegerCharacterLength = 380; //Field offset: 0x0
	[Token(Token = "0x40000F7")]
	private const int LargeBufferLength = 1073741823; //Field offset: 0x0
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40000F4")]
	private readonly bool _safeAsync; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40000F8")]
	private readonly TextReader _reader; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Nullable(2)]
	[Token(Token = "0x40000F9")]
	private Char[] _chars; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40000FA")]
	private int _charsUsed; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x40000FB")]
	private int _charPos; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40000FC")]
	private int _lineStartPos; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x40000FD")]
	private int _lineNumber; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40000FE")]
	private bool _isEndOfFile; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40000FF")]
	private StringBuffer _stringBuffer; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000100")]
	private StringReference _stringReference; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC8")]
	[Nullable(2)]
	[Token(Token = "0x4000101")]
	private IArrayPool<Char> _arrayPool; //Field offset: 0xC8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xD0")]
	[Nullable(2)]
	[Token(Token = "0x4000102")]
	private JsonNameTable <PropertyNameTable>k__BackingField; //Field offset: 0xD0

	[Nullable(2)]
	[Token(Token = "0x17000081")]
	public IArrayPool<Char> ArrayPool
	{
		[Address(RVA = "0x20E7690", Offset = "0x20E6A90", Length = "0x8")]
		[NullableContext(2)]
		[Token(Token = "0x6000221")]
		 get { } //Length: 8
		[Address(RVA = "0x20E7710", Offset = "0x20E6B10", Length = "0x72")]
		[NullableContext(2)]
		[Token(Token = "0x6000222")]
		 set { } //Length: 114
	}

	[Token(Token = "0x17000082")]
	public override int LineNumber
	{
		[Address(RVA = "0x20E76A0", Offset = "0x20E6AA0", Length = "0x49")]
		[Token(Token = "0x600026B")]
		 get { } //Length: 73
	}

	[Token(Token = "0x17000083")]
	public override int LinePosition
	{
		[Address(RVA = "0x20E76F0", Offset = "0x20E6AF0", Length = "0xD")]
		[Token(Token = "0x600026C")]
		 get { } //Length: 13
	}

	[Nullable(2)]
	[Token(Token = "0x17000080")]
	public JsonNameTable PropertyNameTable
	{
		[Address(RVA = "0x20E7700", Offset = "0x20E6B00", Length = "0x8")]
		[CompilerGenerated]
		[NullableContext(2)]
		[Token(Token = "0x600021F")]
		 get { } //Length: 8
		[Address(RVA = "0x20E7790", Offset = "0x20E6B90", Length = "0x13")]
		[CompilerGenerated]
		[NullableContext(2)]
		[Token(Token = "0x6000220")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x20E7530", Offset = "0x20E6930", Length = "0x154")]
	[Token(Token = "0x600021E")]
	public JsonTextReader(TextReader reader) { }

	[Address(RVA = "0x20D9430", Offset = "0x20D8830", Length = "0x78")]
	[Token(Token = "0x6000258")]
	private static object BigIntegerParse(string number, CultureInfo culture) { }

	[Address(RVA = "0x20D94B0", Offset = "0x20D88B0", Length = "0x1D")]
	[Token(Token = "0x6000228")]
	private static void BlockCopyChars(Char[] src, int srcOffset, Char[] dst, int dstOffset, int count) { }

	[Address(RVA = "0x20D94D0", Offset = "0x20D88D0", Length = "0x15")]
	[Token(Token = "0x6000249")]
	private void ClearRecentString() { }

	[Address(RVA = "0x20D94F0", Offset = "0x20D88F0", Length = "0xA3")]
	[Token(Token = "0x6000269")]
	public virtual void Close() { }

	[Address(RVA = "0x20D95A0", Offset = "0x20D89A0", Length = "0x191")]
	[Token(Token = "0x6000245")]
	private char ConvertUnicode(bool enoughChars) { }

	[Address(RVA = "0x20D9740", Offset = "0x20D8B40", Length = "0xA8")]
	[Token(Token = "0x6000236")]
	private JsonReaderException CreateUnexpectedCharacterException(char c) { }

	[Address(RVA = "0x20D97F0", Offset = "0x20D8BF0", Length = "0x131")]
	[AsyncStateMachine(typeof(<DoReadAsBooleanAsync>d__40))]
	[Token(Token = "0x600020E")]
	internal Task<Nullable`1<Boolean>> DoReadAsBooleanAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20D9930", Offset = "0x20D8D30", Length = "0x130")]
	[AsyncStateMachine(typeof(<DoReadAsBytesAsync>d__42))]
	[Token(Token = "0x6000210")]
	internal Task<Byte[]> DoReadAsBytesAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20D9A60", Offset = "0x20D8E60", Length = "0x115")]
	[AsyncStateMachine(typeof(<DoReadAsDateTimeAsync>d__45))]
	[Token(Token = "0x6000213")]
	internal Task<Nullable`1<DateTime>> DoReadAsDateTimeAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20D9B80", Offset = "0x20D8F80", Length = "0x115")]
	[AsyncStateMachine(typeof(<DoReadAsDateTimeOffsetAsync>d__47))]
	[Token(Token = "0x6000215")]
	internal Task<Nullable`1<DateTimeOffset>> DoReadAsDateTimeOffsetAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20D9CA0", Offset = "0x20D90A0", Length = "0x115")]
	[AsyncStateMachine(typeof(<DoReadAsDecimalAsync>d__49))]
	[Token(Token = "0x6000217")]
	internal Task<Nullable`1<Decimal>> DoReadAsDecimalAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20D9DC0", Offset = "0x20D91C0", Length = "0x115")]
	[AsyncStateMachine(typeof(<DoReadAsDoubleAsync>d__51))]
	[Token(Token = "0x6000219")]
	internal Task<Nullable`1<Double>> DoReadAsDoubleAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20D9EE0", Offset = "0x20D92E0", Length = "0x115")]
	[AsyncStateMachine(typeof(<DoReadAsInt32Async>d__53))]
	[Token(Token = "0x600021B")]
	internal Task<Nullable`1<Int32>> DoReadAsInt32Async(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20DA000", Offset = "0x20D9400", Length = "0x115")]
	[AsyncStateMachine(typeof(<DoReadAsStringAsync>d__55))]
	[Token(Token = "0x600021D")]
	internal Task<String> DoReadAsStringAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20DA7F0", Offset = "0x20D9BF0", Length = "0x13C")]
	[AsyncStateMachine(typeof(<DoReadAsync>d__3))]
	[Token(Token = "0x60001E9")]
	private Task<Boolean> DoReadAsync(Task<Boolean> task, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20DA120", Offset = "0x20D9520", Length = "0x698")]
	[Token(Token = "0x60001E8")]
	internal Task<Boolean> DoReadAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20DAA30", Offset = "0x20D9E30", Length = "0x142")]
	[Token(Token = "0x6000253")]
	private void EatWhitespace() { }

	[Address(RVA = "0x20DA930", Offset = "0x20D9D30", Length = "0xF8")]
	[AsyncStateMachine(typeof(<EatWhitespaceAsync>d__17))]
	[Token(Token = "0x60001F7")]
	private Task EatWhitespaceAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20DAB80", Offset = "0x20D9F80", Length = "0x48")]
	[Token(Token = "0x600025A")]
	private void EndComment(bool setToken, int initialPosition, int endPosition) { }

	[Address(RVA = "0x20DAC30", Offset = "0x20DA030", Length = "0x66")]
	[Token(Token = "0x6000241")]
	private void EnsureBuffer() { }

	[Address(RVA = "0x20DABD0", Offset = "0x20D9FD0", Length = "0x5D")]
	[Token(Token = "0x6000223")]
	private void EnsureBufferNotEmpty() { }

	[Address(RVA = "0x20DAE80", Offset = "0x20DA280", Length = "0x149")]
	[Token(Token = "0x600022D")]
	private bool EnsureChars(int relativePosition, bool append) { }

	[Address(RVA = "0x20DACA0", Offset = "0x20DA0A0", Length = "0x1D5")]
	[Token(Token = "0x60001F3")]
	private Task<Boolean> EnsureCharsAsync(int relativePosition, bool append, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20DAFD0", Offset = "0x20DA3D0", Length = "0x16C")]
	[NullableContext(2)]
	[Token(Token = "0x600023A")]
	private object FinishReadQuotedNumber(ReadType readType) { }

	[Address(RVA = "0x20DB140", Offset = "0x20DA540", Length = "0x2C2")]
	[NullableContext(2)]
	[Token(Token = "0x6000235")]
	private object FinishReadQuotedStringValue(ReadType readType) { }

	[Address(RVA = "0x20DB410", Offset = "0x20DA810", Length = "0x10D")]
	[Token(Token = "0x6000243")]
	private void FinishReadStringIntoBuffer(int charPos, int initialPosition, int lastWritePosition) { }

	[Address(RVA = "0x20E7690", Offset = "0x20E6A90", Length = "0x8")]
	[NullableContext(2)]
	[Token(Token = "0x6000221")]
	public IArrayPool<Char> get_ArrayPool() { }

	[Address(RVA = "0x20E76A0", Offset = "0x20E6AA0", Length = "0x49")]
	[Token(Token = "0x600026B")]
	public override int get_LineNumber() { }

	[Address(RVA = "0x20E76F0", Offset = "0x20E6AF0", Length = "0xD")]
	[Token(Token = "0x600026C")]
	public override int get_LinePosition() { }

	[Address(RVA = "0x20E7700", Offset = "0x20E6B00", Length = "0x8")]
	[CompilerGenerated]
	[NullableContext(2)]
	[Token(Token = "0x600021F")]
	public JsonNameTable get_PropertyNameTable() { }

	[Address(RVA = "0x20DB620", Offset = "0x20DAA20", Length = "0x105")]
	[Token(Token = "0x600023E")]
	private void HandleNull() { }

	[Address(RVA = "0x20DB520", Offset = "0x20DA920", Length = "0xF8")]
	[AsyncStateMachine(typeof(<HandleNullAsync>d__35))]
	[Token(Token = "0x6000209")]
	private Task HandleNullAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600026A")]
	public override bool HasLineInfo() { }

	[Address(RVA = "0x20DB730", Offset = "0x20DAB30", Length = "0x121")]
	[Token(Token = "0x600025E")]
	private bool IsSeparator(char c) { }

	[Address(RVA = "0x20DB860", Offset = "0x20DAC60", Length = "0x14F")]
	[AsyncStateMachine(typeof(<MatchAndSetAsync>d__21))]
	[Token(Token = "0x60001FB")]
	private Task MatchAndSetAsync(string value, JsonToken newToken, object tokenValue, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20DBE60", Offset = "0x20DB260", Length = "0xDB")]
	[Token(Token = "0x600025C")]
	private bool MatchValue(bool enoughChars, string value) { }

	[Address(RVA = "0x20DBF40", Offset = "0x20DB340", Length = "0xE8")]
	[Token(Token = "0x600025B")]
	private bool MatchValue(string value) { }

	[Address(RVA = "0x20DB9B0", Offset = "0x20DADB0", Length = "0x13C")]
	[AsyncStateMachine(typeof(<MatchValueAsync>d__19))]
	[Token(Token = "0x60001F9")]
	private Task<Boolean> MatchValueAsync(string value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20DBC30", Offset = "0x20DB030", Length = "0x229")]
	[Token(Token = "0x600025D")]
	private bool MatchValueWithTrailingSeparator(string value) { }

	[Address(RVA = "0x20DBAF0", Offset = "0x20DAEF0", Length = "0x13C")]
	[AsyncStateMachine(typeof(<MatchValueWithTrailingSeparatorAsync>d__20))]
	[Token(Token = "0x60001FA")]
	private Task<Boolean> MatchValueWithTrailingSeparatorAsync(string value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20DC030", Offset = "0x20DB430", Length = "0xD")]
	[Token(Token = "0x6000225")]
	private void OnNewLine(int pos) { }

	[Address(RVA = "0x20DC160", Offset = "0x20DB560", Length = "0x3C5")]
	[Token(Token = "0x6000259")]
	private void ParseComment(bool setToken) { }

	[Address(RVA = "0x20DC040", Offset = "0x20DB440", Length = "0x117")]
	[AsyncStateMachine(typeof(<ParseCommentAsync>d__16))]
	[Token(Token = "0x60001F6")]
	private Task ParseCommentAsync(bool setToken, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20DC640", Offset = "0x20DBA40", Length = "0x3D4")]
	[Token(Token = "0x6000254")]
	private void ParseConstructor() { }

	[Address(RVA = "0x20DC530", Offset = "0x20DB930", Length = "0x105")]
	[AsyncStateMachine(typeof(<ParseConstructorAsync>d__25))]
	[Token(Token = "0x60001FF")]
	private Task ParseConstructorAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20DCAD0", Offset = "0x20DBED0", Length = "0xE8")]
	[Token(Token = "0x6000262")]
	private void ParseFalse() { }

	[Address(RVA = "0x20DCA20", Offset = "0x20DBE20", Length = "0xA3")]
	[Token(Token = "0x60001FD")]
	private Task ParseFalseAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20DCC40", Offset = "0x20DC040", Length = "0xB4")]
	[Token(Token = "0x6000260")]
	private void ParseNull() { }

	[Address(RVA = "0x20DCBC0", Offset = "0x20DBFC0", Length = "0x80")]
	[Token(Token = "0x60001FE")]
	private Task ParseNullAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20DDCB0", Offset = "0x20DD0B0", Length = "0x87")]
	[Token(Token = "0x6000255")]
	private void ParseNumber(ReadType readType) { }

	[Address(RVA = "0x20DCD00", Offset = "0x20DC100", Length = "0x107")]
	[AsyncStateMachine(typeof(<ParseNumberAsync>d__29))]
	[Token(Token = "0x6000203")]
	private Task ParseNumberAsync(ReadType readType, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20DCF40", Offset = "0x20DC340", Length = "0x1F2")]
	[Token(Token = "0x6000267")]
	private object ParseNumberNaN(ReadType readType) { }

	[Address(RVA = "0x20DD140", Offset = "0x20DC540", Length = "0x1A2")]
	[Token(Token = "0x6000268")]
	private object ParseNumberNaN(ReadType readType, bool matched) { }

	[Address(RVA = "0x20DCE10", Offset = "0x20DC210", Length = "0x12C")]
	[AsyncStateMachine(typeof(<ParseNumberNaNAsync>d__26))]
	[Token(Token = "0x6000200")]
	private Task<Object> ParseNumberNaNAsync(ReadType readType, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20DD420", Offset = "0x20DC820", Length = "0x1A2")]
	[Token(Token = "0x6000264")]
	private object ParseNumberNegativeInfinity(ReadType readType, bool matched) { }

	[Address(RVA = "0x20DD5D0", Offset = "0x20DC9D0", Length = "0x1F2")]
	[Token(Token = "0x6000263")]
	private object ParseNumberNegativeInfinity(ReadType readType) { }

	[Address(RVA = "0x20DD2F0", Offset = "0x20DC6F0", Length = "0x12C")]
	[AsyncStateMachine(typeof(<ParseNumberNegativeInfinityAsync>d__28))]
	[Token(Token = "0x6000202")]
	private Task<Object> ParseNumberNegativeInfinityAsync(ReadType readType, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20DDAB0", Offset = "0x20DCEB0", Length = "0x1F2")]
	[Token(Token = "0x6000265")]
	private object ParseNumberPositiveInfinity(ReadType readType) { }

	[Address(RVA = "0x20DD900", Offset = "0x20DCD00", Length = "0x1A2")]
	[Token(Token = "0x6000266")]
	private object ParseNumberPositiveInfinity(ReadType readType, bool matched) { }

	[Address(RVA = "0x20DD7D0", Offset = "0x20DCBD0", Length = "0x12C")]
	[AsyncStateMachine(typeof(<ParseNumberPositiveInfinityAsync>d__27))]
	[Token(Token = "0x6000201")]
	private Task<Object> ParseNumberPositiveInfinityAsync(ReadType readType, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20DDE70", Offset = "0x20DD270", Length = "0x1D1")]
	[Token(Token = "0x600024B")]
	private bool ParseObject() { }

	[Address(RVA = "0x20DDD40", Offset = "0x20DD140", Length = "0x125")]
	[AsyncStateMachine(typeof(<ParseObjectAsync>d__15))]
	[Token(Token = "0x60001F5")]
	private Task<Boolean> ParseObjectAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20DE190", Offset = "0x20DD590", Length = "0x334")]
	[Token(Token = "0x600024A")]
	private bool ParsePostValue(bool ignoreComments) { }

	[Address(RVA = "0x20DE050", Offset = "0x20DD450", Length = "0x137")]
	[AsyncStateMachine(typeof(<ParsePostValueAsync>d__4))]
	[Token(Token = "0x60001EA")]
	private Task<Boolean> ParsePostValueAsync(bool ignoreComments, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20DE5F0", Offset = "0x20DD9F0", Length = "0x2D2")]
	[Token(Token = "0x600024C")]
	private bool ParseProperty() { }

	[Address(RVA = "0x20DE4D0", Offset = "0x20DD8D0", Length = "0x11D")]
	[AsyncStateMachine(typeof(<ParsePropertyAsync>d__31))]
	[Token(Token = "0x6000205")]
	private Task<Boolean> ParsePropertyAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20DE8D0", Offset = "0x20DDCD0", Length = "0x10FC")]
	[Token(Token = "0x6000256")]
	private void ParseReadNumber(ReadType readType, char firstChar, int initialPosition) { }

	[Address(RVA = "0x20DF9F0", Offset = "0x20DEDF0", Length = "0x348")]
	[Token(Token = "0x6000227")]
	private void ParseReadString(char quote, ReadType readType) { }

	[Address(RVA = "0x20DFE80", Offset = "0x20DF280", Length = "0x53")]
	[Token(Token = "0x6000226")]
	private void ParseString(char quote, ReadType readType) { }

	[Address(RVA = "0x20DFD60", Offset = "0x20DF160", Length = "0x11A")]
	[AsyncStateMachine(typeof(<ParseStringAsync>d__18))]
	[Token(Token = "0x60001F8")]
	private Task ParseStringAsync(char quote, ReadType readType, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20DFF90", Offset = "0x20DF390", Length = "0xE7")]
	[Token(Token = "0x600025F")]
	private void ParseTrue() { }

	[Address(RVA = "0x20DFEE0", Offset = "0x20DF2E0", Length = "0xA3")]
	[Token(Token = "0x60001FC")]
	private Task ParseTrueAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20E0100", Offset = "0x20DF500", Length = "0xB4")]
	[Token(Token = "0x6000261")]
	private void ParseUndefined() { }

	[Address(RVA = "0x20E0080", Offset = "0x20DF480", Length = "0x80")]
	[Token(Token = "0x6000204")]
	private Task ParseUndefinedAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20E02E0", Offset = "0x20DF6E0", Length = "0x1A1")]
	[Token(Token = "0x6000246")]
	private char ParseUnicode() { }

	[Address(RVA = "0x20E01C0", Offset = "0x20DF5C0", Length = "0x115")]
	[AsyncStateMachine(typeof(<ParseUnicodeAsync>d__12))]
	[Token(Token = "0x60001F2")]
	private Task<Char> ParseUnicodeAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20E0590", Offset = "0x20DF990", Length = "0x1F4")]
	[Token(Token = "0x600024E")]
	private void ParseUnquotedProperty() { }

	[Address(RVA = "0x20E0490", Offset = "0x20DF890", Length = "0xF9")]
	[AsyncStateMachine(typeof(<ParseUnquotedPropertyAsync>d__33))]
	[Token(Token = "0x6000207")]
	private Task ParseUnquotedPropertyAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20E08C0", Offset = "0x20DFCC0", Length = "0x204")]
	[Token(Token = "0x6000250")]
	private bool ParseValue() { }

	[Address(RVA = "0x20E0790", Offset = "0x20DFB90", Length = "0x130")]
	[AsyncStateMachine(typeof(<ParseValueAsync>d__8))]
	[Token(Token = "0x60001EE")]
	private Task<Boolean> ParseValueAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20E1090", Offset = "0x20E0490", Length = "0x20C")]
	[Token(Token = "0x600022B")]
	private void PrepareBufferForReadData(bool append, int charsRequired) { }

	[Address(RVA = "0x20E1700", Offset = "0x20E0B00", Length = "0x6D")]
	[Token(Token = "0x6000252")]
	private void ProcessCarriageReturn(bool append) { }

	[Address(RVA = "0x20E12A0", Offset = "0x20E06A0", Length = "0xF1")]
	[AsyncStateMachine(typeof(<ProcessCarriageReturnAsync>d__11))]
	[Token(Token = "0x60001F1")]
	private Task ProcessCarriageReturnAsync(Task<Boolean> task) { }

	[Address(RVA = "0x20E13A0", Offset = "0x20E07A0", Length = "0x358")]
	[Token(Token = "0x60001F0")]
	private Task ProcessCarriageReturnAsync(bool append, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20E1770", Offset = "0x20E0B70", Length = "0x1B")]
	[Token(Token = "0x6000251")]
	private void ProcessLineFeed() { }

	[Address(RVA = "0x20E1790", Offset = "0x20E0B90", Length = "0x78")]
	[Token(Token = "0x6000238")]
	private void ProcessValueComma() { }

	[Address(RVA = "0x20E6FC0", Offset = "0x20E63C0", Length = "0x80")]
	[Token(Token = "0x600022F")]
	public virtual bool Read() { }

	[Address(RVA = "0x20E1A10", Offset = "0x20E0E10", Length = "0x980")]
	[Token(Token = "0x6000237")]
	public virtual Nullable<Boolean> ReadAsBoolean() { }

	[Address(RVA = "0x20E1810", Offset = "0x20E0C10", Length = "0x1F2")]
	[Token(Token = "0x600020D")]
	public virtual Task<Nullable`1<Boolean>> ReadAsBooleanAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20E2600", Offset = "0x20E1A00", Length = "0x8C8")]
	[NullableContext(2)]
	[Token(Token = "0x6000233")]
	public virtual Byte[] ReadAsBytes() { }

	[Address(RVA = "0x20E2400", Offset = "0x20E1800", Length = "0x1F1")]
	[Token(Token = "0x600020F")]
	public virtual Task<Byte[]> ReadAsBytesAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20E33D0", Offset = "0x20E27D0", Length = "0x9C")]
	[Token(Token = "0x6000231")]
	public virtual Nullable<DateTime> ReadAsDateTime() { }

	[Address(RVA = "0x20E2F00", Offset = "0x20E2300", Length = "0x1F3")]
	[Token(Token = "0x6000212")]
	public virtual Task<Nullable`1<DateTime>> ReadAsDateTimeAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20E3320", Offset = "0x20E2720", Length = "0xA6")]
	[Token(Token = "0x600023B")]
	public virtual Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	[Address(RVA = "0x20E3100", Offset = "0x20E2500", Length = "0x21B")]
	[Token(Token = "0x6000214")]
	public virtual Task<Nullable`1<DateTimeOffset>> ReadAsDateTimeOffsetAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20E3690", Offset = "0x20E2A90", Length = "0xA6")]
	[Token(Token = "0x600023C")]
	public virtual Nullable<Decimal> ReadAsDecimal() { }

	[Address(RVA = "0x20E3470", Offset = "0x20E2870", Length = "0x21B")]
	[Token(Token = "0x6000216")]
	public virtual Task<Nullable`1<Decimal>> ReadAsDecimalAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20E3900", Offset = "0x20E2D00", Length = "0x9C")]
	[Token(Token = "0x600023D")]
	public virtual Nullable<Double> ReadAsDouble() { }

	[Address(RVA = "0x20E3740", Offset = "0x20E2B40", Length = "0x1B2")]
	[Token(Token = "0x6000218")]
	public virtual Task<Nullable`1<Double>> ReadAsDoubleAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20E3B80", Offset = "0x20E2F80", Length = "0x88")]
	[Token(Token = "0x6000230")]
	public virtual Nullable<Int32> ReadAsInt32() { }

	[Address(RVA = "0x20E39A0", Offset = "0x20E2DA0", Length = "0x1D6")]
	[Token(Token = "0x600021A")]
	public virtual Task<Nullable`1<Int32>> ReadAsInt32Async(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20E3DF0", Offset = "0x20E31F0", Length = "0x38")]
	[NullableContext(2)]
	[Token(Token = "0x6000232")]
	public virtual string ReadAsString() { }

	[Address(RVA = "0x20E3C10", Offset = "0x20E3010", Length = "0x1D6")]
	[Token(Token = "0x600021C")]
	public virtual Task<String> ReadAsStringAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20E3E30", Offset = "0x20E3230", Length = "0xBC")]
	[Token(Token = "0x60001E7")]
	public virtual Task<Boolean> ReadAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20E4030", Offset = "0x20E3430", Length = "0x13A")]
	[Token(Token = "0x600022E")]
	private bool ReadChars(int relativePosition, bool append) { }

	[Address(RVA = "0x20E3EF0", Offset = "0x20E32F0", Length = "0x13E")]
	[AsyncStateMachine(typeof(<ReadCharsAsync>d__14))]
	[Token(Token = "0x60001F4")]
	private Task<Boolean> ReadCharsAsync(int relativePosition, bool append, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20E43F0", Offset = "0x20E37F0", Length = "0xB")]
	[Token(Token = "0x600022A")]
	private int ReadData(bool append) { }

	[Address(RVA = "0x20E4400", Offset = "0x20E3800", Length = "0xC6")]
	[Token(Token = "0x600022C")]
	private int ReadData(bool append, int charsRequired) { }

	[Address(RVA = "0x20E42B0", Offset = "0x20E36B0", Length = "0x137")]
	[Token(Token = "0x60001EC")]
	private Task<Int32> ReadDataAsync(bool append, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20E4170", Offset = "0x20E3570", Length = "0x13F")]
	[AsyncStateMachine(typeof(<ReadDataAsync>d__7))]
	[Token(Token = "0x60001ED")]
	private Task<Int32> ReadDataAsync(bool append, int charsRequired, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20E45D0", Offset = "0x20E39D0", Length = "0x140")]
	[Token(Token = "0x600023F")]
	private void ReadFinished() { }

	[Address(RVA = "0x20E44D0", Offset = "0x20E38D0", Length = "0xF8")]
	[AsyncStateMachine(typeof(<ReadFinishedAsync>d__36))]
	[Token(Token = "0x600020A")]
	private Task ReadFinishedAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20E4710", Offset = "0x20E3B10", Length = "0x11D")]
	[AsyncStateMachine(typeof(<ReadFromFinishedAsync>d__5))]
	[Token(Token = "0x60001EB")]
	private Task<Boolean> ReadFromFinishedAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20E4830", Offset = "0x20E3C30", Length = "0xF0")]
	[AsyncStateMachine(typeof(<ReadIntoWrappedTypeObjectAsync>d__43))]
	[Token(Token = "0x6000211")]
	private Task ReadIntoWrappedTypeObjectAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20E4A40", Offset = "0x20E3E40", Length = "0x4D")]
	[Token(Token = "0x6000240")]
	private bool ReadNullChar() { }

	[Address(RVA = "0x20E4920", Offset = "0x20E3D20", Length = "0x115")]
	[AsyncStateMachine(typeof(<ReadNullCharAsync>d__34))]
	[Token(Token = "0x6000208")]
	private Task<Boolean> ReadNullCharAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20E4A90", Offset = "0x20E3E90", Length = "0x5C")]
	[Token(Token = "0x6000248")]
	private bool ReadNumberCharIntoBuffer(char currentChar, int charPos) { }

	[Address(RVA = "0x20E4D20", Offset = "0x20E4120", Length = "0x1B4")]
	[Token(Token = "0x6000247")]
	private void ReadNumberIntoBuffer() { }

	[Address(RVA = "0x20E4C20", Offset = "0x20E4020", Length = "0xF9")]
	[AsyncStateMachine(typeof(<ReadNumberIntoBufferAsync>d__32))]
	[Token(Token = "0x6000206")]
	private Task ReadNumberIntoBufferAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20E5050", Offset = "0x20E4450", Length = "0x1E4")]
	[NullableContext(2)]
	[Token(Token = "0x6000239")]
	private object ReadNumberValue(ReadType readType) { }

	[Address(RVA = "0x20E4F10", Offset = "0x20E4310", Length = "0x140")]
	[AsyncStateMachine(typeof(<ReadNumberValueAsync>d__38))]
	[Token(Token = "0x600020C")]
	private Task<Object> ReadNumberValueAsync(ReadType readType, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20E5B70", Offset = "0x20E4F70", Length = "0x741")]
	[Token(Token = "0x6000242")]
	private void ReadStringIntoBuffer(char quote) { }

	[Address(RVA = "0x20E5A40", Offset = "0x20E4E40", Length = "0x126")]
	[AsyncStateMachine(typeof(<ReadStringIntoBufferAsync>d__9))]
	[Token(Token = "0x60001EF")]
	private Task ReadStringIntoBufferAsync(char quote, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20E6400", Offset = "0x20E5800", Length = "0x9E4")]
	[NullableContext(2)]
	[Token(Token = "0x6000234")]
	private object ReadStringValue(ReadType readType) { }

	[Address(RVA = "0x20E62C0", Offset = "0x20E56C0", Length = "0x13F")]
	[AsyncStateMachine(typeof(<ReadStringValueAsync>d__37))]
	[Token(Token = "0x600020B")]
	private Task<Object> ReadStringValueAsync(ReadType readType, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20E6E50", Offset = "0x20E6250", Length = "0x16B")]
	[Token(Token = "0x600024F")]
	private bool ReadUnquotedPropertyReportIfDone(char currentChar, int initialPosition) { }

	[Address(RVA = "0x20E7710", Offset = "0x20E6B10", Length = "0x72")]
	[NullableContext(2)]
	[Token(Token = "0x6000222")]
	public void set_ArrayPool(IArrayPool<Char> value) { }

	[Address(RVA = "0x20E7790", Offset = "0x20E6B90", Length = "0x13")]
	[CompilerGenerated]
	[NullableContext(2)]
	[Token(Token = "0x6000220")]
	public void set_PropertyNameTable(JsonNameTable value) { }

	[Address(RVA = "0x20E72D0", Offset = "0x20E66D0", Length = "0x50")]
	[Token(Token = "0x6000224")]
	private void SetNewLine(bool hasNextChar) { }

	[Address(RVA = "0x20E7330", Offset = "0x20E6730", Length = "0xDD")]
	[Token(Token = "0x6000229")]
	private void ShiftBufferIfNeeded() { }

	[Address(RVA = "0x20E7410", Offset = "0x20E6810", Length = "0x51")]
	[Token(Token = "0x6000257")]
	private JsonReaderException ThrowReaderError(string message, Exception ex = null) { }

	[Address(RVA = "0x20E7470", Offset = "0x20E6870", Length = "0x47")]
	[Token(Token = "0x600024D")]
	private bool ValidIdentifierChar(char value) { }

	[Address(RVA = "0x20E74C0", Offset = "0x20E68C0", Length = "0x67")]
	[Token(Token = "0x6000244")]
	private void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition) { }

}

