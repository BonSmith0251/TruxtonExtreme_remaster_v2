namespace UnityEngine.InputSystem.Utilities;

[Token(Token = "0x2000235")]
public sealed class InputActionTrace : IEnumerable<ActionEventPtr>, IEnumerable, IDisposable
{
	[Token(Token = "0x2000236")]
	internal struct ActionEventPtr
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C6A")]
		internal InputActionState m_State; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C6B")]
		internal ActionEvent* m_Ptr; //Field offset: 0x8

		[Token(Token = "0x170005E8")]
		public InputAction action
		{
			[Address(RVA = "0x290CB80", Offset = "0x290BF80", Length = "0x28")]
			[Token(Token = "0x60014BA")]
			 get { } //Length: 40
		}

		[Token(Token = "0x170005EA")]
		public InputControl control
		{
			[Address(RVA = "0x290CBB0", Offset = "0x290BFB0", Length = "0x37")]
			[Token(Token = "0x60014BC")]
			 get { } //Length: 55
		}

		[Token(Token = "0x170005EE")]
		public double duration
		{
			[Address(RVA = "0x290CBF0", Offset = "0x290BFF0", Length = "0x2D")]
			[Token(Token = "0x60014C0")]
			 get { } //Length: 45
		}

		[Token(Token = "0x170005EB")]
		public IInputInteraction interaction
		{
			[Address(RVA = "0x290CC20", Offset = "0x290C020", Length = "0x4F")]
			[Token(Token = "0x60014BD")]
			 get { } //Length: 79
		}

		[Token(Token = "0x170005E9")]
		public InputActionPhase phase
		{
			[Address(RVA = "0x290CC70", Offset = "0x290C070", Length = "0x9")]
			[Token(Token = "0x60014BB")]
			 get { } //Length: 9
		}

		[Token(Token = "0x170005ED")]
		public double startTime
		{
			[Address(RVA = "0x290CC80", Offset = "0x290C080", Length = "0xA")]
			[Token(Token = "0x60014BF")]
			 get { } //Length: 10
		}

		[Token(Token = "0x170005EC")]
		public double time
		{
			[Address(RVA = "0x290CC90", Offset = "0x290C090", Length = "0x1D")]
			[Token(Token = "0x60014BE")]
			 get { } //Length: 29
		}

		[Token(Token = "0x170005EF")]
		public int valueSizeInBytes
		{
			[Address(RVA = "0x290CCB0", Offset = "0x290C0B0", Length = "0xB")]
			[Token(Token = "0x60014C1")]
			 get { } //Length: 11
		}

		[Address(RVA = "0x290CB80", Offset = "0x290BF80", Length = "0x28")]
		[Token(Token = "0x60014BA")]
		public InputAction get_action() { }

		[Address(RVA = "0x290CBB0", Offset = "0x290BFB0", Length = "0x37")]
		[Token(Token = "0x60014BC")]
		public InputControl get_control() { }

		[Address(RVA = "0x290CBF0", Offset = "0x290BFF0", Length = "0x2D")]
		[Token(Token = "0x60014C0")]
		public double get_duration() { }

		[Address(RVA = "0x290CC20", Offset = "0x290C020", Length = "0x4F")]
		[Token(Token = "0x60014BD")]
		public IInputInteraction get_interaction() { }

		[Address(RVA = "0x290CC70", Offset = "0x290C070", Length = "0x9")]
		[Token(Token = "0x60014BB")]
		public InputActionPhase get_phase() { }

		[Address(RVA = "0x290CC80", Offset = "0x290C080", Length = "0xA")]
		[Token(Token = "0x60014BF")]
		public double get_startTime() { }

		[Address(RVA = "0x290CC90", Offset = "0x290C090", Length = "0x1D")]
		[Token(Token = "0x60014BE")]
		public double get_time() { }

		[Address(RVA = "0x290CCB0", Offset = "0x290C0B0", Length = "0xB")]
		[Token(Token = "0x60014C1")]
		public int get_valueSizeInBytes() { }

