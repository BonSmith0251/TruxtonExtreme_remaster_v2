namespace UnityEngine.InputSystem;

[DefaultMember("Item")]
[Token(Token = "0x2000027")]
public sealed class InputActionMap : ICloneable, ISerializationCallbackReceiver, IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable
{
	[Token(Token = "0x200002C")]
	public struct BindingJson
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000F1")]
		public string name; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000F2")]
		public string id; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000F3")]
		public string path; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000F4")]
		public string interactions; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000F5")]
		public string processors; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000F6")]
		public string groups; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000F7")]
		public string action; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40000F8")]
		public bool isComposite; //Field offset: 0x38
		[FieldOffset(Offset = "0x39")]
		[Token(Token = "0x40000F9")]
		public bool isPartOfComposite; //Field offset: 0x39

		[Address(RVA = "0x28D8570", Offset = "0x28D7970", Length = "0xBB")]
		[Token(Token = "0x60001FC")]
		public static BindingJson FromBinding(ref InputBinding binding) { }

		[Address(RVA = "0x28D8630", Offset = "0x28D7A30", Length = "0x142")]
		[Token(Token = "0x60001FB")]
		public InputBinding ToBinding() { }

	}

	[Token(Token = "0x200002B")]
	public struct BindingOverrideJson
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000EC")]
		public string action; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000ED")]
		public string id; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000EE")]
		public string path; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000EF")]
		public string interactions; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000F0")]
		public string processors; //Field offset: 0x20

		[Address(RVA = "0x28D8780", Offset = "0x28D7B80", Length = "0x100")]
		[Token(Token = "0x60001F8")]
		public static BindingOverrideJson FromBinding(InputBinding binding, string actionName) { }

		[Address(RVA = "0x28D8880", Offset = "0x28D7C80", Length = "0x7A")]
		[Token(Token = "0x60001F9")]
		public static BindingOverrideJson FromBinding(InputBinding binding) { }

		[Address(RVA = "0x28D8900", Offset = "0x28D7D00", Length = "0x12B")]
		[Token(Token = "0x60001FA")]
		public static InputBinding ToBinding(BindingOverrideJson bindingOverride) { }

	}

	[Token(Token = "0x200002A")]
	public struct BindingOverrideListJson
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000EB")]
		public List<BindingOverrideJson> bindings; //Field offset: 0x0

	}

	[Token(Token = "0x2000029")]
	public struct DeviceArray
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000E8")]
		private bool m_HaveValue; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40000E9")]
		private int m_DeviceCount; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000EA")]
		private InputDevice[] m_DeviceArray; //Field offset: 0x8

		[Address(RVA = "0x28D99E0", Offset = "0x28D8DE0", Length = "0xE0")]
		[Token(Token = "0x60001F6")]
		public Nullable<ReadOnlyArray`1<InputDevice>> Get() { }

		[Address(RVA = "0x28D9AC0", Offset = "0x28D8EC0", Length = "0x4D")]
		[Token(Token = "0x60001F4")]
		public int IndexOf(InputDevice device) { }

		[Address(RVA = "0x28D9B10", Offset = "0x28D8F10", Length = "0x94")]
		[Token(Token = "0x60001F5")]
		public bool Remove(InputDevice device) { }

		[Address(RVA = "0x28D9BB0", Offset = "0x28D8FB0", Length = "0x17D")]
		[Token(Token = "0x60001F7")]
		public bool Set(Nullable<ReadOnlyArray`1<InputDevice>> devices) { }

	}

	[Flags]
	[Token(Token = "0x2000028")]
	private enum Flags : int
	{
		NeedToResolveBindings = 1,
		BindingResolutionNeedsFullReResolve = 2,
		ControlsForEachActionInitialized = 4,
		BindingsForEachActionInitialized = 8,
	}

	[Token(Token = "0x200002D")]
	public struct ReadActionJson
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000FA")]
		public string name; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000FB")]
		public string type; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000FC")]
		public string id; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000FD")]
		public string expectedControlType; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000FE")]
		public string expectedControlLayout; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000FF")]
		public string processors; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000100")]
		public string interactions; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000101")]
		public bool passThrough; //Field offset: 0x38
		[FieldOffset(Offset = "0x39")]
		[Token(Token = "0x4000102")]
		public bool initialStateCheck; //Field offset: 0x39
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000103")]
		public BindingJson[] bindings; //Field offset: 0x40

		[Address(RVA = "0x28ED290", Offset = "0x28EC690", Length = "0x26F")]
		[Token(Token = "0x60001FD")]
		public InputAction ToAction(string actionName = null) { }

	}

	[Token(Token = "0x2000032")]
	public struct ReadFileJson
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000114")]
		public ReadActionJson[] actions; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000115")]
		public ReadMapJson[] maps; //Field offset: 0x8

		[Address(RVA = "0x28ED5F0", Offset = "0x28EC9F0", Length = "0xF90")]
		[Token(Token = "0x6000202")]
		public InputActionMap[] ToMaps() { }

	}

	[Token(Token = "0x200002F")]
	public struct ReadMapJson
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400010B")]
		public string name; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400010C")]
		public string id; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400010D")]
		public ReadActionJson[] actions; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400010E")]
		public BindingJson[] bindings; //Field offset: 0x18

	}

	[Token(Token = "0x200002E")]
	public struct WriteActionJson
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000104")]
		public string name; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000105")]
		public string type; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000106")]
		public string id; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000107")]
		public string expectedControlType; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000108")]
		public string processors; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000109")]
		public string interactions; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400010A")]
		public bool initialStateCheck; //Field offset: 0x30

		[Address(RVA = "0x28F2C90", Offset = "0x28F2090", Length = "0x10A")]
		[Token(Token = "0x60001FE")]
		public static WriteActionJson FromAction(InputAction action) { }

	}

	[Token(Token = "0x2000031")]
	public struct WriteFileJson
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000113")]
		public WriteMapJson[] maps; //Field offset: 0x0

		[Address(RVA = "0x28F2DA0", Offset = "0x28F21A0", Length = "0xA8")]
		[Token(Token = "0x6000200")]
		public static WriteFileJson FromMap(InputActionMap map) { }

		[Address(RVA = "0x28F2E50", Offset = "0x28F2250", Length = "0x29D")]
		[Token(Token = "0x6000201")]
		public static WriteFileJson FromMaps(IEnumerable<InputActionMap> maps) { }

	}

	[Token(Token = "0x2000030")]
	public struct WriteMapJson
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400010F")]
		public string name; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000110")]
		public string id; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000111")]
		public WriteActionJson[] actions; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000112")]
		public BindingJson[] bindings; //Field offset: 0x18

		[Address(RVA = "0x28F30F0", Offset = "0x28F24F0", Length = "0x47A")]
		[Token(Token = "0x60001FF")]
		public static WriteMapJson FromMap(InputActionMap map) { }

	}

	[Token(Token = "0x40000CE")]
	private static readonly ProfilerMarker k_ResolveBindingsProfilerMarker; //Field offset: 0x0
	[Token(Token = "0x40000E1")]
	internal static int s_DeferBindingResolution; //Field offset: 0x8
	[Token(Token = "0x40000E2")]
	internal static bool s_NeedToResolveBindings; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x40000CF")]
	internal string m_Name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40000D0")]
	internal string m_Id; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40000D1")]
	internal InputActionAsset m_Asset; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40000D2")]
	internal InputAction[] m_Actions; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40000D3")]
	internal InputBinding[] m_Bindings; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000D4")]
	private InputBinding[] m_BindingsForEachAction; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000D5")]
	private InputControl[] m_ControlsForEachAction; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000D6")]
	internal int m_EnabledActionsCount; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000D7")]
	internal InputAction m_SingletonAction; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40000D8")]
	internal int m_MapIndexInState; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40000D9")]
	internal InputActionState m_State; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40000DA")]
	internal Nullable<InputBinding> m_BindingMask; //Field offset: 0x68
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40000DB")]
	private Flags m_Flags; //Field offset: 0xC8
	[FieldOffset(Offset = "0xCC")]
	[Token(Token = "0x40000DC")]
	internal int m_ParameterOverridesCount; //Field offset: 0xCC
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40000DD")]
	internal ParameterOverride[] m_ParameterOverrides; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40000DE")]
	internal DeviceArray m_Devices; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40000DF")]
	internal CallbackArray<Action`1<CallbackContext>> m_ActionCallbacks; //Field offset: 0xE8
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x40000E0")]
	internal Dictionary<String, Int32> m_ActionIndexByNameOrId; //Field offset: 0x138

	[Token(Token = "0x14000004")]
	public event Action<CallbackContext> actionTriggered
	{
		[Address(RVA = "0x28E06E0", Offset = "0x28DFAE0", Length = "0x4C")]
		[Token(Token = "0x60001C5")]
		 add { } //Length: 76
		[Address(RVA = "0x28E0BF0", Offset = "0x28DFFF0", Length = "0x4C")]
		[Token(Token = "0x60001C6")]
		 remove { } //Length: 76
	}

	[Token(Token = "0x170000B7")]
	public ReadOnlyArray<InputAction> actions
	{
		[Address(RVA = "0x28E0840", Offset = "0x28DFC40", Length = "0x53")]
		[Token(Token = "0x60001BC")]
		 get { } //Length: 83
	}

	[Token(Token = "0x170000B3")]
	public InputActionAsset asset
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60001B8")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000BB")]
	public override Nullable<InputBinding> bindingMask
	{
		[Address(RVA = "0x28E08A0", Offset = "0x28DFCA0", Length = "0x3F")]
		[Token(Token = "0x60001C0")]
		 get { } //Length: 63
		[Address(RVA = "0x28E0C40", Offset = "0x28E0040", Length = "0x1B8")]
		[Token(Token = "0x60001C1")]
		 set { } //Length: 440
	}

	[Token(Token = "0x170000BF")]
	private bool bindingResolutionNeedsFullReResolve
	{
		[Address(RVA = "0x28E08E0", Offset = "0x28DFCE0", Length = "0xB")]
		[Token(Token = "0x60001DB")]
		private get { } //Length: 11
		[Address(RVA = "0x28E0E00", Offset = "0x28E0200", Length = "0x1F")]
		[Token(Token = "0x60001DC")]
		private set { } //Length: 31
	}

	[Token(Token = "0x170000B8")]
	public ReadOnlyArray<InputBinding> bindings
	{
		[Address(RVA = "0x28E0900", Offset = "0x28DFD00", Length = "0x53")]
		[Token(Token = "0x60001BD")]
		 get { } //Length: 83
	}

	[Token(Token = "0x170000C1")]
	private bool bindingsForEachActionInitialized
	{
		[Address(RVA = "0x28E08F0", Offset = "0x28DFCF0", Length = "0xB")]
		[Token(Token = "0x60001DF")]
		private get { } //Length: 11
		[Address(RVA = "0x28E0E20", Offset = "0x28E0220", Length = "0x1F")]
		[Token(Token = "0x60001E0")]
		private set { } //Length: 31
	}

	[Token(Token = "0x170000BA")]
	public override ReadOnlyArray<InputControlScheme> controlSchemes
	{
		[Address(RVA = "0x28E0960", Offset = "0x28DFD60", Length = "0xC1")]
		[Token(Token = "0x60001BF")]
		 get { } //Length: 193
	}

	[Token(Token = "0x170000C0")]
	private bool controlsForEachActionInitialized
	{
		[Address(RVA = "0x28E0A30", Offset = "0x28DFE30", Length = "0xB")]
		[Token(Token = "0x60001DD")]
		private get { } //Length: 11
		[Address(RVA = "0x28E0E40", Offset = "0x28E0240", Length = "0x1F")]
		[Token(Token = "0x60001DE")]
		private set { } //Length: 31
	}

	[Token(Token = "0x170000BC")]
	public override Nullable<ReadOnlyArray`1<InputDevice>> devices
	{
		[Address(RVA = "0x28E0A40", Offset = "0x28DFE40", Length = "0xCD")]
		[Token(Token = "0x60001C2")]
		 get { } //Length: 205
		[Address(RVA = "0x28E0E60", Offset = "0x28E0260", Length = "0x4C")]
		[Token(Token = "0x60001C3")]
		 set { } //Length: 76
	}

	[Token(Token = "0x170000B6")]
	public bool enabled
	{
		[Address(RVA = "0x23233A0", Offset = "0x23227A0", Length = "0x8")]
		[Token(Token = "0x60001BB")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000B4")]
	public Guid id
	{
		[Address(RVA = "0x28E0B60", Offset = "0x28DFF60", Length = "0x7A")]
		[Token(Token = "0x60001B9")]
		 get { } //Length: 122
	}

	[Token(Token = "0x170000B5")]
	internal Guid idDontGenerate
	{
		[Address(RVA = "0x28E0B10", Offset = "0x28DFF10", Length = "0x4E")]
		[Token(Token = "0x60001BA")]
		internal get { } //Length: 78
	}

	[Token(Token = "0x170000BD")]
	public InputAction Item
	{
		[Address(RVA = "0x28E0730", Offset = "0x28DFB30", Length = "0x107")]
		[Token(Token = "0x60001C4")]
		 get { } //Length: 263
	}

	[Token(Token = "0x170000B2")]
	public string name
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60001B7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000BE")]
	private bool needToResolveBindings
	{
		[Address(RVA = "0x28E0BE0", Offset = "0x28DFFE0", Length = "0xA")]
		[Token(Token = "0x60001D9")]
		private get { } //Length: 10
		[Address(RVA = "0x28E0EB0", Offset = "0x28E02B0", Length = "0x1F")]
		[Token(Token = "0x60001DA")]
		private set { } //Length: 31
	}

	[Token(Token = "0x170000B9")]
	private override IEnumerable<InputBinding> UnityEngine.InputSystem.IInputActionCollection2.bindings
	{
		[Address(RVA = "0x28E0540", Offset = "0x28DF940", Length = "0x80")]
		[Token(Token = "0x60001BE")]
		private get { } //Length: 128
	}

	[Address(RVA = "0x28E05C0", Offset = "0x28DF9C0", Length = "0x5E")]
	[Token(Token = "0x60001F3")]
	private static InputActionMap() { }

	[Address(RVA = "0x28E06A0", Offset = "0x28DFAA0", Length = "0x31")]
	[Token(Token = "0x60001C8")]
	public InputActionMap(string name) { }

	[Address(RVA = "0x28E0620", Offset = "0x28DFA20", Length = "0x74")]
	[Token(Token = "0x60001C7")]
	public InputActionMap() { }

	[Address(RVA = "0x28E06E0", Offset = "0x28DFAE0", Length = "0x4C")]
	[Token(Token = "0x60001C5")]
	public void add_actionTriggered(Action<CallbackContext> value) { }

	[Address(RVA = "0x28DCBF0", Offset = "0x28DBFF0", Length = "0x48")]
	[Token(Token = "0x60001CC")]
	internal void ClearActionLookupTable() { }

	[Address(RVA = "0x28DCC40", Offset = "0x28DC040", Length = "0x5F")]
	[Token(Token = "0x60001E7")]
	internal void ClearCachedActionData(bool onlyControls = false) { }

	[Address(RVA = "0x28DCCA0", Offset = "0x28DC0A0", Length = "0x301")]
	[Token(Token = "0x60001D3")]
	public InputActionMap Clone() { }

	[Address(RVA = "0x28DCFB0", Offset = "0x28DC3B0", Length = "0x28")]
	[Token(Token = "0x60001D5")]
	public override bool Contains(InputAction action) { }

	[Address(RVA = "0x28DCFE0", Offset = "0x28DC3E0", Length = "0x2F")]
	[Token(Token = "0x60001D2")]
	public override void Disable() { }

	[Address(RVA = "0x28DD010", Offset = "0x28DC410", Length = "0x11")]
	[Token(Token = "0x60001C9")]
	public override void Dispose() { }

	[Address(RVA = "0x28DD030", Offset = "0x28DC430", Length = "0x64")]
	[Token(Token = "0x60001D1")]
	public override void Enable() { }

	[Address(RVA = "0x28DD580", Offset = "0x28DC980", Length = "0x129")]
	[Token(Token = "0x60001CF")]
	public InputAction FindAction(Guid id) { }

	[Address(RVA = "0x28DD6B0", Offset = "0x28DCAB0", Length = "0x12B")]
	[Token(Token = "0x60001CE")]
	public override InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false) { }

	[Address(RVA = "0x28DD0A0", Offset = "0x28DC4A0", Length = "0x3BA")]
	[Token(Token = "0x60001CA")]
	internal int FindActionIndex(string nameOrId) { }

	[Address(RVA = "0x28DD460", Offset = "0x28DC860", Length = "0x113")]
	[Token(Token = "0x60001CD")]
	private int FindActionIndex(Guid id) { }

	[Address(RVA = "0x28DD890", Offset = "0x28DCC90", Length = "0x258")]
	[Token(Token = "0x60001EC")]
	public override int FindBinding(InputBinding mask, out InputAction action) { }

	[Address(RVA = "0x28DD7E0", Offset = "0x28DCBE0", Length = "0xAB")]
	[Token(Token = "0x60001ED")]
	internal int FindBindingRelativeToMap(InputBinding mask) { }

	[Address(RVA = "0x28DDAF0", Offset = "0x28DCEF0", Length = "0xA3")]
	[Token(Token = "0x60001EE")]
	public static InputActionMap[] FromJson(string json) { }

	[Address(RVA = "0x28DDBA0", Offset = "0x28DCFA0", Length = "0x47")]
	[Token(Token = "0x60001E8")]
	internal void GenerateId() { }

	[Address(RVA = "0x28E0840", Offset = "0x28DFC40", Length = "0x53")]
	[Token(Token = "0x60001BC")]
	public ReadOnlyArray<InputAction> get_actions() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60001B8")]
	public InputActionAsset get_asset() { }

	[Address(RVA = "0x28E08A0", Offset = "0x28DFCA0", Length = "0x3F")]
	[Token(Token = "0x60001C0")]
	public override Nullable<InputBinding> get_bindingMask() { }

	[Address(RVA = "0x28E08E0", Offset = "0x28DFCE0", Length = "0xB")]
	[Token(Token = "0x60001DB")]
	private bool get_bindingResolutionNeedsFullReResolve() { }

	[Address(RVA = "0x28E0900", Offset = "0x28DFD00", Length = "0x53")]
	[Token(Token = "0x60001BD")]
	public ReadOnlyArray<InputBinding> get_bindings() { }

	[Address(RVA = "0x28E08F0", Offset = "0x28DFCF0", Length = "0xB")]
	[Token(Token = "0x60001DF")]
	private bool get_bindingsForEachActionInitialized() { }

	[Address(RVA = "0x28E0960", Offset = "0x28DFD60", Length = "0xC1")]
	[Token(Token = "0x60001BF")]
	public override ReadOnlyArray<InputControlScheme> get_controlSchemes() { }

	[Address(RVA = "0x28E0A30", Offset = "0x28DFE30", Length = "0xB")]
	[Token(Token = "0x60001DD")]
	private bool get_controlsForEachActionInitialized() { }

	[Address(RVA = "0x28E0A40", Offset = "0x28DFE40", Length = "0xCD")]
	[Token(Token = "0x60001C2")]
	public override Nullable<ReadOnlyArray`1<InputDevice>> get_devices() { }

	[Address(RVA = "0x23233A0", Offset = "0x23227A0", Length = "0x8")]
	[Token(Token = "0x60001BB")]
	public bool get_enabled() { }

	[Address(RVA = "0x28E0B60", Offset = "0x28DFF60", Length = "0x7A")]
	[Token(Token = "0x60001B9")]
	public Guid get_id() { }

	[Address(RVA = "0x28E0B10", Offset = "0x28DFF10", Length = "0x4E")]
	[Token(Token = "0x60001BA")]
	internal Guid get_idDontGenerate() { }

	[Address(RVA = "0x28E0730", Offset = "0x28DFB30", Length = "0x107")]
	[Token(Token = "0x60001C4")]
	public InputAction get_Item(string actionNameOrId) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60001B7")]
	public string get_name() { }

	[Address(RVA = "0x28E0BE0", Offset = "0x28DFFE0", Length = "0xA")]
	[Token(Token = "0x60001D9")]
	private bool get_needToResolveBindings() { }

	[Address(RVA = "0x28DDBF0", Offset = "0x28DCFF0", Length = "0x90")]
	[Token(Token = "0x60001E1")]
	internal ReadOnlyArray<InputBinding> GetBindingsForSingleAction(InputAction action) { }

	[Address(RVA = "0x28DDC90", Offset = "0x28DD090", Length = "0x90")]
	[Token(Token = "0x60001E2")]
	internal ReadOnlyArray<InputControl> GetControlsForSingleAction(InputAction action) { }

	[Address(RVA = "0x28DDD30", Offset = "0x28DD130", Length = "0xC0")]
	[Token(Token = "0x60001D7")]
	public override IEnumerator<InputAction> GetEnumerator() { }

	[Address(RVA = "0x28DDDF0", Offset = "0x28DD1F0", Length = "0x163")]
	[Token(Token = "0x60001D0")]
	public bool IsUsableWithDevice(InputDevice device) { }

	[Address(RVA = "0x28DDF60", Offset = "0x28DD360", Length = "0xF7")]
	[Token(Token = "0x60001E9")]
	internal bool LazyResolveBindings(bool fullResolve) { }

	[Address(RVA = "0x28DE060", Offset = "0x28DD460", Length = "0x183")]
	[Token(Token = "0x60001F2")]
	public override void OnAfterDeserialize() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001F1")]
	public override void OnBeforeSerialize() { }

	[Address(RVA = "0x28DE1F0", Offset = "0x28DD5F0", Length = "0x68")]
	[Token(Token = "0x60001E6")]
	internal void OnBindingModified() { }

	[Address(RVA = "0x28DE260", Offset = "0x28DD660", Length = "0x30F")]
	[Token(Token = "0x60001E5")]
	internal void OnSetupChanged() { }

	[Address(RVA = "0x28DE570", Offset = "0x28DD970", Length = "0x28D")]
	[Token(Token = "0x60001E4")]
	internal void OnWantToChangeSetup() { }

	[Address(RVA = "0x28E0BF0", Offset = "0x28DFFF0", Length = "0x4C")]
	[Token(Token = "0x60001C6")]
	public void remove_actionTriggered(Action<CallbackContext> value) { }

	[Address(RVA = "0x28DE840", Offset = "0x28DDC40", Length = "0xDC6")]
	[Token(Token = "0x60001EB")]
	internal void ResolveBindings() { }

	[Address(RVA = "0x28DE800", Offset = "0x28DDC00", Length = "0x36")]
	[Token(Token = "0x60001EA")]
	internal bool ResolveBindingsIfNecessary() { }

	[Address(RVA = "0x28E0C40", Offset = "0x28E0040", Length = "0x1B8")]
	[Token(Token = "0x60001C1")]
	public override void set_bindingMask(Nullable<InputBinding> value) { }

	[Address(RVA = "0x28E0E00", Offset = "0x28E0200", Length = "0x1F")]
	[Token(Token = "0x60001DC")]
	private void set_bindingResolutionNeedsFullReResolve(bool value) { }

	[Address(RVA = "0x28E0E20", Offset = "0x28E0220", Length = "0x1F")]
	[Token(Token = "0x60001E0")]
	private void set_bindingsForEachActionInitialized(bool value) { }

	[Address(RVA = "0x28E0E40", Offset = "0x28E0240", Length = "0x1F")]
	[Token(Token = "0x60001DE")]
	private void set_controlsForEachActionInitialized(bool value) { }

	[Address(RVA = "0x28E0E60", Offset = "0x28E0260", Length = "0x4C")]
	[Token(Token = "0x60001C3")]
	public override void set_devices(Nullable<ReadOnlyArray`1<InputDevice>> value) { }

	[Address(RVA = "0x28E0EB0", Offset = "0x28E02B0", Length = "0x1F")]
	[Token(Token = "0x60001DA")]
	private void set_needToResolveBindings(bool value) { }

	[Address(RVA = "0x28DF610", Offset = "0x28DEA10", Length = "0x1B4")]
	[Token(Token = "0x60001CB")]
	private void SetUpActionLookupTable() { }

	[Address(RVA = "0x28DF7D0", Offset = "0x28DEBD0", Length = "0xAFD")]
	[Token(Token = "0x60001E3")]
	private void SetUpPerActionControlAndBindingArrays() { }

	[Address(RVA = "0x28DDD30", Offset = "0x28DD130", Length = "0xC0")]
	[Token(Token = "0x60001D8")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x28E02D0", Offset = "0x28DF6D0", Length = "0x7")]
	[Token(Token = "0x60001D4")]
	private override object System.ICloneable.Clone() { }

	[Address(RVA = "0x28E02E0", Offset = "0x28DF6E0", Length = "0xA5")]
	[Token(Token = "0x60001EF")]
	public static string ToJson(IEnumerable<InputActionMap> maps) { }

	[Address(RVA = "0x28E0390", Offset = "0x28DF790", Length = "0xE7")]
	[Token(Token = "0x60001F0")]
	public string ToJson() { }

	[Address(RVA = "0x28E0480", Offset = "0x28DF880", Length = "0xBC")]
	[Token(Token = "0x60001D6")]
	public virtual string ToString() { }

	[Address(RVA = "0x28E0540", Offset = "0x28DF940", Length = "0x80")]
	[Token(Token = "0x60001BE")]
	private override IEnumerable<InputBinding> UnityEngine.InputSystem.IInputActionCollection2.get_bindings() { }

}

