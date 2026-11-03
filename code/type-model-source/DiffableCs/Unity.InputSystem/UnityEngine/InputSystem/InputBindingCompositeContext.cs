namespace UnityEngine.InputSystem;

[Token(Token = "0x2000059")]
public struct InputBindingCompositeContext
{
	[CompilerGenerated]
	[Token(Token = "0x200005C")]
	private sealed class <get_controls>d__2 : IEnumerable<PartBinding>, IEnumerable, IEnumerator<PartBinding>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400021B")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400021C")]
		private PartBinding <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400021D")]
		private int <>l__initialThreadId; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400021E")]
		public InputBindingCompositeContext <>4__this; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400021F")]
		public InputBindingCompositeContext <>3__<>4__this; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000220")]
		private int <totalBindingCount>5__2; //Field offset: 0x50
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x4000221")]
		private int <bindingIndex>5__3; //Field offset: 0x54
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000222")]
		private BindingState <bindingState>5__4; //Field offset: 0x58
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4000223")]
		private int <controlStartIndex>5__5; //Field offset: 0x78
		[FieldOffset(Offset = "0x7C")]
		[Token(Token = "0x4000224")]
		private int <i>5__6; //Field offset: 0x7C

		[Token(Token = "0x1700013F")]
		private override PartBinding System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding>.Current
		{
			[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
			[DebuggerHidden]
			[Token(Token = "0x6000436")]
			private get { } //Length: 11
		}

		[Token(Token = "0x17000140")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x29445D0", Offset = "0x29439D0", Length = "0x45")]
			[DebuggerHidden]
			[Token(Token = "0x6000438")]
			private get { } //Length: 69
		}

		[Address(RVA = "0x113FA10", Offset = "0x113EE10", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x6000433")]
		public <get_controls>d__2(int <>1__state) { }

		[Address(RVA = "0x29443B0", Offset = "0x29437B0", Length = "0x137")]
		[Token(Token = "0x6000435")]
		private override bool MoveNext() { }

		[Address(RVA = "0x29444F0", Offset = "0x29438F0", Length = "0x9E")]
		[DebuggerHidden]
		[Token(Token = "0x6000439")]
		private override IEnumerator<PartBinding> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding>.GetEnumerator() { }

		[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
		[DebuggerHidden]
		[Token(Token = "0x6000436")]
		private override PartBinding System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding>.get_Current() { }

		[Address(RVA = "0x29444F0", Offset = "0x29438F0", Length = "0x9E")]
		[DebuggerHidden]
		[Token(Token = "0x600043A")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x29445D0", Offset = "0x29439D0", Length = "0x45")]
		[DebuggerHidden]
		[Token(Token = "0x6000438")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2944590", Offset = "0x2943990", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000437")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000434")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x200005B")]
	private struct DefaultComparer : IComparer<TValue>
	{

		[Address(RVA = "0x17D2E20", Offset = "0x17D2220", Length = "0x49")]
		[Token(Token = "0x6000432")]
		public override int Compare(TValue x, TValue y) { }

	}

	[Token(Token = "0x200005A")]
	internal struct PartBinding
	{
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000219")]
		private int <part>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400021A")]
		private InputControl <control>k__BackingField; //Field offset: 0x8

		[Token(Token = "0x1700013E")]
		public InputControl control
		{
			[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x6000430")]
			 get { } //Length: 5
			[Address(RVA = "0x17CB540", Offset = "0x17CA940", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x6000431")]
			 set { } //Length: 13
		}

		[Token(Token = "0x1700013D")]
		public int part
		{
			[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x600042E")]
			 get { } //Length: 3
			[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
			[CompilerGenerated]
			[Token(Token = "0x600042F")]
			 set { } //Length: 3
		}

		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000430")]
		public InputControl get_control() { }

		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600042E")]
		public int get_part() { }

		[Address(RVA = "0x17CB540", Offset = "0x17CA940", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000431")]
		public void set_control(InputControl value) { }

		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[CompilerGenerated]
		[Token(Token = "0x600042F")]
		public void set_part(int value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000217")]
	internal InputActionState m_State; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000218")]
	internal int m_BindingIndex; //Field offset: 0x8

	[Token(Token = "0x1700013C")]
	public IEnumerable<PartBinding> controls
	{
		[Address(RVA = "0x292E2E0", Offset = "0x292D6E0", Length = "0x73")]
		[IteratorStateMachine(typeof(<get_controls>d__2))]
		[Token(Token = "0x6000424")]
		 get { } //Length: 115
	}

	[Address(RVA = "0x292E180", Offset = "0x292D580", Length = "0x26")]
	[Token(Token = "0x6000425")]
	public float EvaluateMagnitude(int partNumber) { }

	[Address(RVA = "0x292E2E0", Offset = "0x292D6E0", Length = "0x73")]
	[IteratorStateMachine(typeof(<get_controls>d__2))]
	[Token(Token = "0x6000424")]
	public IEnumerable<PartBinding> get_controls() { }

	[Address(RVA = "0x292E1B0", Offset = "0x292D5B0", Length = "0x26")]
	[Token(Token = "0x600042D")]
	public double GetPressTime(int partNumber) { }

	[Address(RVA = "0x8393F0", Offset = "0x8387F0", Length = "0x84")]
	[Token(Token = "0x6000426")]
	public TValue ReadValue(int partNumber) { }

	[Address(RVA = "0x839190", Offset = "0x838590", Length = "0x25F")]
	[Token(Token = "0x6000427")]
	public TValue ReadValue(int partNumber, out InputControl sourceControl) { }

	[Address(RVA = "0x838E80", Offset = "0x838280", Length = "0x1BF")]
	[Token(Token = "0x6000428")]
	public TValue ReadValue(int partNumber, TComparer comparer = null) { }

	[Address(RVA = "0x838BB0", Offset = "0x837FB0", Length = "0x2C4")]
	[Token(Token = "0x6000429")]
	public TValue ReadValue(int partNumber, out InputControl sourceControl, TComparer comparer = null) { }

	[Address(RVA = "0x292E2B0", Offset = "0x292D6B0", Length = "0x30")]
	[Token(Token = "0x600042B")]
	public void ReadValue(int partNumber, Void* buffer, int bufferSize) { }

	[Address(RVA = "0x292E1E0", Offset = "0x292D5E0", Length = "0x93")]
	[Token(Token = "0x600042A")]
	public bool ReadValueAsButton(int partNumber) { }

	[Address(RVA = "0x292E280", Offset = "0x292D680", Length = "0x26")]
	[Token(Token = "0x600042C")]
	public object ReadValueAsObject(int partNumber) { }

}