		[Address(RVA = "0x290C610", Offset = "0x290BA10", Length = "0xEA")]
		[Token(Token = "0x60014C3")]
		public void ReadValue(Void* buffer, int bufferSize) { }

		[Address(RVA = "0x9EF210", Offset = "0x9EE610", Length = "0x2FA")]
		[Token(Token = "0x60014C4")]
		public TValue ReadValue() { }

		[Address(RVA = "0x290C380", Offset = "0x290B780", Length = "0x283")]
		[Token(Token = "0x60014C2")]
		public object ReadValueAsObject() { }

		[Address(RVA = "0x290C700", Offset = "0x290BB00", Length = "0x478")]
		[Token(Token = "0x60014C5")]
		public virtual string ToString() { }

	}

	[Token(Token = "0x2000237")]
	private struct Enumerator : IEnumerator<ActionEventPtr>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C6C")]
		private readonly InputActionTrace m_Trace; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C6D")]
		private readonly ActionEvent* m_Buffer; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000C6E")]
		private readonly int m_EventCount; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000C6F")]
		private ActionEvent* m_CurrentEvent; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C70")]
		private int m_CurrentIndex; //Field offset: 0x20

		[Token(Token = "0x170005F0")]
		public override ActionEventPtr Current
		{
			[Address(RVA = "0x290F540", Offset = "0x290E940", Length = "0x83")]
			[Token(Token = "0x60014CA")]
			 get { } //Length: 131
		}

		[Token(Token = "0x170005F1")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x290F430", Offset = "0x290E830", Length = "0xB4")]
			[Token(Token = "0x60014CB")]
			private get { } //Length: 180
		}

		[Address(RVA = "0x290F4F0", Offset = "0x290E8F0", Length = "0x4B")]
		[Token(Token = "0x60014C6")]
		public Enumerator(InputActionTrace trace) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60014C9")]
		public override void Dispose() { }

		[Address(RVA = "0x290F540", Offset = "0x290E940", Length = "0x83")]
		[Token(Token = "0x60014CA")]
		public override ActionEventPtr get_Current() { }

		[Address(RVA = "0x290F3C0", Offset = "0x290E7C0", Length = "0x58")]
		[Token(Token = "0x60014C7")]
		public override bool MoveNext() { }

		[Address(RVA = "0x290F420", Offset = "0x290E820", Length = "0xA")]
		[Token(Token = "0x60014C8")]
		public override void Reset() { }

		[Address(RVA = "0x290F430", Offset = "0x290E830", Length = "0xB4")]
		[Token(Token = "0x60014CB")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C61")]
	private bool m_SubscribedToAll; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x4000C62")]
	private bool m_OnActionChangeHooked; //Field offset: 0x11
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C63")]
	private InlinedArray<InputAction> m_SubscribedActions; //Field offset: 0x18
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000C64")]
	private InlinedArray<InputActionMap> m_SubscribedActionMaps; //Field offset: 0x30
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000C65")]
	private InputEventBuffer m_EventBuffer; //Field offset: 0x48
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000C66")]
	private InlinedArray<InputActionState> m_ActionMapStates; //Field offset: 0x68
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000C67")]
	private InlinedArray<InputActionState> m_ActionMapStateClones; //Field offset: 0x80
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000C68")]
	private Action<CallbackContext> m_CallbackDelegate; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000C69")]
	private Action<Object, InputActionChange> m_ActionChangeDelegate; //Field offset: 0xA0

	[Token(Token = "0x170005E6")]
	public InputEventBuffer buffer
	{
		[Address(RVA = "0x2911570", Offset = "0x2910970", Length = "0x13")]
		[Token(Token = "0x60014A3")]
		 get { } //Length: 19
	}

	[Token(Token = "0x170005E7")]
	public int count
	{
		[Address(RVA = "0x2069B10", Offset = "0x2068F10", Length = "0x4")]
		[Token(Token = "0x60014A4")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60014A5")]
	public InputActionTrace() { }

	[Address(RVA = "0x2911300", Offset = "0x2910700", Length = "0x143")]
	[Token(Token = "0x60014A6")]
	public InputActionTrace(InputAction action) { }

	[Address(RVA = "0x2911450", Offset = "0x2910850", Length = "0x11F")]
	[Token(Token = "0x60014A7")]
	public InputActionTrace(InputActionMap actionMap) { }

	[Address(RVA = "0x290FD40", Offset = "0x290F140", Length = "0x45")]
	[Token(Token = "0x60014AF")]
	public void Clear() { }

	[Address(RVA = "0x290FD90", Offset = "0x290F190", Length = "0xD7")]
	[Token(Token = "0x60014B9")]
	private void CloneActionStateBeforeBindingsChange(InputActionMap actionMap) { }

	[Address(RVA = "0x290FF80", Offset = "0x290F380", Length = "0x1F")]
	[Token(Token = "0x60014B2")]
	public override void Dispose() { }

	[Address(RVA = "0x290FE70", Offset = "0x290F270", Length = "0x10E")]
	[Token(Token = "0x60014B3")]
	private void DisposeInternal() { }

	[Address(RVA = "0x290FFA0", Offset = "0x290F3A0", Length = "0x57")]
	[Token(Token = "0x60014B0")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x2911570", Offset = "0x2910970", Length = "0x13")]
	[Token(Token = "0x60014A3")]
	public InputEventBuffer get_buffer() { }

	[Address(RVA = "0x2069B10", Offset = "0x2068F10", Length = "0x4")]
	[Token(Token = "0x60014A4")]
	public int get_count() { }

	[Address(RVA = "0x2910000", Offset = "0x290F400", Length = "0xAC")]
	[Token(Token = "0x60014B4")]
	public override IEnumerator<ActionEventPtr> GetEnumerator() { }

	[Address(RVA = "0x29100B0", Offset = "0x290F4B0", Length = "0xC1")]
	[Token(Token = "0x60014B6")]
	private void HookOnActionChange() { }

	[Address(RVA = "0x2910180", Offset = "0x290F580", Length = "0x28F")]
	[Token(Token = "0x60014B8")]
	private void OnActionChange(object actionOrMapOrAsset, InputActionChange change) { }

	[Address(RVA = "0x2910410", Offset = "0x290F810", Length = "0x1BB")]
	[Token(Token = "0x60014AE")]
	public void RecordAction(CallbackContext context) { }

	[Address(RVA = "0x2910980", Offset = "0x290FD80", Length = "0x13C")]
	[Token(Token = "0x60014AA")]
	public void SubscribeTo(InputAction action) { }

	[Address(RVA = "0x2910860", Offset = "0x290FC60", Length = "0x114")]
	[Token(Token = "0x60014AB")]
	public void SubscribeTo(InputActionMap actionMap) { }

	[Address(RVA = "0x29105D0", Offset = "0x290F9D0", Length = "0x28B")]
	[Token(Token = "0x60014A8")]
	public void SubscribeToAll() { }

	[Address(RVA = "0x2910AC0", Offset = "0x290FEC0", Length = "0x7")]
	[Token(Token = "0x60014B5")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x2910AD0", Offset = "0x290FED0", Length = "0x2DE")]
	[Token(Token = "0x60014B1")]
	public virtual string ToString() { }

	[Address(RVA = "0x2910DB0", Offset = "0x29101B0", Length = "0x65")]
	[Token(Token = "0x60014B7")]
	private void UnhookOnActionChange() { }

	[Address(RVA = "0x29110F0", Offset = "0x29104F0", Length = "0x113")]
	[Token(Token = "0x60014AC")]
	public void UnsubscribeFrom(InputAction action) { }

	[Address(RVA = "0x2911210", Offset = "0x2910610", Length = "0xEB")]
	[Token(Token = "0x60014AD")]
	public void UnsubscribeFrom(InputActionMap actionMap) { }

	[Address(RVA = "0x2910E20", Offset = "0x2910220", Length = "0x2CB")]
	[Token(Token = "0x60014A9")]
	public void UnsubscribeFromAll() { }

}

