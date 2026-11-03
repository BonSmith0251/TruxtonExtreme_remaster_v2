namespace UnityEngine.InputSystem;

[DefaultMember("Item")]
[Token(Token = "0x200001F")]
public class InputActionAsset : ScriptableObject, IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable
{
	[CompilerGenerated]
	[Token(Token = "0x2000025")]
	private sealed class <get_bindings>d__9 : IEnumerable<InputBinding>, IEnumerable, IEnumerator<InputBinding>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000BB")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000BC")]
		private InputBinding <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x40000BD")]
		private int <>l__initialThreadId; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x40000BE")]
		public InputActionAsset <>4__this; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x40000BF")]
		private int <numActionMaps>5__2; //Field offset: 0x80
		[FieldOffset(Offset = "0x84")]
		[Token(Token = "0x40000C0")]
		private int <i>5__3; //Field offset: 0x84
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x40000C1")]
		private InputBinding[] <bindings>5__4; //Field offset: 0x88
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x40000C2")]
		private int <numBindings>5__5; //Field offset: 0x90
		[FieldOffset(Offset = "0x94")]
		[Token(Token = "0x40000C3")]
		private int <n>5__6; //Field offset: 0x94

		[Token(Token = "0x170000B0")]
		private override InputBinding System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBinding>.Current
		{
			[Address(RVA = "0x28F2240", Offset = "0x28F1640", Length = "0x35")]
			[DebuggerHidden]
			[Token(Token = "0x60001B2")]
			private get { } //Length: 53
		}

		[Token(Token = "0x170000B1")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x28F22C0", Offset = "0x28F16C0", Length = "0x7A")]
			[DebuggerHidden]
			[Token(Token = "0x60001B4")]
			private get { } //Length: 122
		}

		[Address(RVA = "0x28F2340", Offset = "0x28F1740", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x60001AF")]
		public <get_bindings>d__9(int <>1__state) { }

		[Address(RVA = "0x28F1FC0", Offset = "0x28F13C0", Length = "0x1DA")]
		[Token(Token = "0x60001B1")]
		private override bool MoveNext() { }

		[Address(RVA = "0x28F21A0", Offset = "0x28F15A0", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x60001B5")]
		private override IEnumerator<InputBinding> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding>.GetEnumerator() { }

		[Address(RVA = "0x28F2240", Offset = "0x28F1640", Length = "0x35")]
		[DebuggerHidden]
		[Token(Token = "0x60001B2")]
		private override InputBinding System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBinding>.get_Current() { }

		[Address(RVA = "0x28F21A0", Offset = "0x28F15A0", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x60001B6")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x28F22C0", Offset = "0x28F16C0", Length = "0x7A")]
		[DebuggerHidden]
		[Token(Token = "0x60001B4")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x28F2280", Offset = "0x28F1680", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60001B3")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60001B0")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000024")]
	private sealed class <GetEnumerator>d__33 : IEnumerator<InputAction>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000B4")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000B5")]
		private InputAction <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000B6")]
		public InputActionAsset <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000B7")]
		private int <i>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000B8")]
		private ReadOnlyArray<InputAction> <actions>5__3; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40000B9")]
		private int <actionCount>5__4; //Field offset: 0x40
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x40000BA")]
		private int <n>5__5; //Field offset: 0x44

		[Token(Token = "0x170000AE")]
		private override InputAction System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60001AC")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000AF")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60001AE")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60001A9")]
		public <GetEnumerator>d__33(int <>1__state) { }

		[Address(RVA = "0x28F1E00", Offset = "0x28F1200", Length = "0x17F")]
		[Token(Token = "0x60001AB")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60001AC")]
		private override InputAction System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60001AE")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x28F1F80", Offset = "0x28F1380", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60001AD")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60001AA")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000020")]
	private static class JsonVersion
	{
		[Token(Token = "0x40000A7")]
		public const int Version0 = 0; //Field offset: 0x0
		[Token(Token = "0x40000A8")]
		public const int Version1 = 1; //Field offset: 0x0
		[Token(Token = "0x40000A9")]
		public const int Current = 1; //Field offset: 0x0

	}

	[Token(Token = "0x2000023")]
	public struct ReadFileJson
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000B0")]
		public int version; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000B1")]
		public string name; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000B2")]
		public ReadMapJson[] maps; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000B3")]
		public SchemeJson[] controlSchemes; //Field offset: 0x18

		[Address(RVA = "0x28ED500", Offset = "0x28EC900", Length = "0xEA")]
		[Token(Token = "0x60001A8")]
		public void ToAsset(InputActionAsset asset) { }

	}

	[Token(Token = "0x2000021")]
	public struct WriteFileJson
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000AA")]
		public int version; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000AB")]
		public string name; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000AC")]
		public WriteMapJson[] maps; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000AD")]
		public SchemeJson[] controlSchemes; //Field offset: 0x18

	}

	[Token(Token = "0x2000022")]
	public struct WriteFileJsonNoName
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000AE")]
		public WriteMapJson[] maps; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000AF")]
		public SchemeJson[] controlSchemes; //Field offset: 0x8

	}

	[Token(Token = "0x400009D")]
	public const string Extension = "inputactions"; //Field offset: 0x0
	[Token(Token = "0x400009E")]
	internal const string kDefaultAssetLayoutJson = "{}"; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x400009F")]
	internal InputActionMap[] m_ActionMaps; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40000A0")]
	internal InputControlScheme[] m_ControlSchemes; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40000A1")]
	internal bool m_IsProjectWide; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000A2")]
	internal InputActionState m_SharedStateForAllMaps; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000A3")]
	internal Nullable<InputBinding> m_BindingMask; //Field offset: 0x38
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40000A4")]
	internal int m_ParameterOverridesCount; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40000A5")]
	internal ParameterOverride[] m_ParameterOverrides; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40000A6")]
	internal DeviceArray m_Devices; //Field offset: 0xA8

	[Token(Token = "0x170000A8")]
	public ReadOnlyArray<InputActionMap> actionMaps
	{
		[Address(RVA = "0x28DC670", Offset = "0x28DBA70", Length = "0x53")]
		[Token(Token = "0x6000187")]
		 get { } //Length: 83
	}

	[Token(Token = "0x170000AB")]
	public override Nullable<InputBinding> bindingMask
	{
		[Address(RVA = "0x28DC6D0", Offset = "0x28DBAD0", Length = "0x36")]
		[Token(Token = "0x600018A")]
		 get { } //Length: 54
		[Address(RVA = "0x28DC9A0", Offset = "0x28DBDA0", Length = "0x1CD")]
		[Token(Token = "0x600018B")]
		 set { } //Length: 461
	}

	[Token(Token = "0x170000AA")]
	public override IEnumerable<InputBinding> bindings
	{
		[Address(RVA = "0x28DC710", Offset = "0x28DBB10", Length = "0x71")]
		[IteratorStateMachine(typeof(<get_bindings>d__9))]
		[Token(Token = "0x6000189")]
		 get { } //Length: 113
	}

	[Token(Token = "0x170000A9")]
	public override ReadOnlyArray<InputControlScheme> controlSchemes
	{
		[Address(RVA = "0x28DC790", Offset = "0x28DBB90", Length = "0x53")]
		[Token(Token = "0x6000188")]
		 get { } //Length: 83
	}

	[Token(Token = "0x170000AC")]
	public override Nullable<ReadOnlyArray`1<InputDevice>> devices
	{
		[Address(RVA = "0x28DC7F0", Offset = "0x28DBBF0", Length = "0x36")]
		[Token(Token = "0x600018C")]
		 get { } //Length: 54
		[Address(RVA = "0x28DCB70", Offset = "0x28DBF70", Length = "0x73")]
		[Token(Token = "0x600018D")]
		 set { } //Length: 115
	}

	[Token(Token = "0x170000A7")]
	public bool enabled
	{
		[Address(RVA = "0x28DC830", Offset = "0x28DBC30", Length = "0x16F")]
		[Token(Token = "0x6000186")]
		 get { } //Length: 367
	}

	[Token(Token = "0x170000AD")]
	public InputAction Item
	{
		[Address(RVA = "0x28DC5E0", Offset = "0x28DB9E0", Length = "0x87")]
		[Token(Token = "0x600018E")]
		 get { } //Length: 135
	}

	[Address(RVA = "0x5B3AF0", Offset = "0x5B2EF0", Length = "0x7")]
	[Token(Token = "0x60001A7")]
	public InputActionAsset() { }

	[Address(RVA = "0x28DA2C0", Offset = "0x28D96C0", Length = "0x8D")]
	[Token(Token = "0x600019C")]
	public override bool Contains(InputAction action) { }

	[Address(RVA = "0x28DA350", Offset = "0x28D9750", Length = "0x16F")]
	[Token(Token = "0x600019B")]
	public override void Disable() { }

	[Address(RVA = "0x28DA4C0", Offset = "0x28D98C0", Length = "0x1C3")]
	[Token(Token = "0x600019A")]
	public override void Enable() { }

	[Address(RVA = "0x28DABE0", Offset = "0x28D9FE0", Length = "0x414")]
	[Token(Token = "0x6000192")]
	public override InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false) { }

	[Address(RVA = "0x28DAA40", Offset = "0x28D9E40", Length = "0x19A")]
	[Token(Token = "0x6000196")]
	public InputAction FindAction(Guid guid) { }

	[Address(RVA = "0x28DA690", Offset = "0x28D9A90", Length = "0x29A")]
	[Token(Token = "0x6000194")]
	public InputActionMap FindActionMap(string nameOrId, bool throwIfNotFound = false) { }

	[Address(RVA = "0x28DA930", Offset = "0x28D9D30", Length = "0x10B")]
	[Token(Token = "0x6000195")]
	public InputActionMap FindActionMap(Guid id) { }

	[Address(RVA = "0x28DB000", Offset = "0x28DA400", Length = "0x139")]
	[Token(Token = "0x6000193")]
	public override int FindBinding(InputBinding mask, out InputAction action) { }

	[Address(RVA = "0x28DB250", Offset = "0x28DA650", Length = "0x219")]
	[Token(Token = "0x6000198")]
	public Nullable<InputControlScheme> FindControlScheme(string name) { }

	[Address(RVA = "0x28DB140", Offset = "0x28DA540", Length = "0x10F")]
	[Token(Token = "0x6000197")]
	public int FindControlSchemeIndex(string name) { }

	[Address(RVA = "0x28DB470", Offset = "0x28DA870", Length = "0x16F")]
	[Token(Token = "0x6000191")]
	public static InputActionAsset FromJson(string json) { }

	[Address(RVA = "0x28DC670", Offset = "0x28DBA70", Length = "0x53")]
	[Token(Token = "0x6000187")]
	public ReadOnlyArray<InputActionMap> get_actionMaps() { }

	[Address(RVA = "0x28DC6D0", Offset = "0x28DBAD0", Length = "0x36")]
	[Token(Token = "0x600018A")]
	public override Nullable<InputBinding> get_bindingMask() { }

	[Address(RVA = "0x28DC710", Offset = "0x28DBB10", Length = "0x71")]
	[IteratorStateMachine(typeof(<get_bindings>d__9))]
	[Token(Token = "0x6000189")]
	public override IEnumerable<InputBinding> get_bindings() { }

	[Address(RVA = "0x28DC790", Offset = "0x28DBB90", Length = "0x53")]
	[Token(Token = "0x6000188")]
	public override ReadOnlyArray<InputControlScheme> get_controlSchemes() { }

	[Address(RVA = "0x28DC7F0", Offset = "0x28DBBF0", Length = "0x36")]
	[Token(Token = "0x600018C")]
	public override Nullable<ReadOnlyArray`1<InputDevice>> get_devices() { }

	[Address(RVA = "0x28DC830", Offset = "0x28DBC30", Length = "0x16F")]
	[Token(Token = "0x6000186")]
	public bool get_enabled() { }

	[Address(RVA = "0x28DC5E0", Offset = "0x28DB9E0", Length = "0x87")]
	[Token(Token = "0x600018E")]
	public InputAction get_Item(string actionNameOrId) { }

	[Address(RVA = "0x28DB5E0", Offset = "0x28DA9E0", Length = "0x67")]
	[IteratorStateMachine(typeof(<GetEnumerator>d__33))]
	[Token(Token = "0x600019D")]
	public override IEnumerator<InputAction> GetEnumerator() { }

	[Address(RVA = "0x28DB650", Offset = "0x28DAA50", Length = "0xCC")]
	[Token(Token = "0x60001A0")]
	internal bool IsEmpty() { }

	[Address(RVA = "0x28DB720", Offset = "0x28DAB20", Length = "0x2B4")]
	[Token(Token = "0x6000199")]
	public bool IsUsableWithDevice(InputDevice device) { }

	[Address(RVA = "0x28DB9E0", Offset = "0x28DADE0", Length = "0xD5")]
	[Token(Token = "0x6000190")]
	public void LoadFromJson(string json) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600019F")]
	internal void MarkAsDirty() { }

	[Address(RVA = "0x28DBAC0", Offset = "0x28DAEC0", Length = "0x7C4")]
	[Token(Token = "0x60001A6")]
	internal void MigrateJson(ref ReadFileJson parsedJson) { }

	[Address(RVA = "0x28DC290", Offset = "0x28DB690", Length = "0x40")]
	[Token(Token = "0x60001A5")]
	private void OnDestroy() { }

	[Address(RVA = "0x28DC2D0", Offset = "0x28DB6D0", Length = "0x80")]
	[Token(Token = "0x60001A2")]
	internal void OnSetupChanged() { }

	[Address(RVA = "0x28DC360", Offset = "0x28DB760", Length = "0x6E")]
	[Token(Token = "0x60001A1")]
	internal void OnWantToChangeSetup() { }

	[Address(RVA = "0x28DC3D0", Offset = "0x28DB7D0", Length = "0x3F")]
	[Token(Token = "0x60001A3")]
	private void ReResolveIfNecessary(bool fullResolve) { }

	[Address(RVA = "0x28DC410", Offset = "0x28DB810", Length = "0xAA")]
	[Token(Token = "0x60001A4")]
	internal void ResolveBindingsIfNecessary() { }

	[Address(RVA = "0x28DC9A0", Offset = "0x28DBDA0", Length = "0x1CD")]
	[Token(Token = "0x600018B")]
	public override void set_bindingMask(Nullable<InputBinding> value) { }

	[Address(RVA = "0x28DCB70", Offset = "0x28DBF70", Length = "0x73")]
	[Token(Token = "0x600018D")]
	public override void set_devices(Nullable<ReadOnlyArray`1<InputDevice>> value) { }

	[Address(RVA = "0x28DB5E0", Offset = "0x28DA9E0", Length = "0x67")]
	[Token(Token = "0x600019E")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x28DC4C0", Offset = "0x28DB8C0", Length = "0x11B")]
	[Token(Token = "0x600018F")]
	public string ToJson() { }

}

