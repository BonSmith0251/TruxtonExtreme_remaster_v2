namespace UnityEngine.InputForUI;

[Token(Token = "0x2000010")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal struct KeyEvent : IEventProperties
{
	[Token(Token = "0x2000012")]
	internal struct ButtonsState
	{
		[CompilerGenerated]
		[Token(Token = "0x2000014")]
		[UnsafeValueType]
		internal struct <buttons>e__FixedBuffer
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000065")]
			public byte FixedElementField; //Field offset: 0x0

		}

		[CompilerGenerated]
		[Token(Token = "0x2000013")]
		private sealed class <GetAllPressed>d__8 : IEnumerable<KeyCode>, IEnumerable, IEnumerator<KeyCode>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400005F")]
			private int <>1__state; //Field offset: 0x10
			[FieldOffset(Offset = "0x14")]
			[Token(Token = "0x4000060")]
			private KeyCode <>2__current; //Field offset: 0x14
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000061")]
			private int <>l__initialThreadId; //Field offset: 0x18
			[FieldOffset(Offset = "0x1C")]
			[Token(Token = "0x4000062")]
			public ButtonsState <>4__this; //Field offset: 0x1C
			[FieldOffset(Offset = "0x44")]
			[Token(Token = "0x4000063")]
			public ButtonsState <>3__<>4__this; //Field offset: 0x44
			[FieldOffset(Offset = "0x6C")]
			[Token(Token = "0x4000064")]
			private uint <index>5__1; //Field offset: 0x6C

			[Token(Token = "0x17000020")]
			private override KeyCode System.Collections.Generic.IEnumerator<UnityEngine.KeyCode>.Current
			{
				[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
				[DebuggerHidden]
				[Token(Token = "0x600004A")]
				private get { } //Length: 4
			}

			[Token(Token = "0x17000021")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x3110350", Offset = "0x310F750", Length = "0x43")]
				[DebuggerHidden]
				[Token(Token = "0x600004C")]
				private get { } //Length: 67
			}

			[Address(RVA = "0x113FA40", Offset = "0x113EE40", Length = "0x2E")]
			[DebuggerHidden]
			[Token(Token = "0x6000047")]
			public <GetAllPressed>d__8(int <>1__state) { }

			[Address(RVA = "0x3110200", Offset = "0x310F600", Length = "0x5D")]
			[Token(Token = "0x6000049")]
			private override bool MoveNext() { }

			[Address(RVA = "0x3110260", Offset = "0x310F660", Length = "0xA5")]
			[DebuggerHidden]
			[Token(Token = "0x600004D")]
			private override IEnumerator<KeyCode> System.Collections.Generic.IEnumerable<UnityEngine.KeyCode>.GetEnumerator() { }

			[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
			[DebuggerHidden]
			[Token(Token = "0x600004A")]
			private override KeyCode System.Collections.Generic.IEnumerator<UnityEngine.KeyCode>.get_Current() { }

			[Address(RVA = "0x3110260", Offset = "0x310F660", Length = "0xA5")]
			[DebuggerHidden]
			[Token(Token = "0x600004E")]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[Address(RVA = "0x3110350", Offset = "0x310F750", Length = "0x43")]
			[DebuggerHidden]
			[Token(Token = "0x600004C")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0x3110310", Offset = "0x310F710", Length = "0x3E")]
			[DebuggerHidden]
			[Token(Token = "0x600004B")]
			private override void System.Collections.IEnumerator.Reset() { }

			[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
			[DebuggerHidden]
			[Token(Token = "0x6000048")]
			private override void System.IDisposable.Dispose() { }

		}

		[FieldOffset(Offset = "0x0")]
		[FixedBuffer(typeof(byte), 40)]
		[Token(Token = "0x400005E")]
		private <buttons>e__FixedBuffer buttons; //Field offset: 0x0

		[Address(RVA = "0x3106AF0", Offset = "0x3105EF0", Length = "0x17")]
		[Token(Token = "0x6000041")]
		private void ClearUnchecked(uint index) { }

		[Address(RVA = "0x3106B10", Offset = "0x3105F10", Length = "0x7A")]
		[IteratorStateMachine(typeof(<GetAllPressed>d__8))]
		[Token(Token = "0x6000043")]
		public IEnumerable<KeyCode> GetAllPressed() { }

		[Address(RVA = "0x3106B90", Offset = "0x3105F90", Length = "0x1F")]
		[Token(Token = "0x600003F")]
		private bool GetUnchecked(uint index) { }

		[Address(RVA = "0x3106BC0", Offset = "0x3105FC0", Length = "0x28")]
		[Token(Token = "0x6000042")]
		public bool IsPressed(KeyCode keyCode) { }

		[Address(RVA = "0x3106BF0", Offset = "0x3105FF0", Length = "0x11")]
		[Token(Token = "0x6000045")]
		public void Reset() { }

		[Address(RVA = "0x3106C10", Offset = "0x3106010", Length = "0x2A")]
		[Token(Token = "0x6000044")]
		public void SetPressed(KeyCode keyCode, bool pressed) { }

		[Address(RVA = "0x3106C40", Offset = "0x3106040", Length = "0x17")]
		[Token(Token = "0x6000040")]
		private void SetUnchecked(uint index) { }

		[Address(RVA = "0x3106C60", Offset = "0x3106060", Length = "0xC")]
		[Token(Token = "0x600003E")]
		internal static bool ShouldBeProcessed(KeyCode keyCode) { }

		[Address(RVA = "0x3106C70", Offset = "0x3106070", Length = "0x56")]
		[Token(Token = "0x6000046")]
		public virtual string ToString() { }

	}

	[Token(Token = "0x2000011")]
	internal enum Type : int
	{
		KeyPressed = 1,
		KeyRepeated = 2,
		KeyReleased = 3,
		State = 4,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000052")]
	public Type type; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000053")]
	public KeyCode keyCode; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000054")]
	public ButtonsState buttonsState; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000055")]
	private DiscreteTime <timestamp>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000056")]
	private EventSource <eventSource>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000057")]
	private uint <playerId>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000058")]
	private EventModifiers <eventModifiers>k__BackingField; //Field offset: 0x40

	[Token(Token = "0x1700001F")]
	public override EventModifiers eventModifiers
	{
		[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600003B")]
		 get { } //Length: 4
		[Address(RVA = "0x1116990", Offset = "0x1115D90", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600003C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700001D")]
	public override EventSource eventSource
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000038")]
		 get { } //Length: 4
		[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000039")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700001E")]
	public uint playerId
	{
		[Address(RVA = "0x24704E0", Offset = "0x246F8E0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600003A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700001C")]
	public DiscreteTime timestamp
	{
		[Address(RVA = "0x2162050", Offset = "0x2161450", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000037")]
		 set { } //Length: 5
	}

	[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600003B")]
	public override EventModifiers get_eventModifiers() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000038")]
	public override EventSource get_eventSource() { }

	[Address(RVA = "0x1116990", Offset = "0x1115D90", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600003C")]
	public void set_eventModifiers(EventModifiers value) { }

	[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000039")]
	public void set_eventSource(EventSource value) { }

	[Address(RVA = "0x24704E0", Offset = "0x246F8E0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600003A")]
	public void set_playerId(uint value) { }

	[Address(RVA = "0x2162050", Offset = "0x2161450", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000037")]
	public void set_timestamp(DiscreteTime value) { }

	[Address(RVA = "0x310E610", Offset = "0x310DA10", Length = "0x140")]
	[Token(Token = "0x600003D")]
	public virtual string ToString() { }

}

