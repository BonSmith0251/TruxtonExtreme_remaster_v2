namespace UnityEngine.InputSystem;

[Extension]
[Token(Token = "0x2000040")]
public static class InputActionSetupExtensions
{
	[CompilerGenerated]
	[Token(Token = "0x2000044")]
	private sealed class <>c__DisplayClass5_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000178")]
		public InputBinding binding; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60002F1")]
		public <>c__DisplayClass5_0() { }

		[Address(RVA = "0x290B9B0", Offset = "0x290ADB0", Length = "0x14A")]
		[Token(Token = "0x60002F2")]
		internal bool <RemoveAction>b__0(InputBinding b) { }

	}

	[Token(Token = "0x2000041")]
	internal struct BindingSyntax
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400016F")]
		private readonly InputActionMap m_ActionMap; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000170")]
		private readonly InputAction m_Action; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000171")]
		internal readonly int m_BindingIndexInMap; //Field offset: 0x10

		[Token(Token = "0x170000D9")]
		public InputBinding binding
		{
			[Address(RVA = "0x28FAB50", Offset = "0x28F9F50", Length = "0x127")]
			[Token(Token = "0x60002C7")]
			 get { } //Length: 295
		}

		[Token(Token = "0x170000D8")]
		public int bindingIndex
		{
			[Address(RVA = "0x28FAAC0", Offset = "0x28F9EC0", Length = "0x84")]
			[Token(Token = "0x60002C6")]
			 get { } //Length: 132
		}

		[Token(Token = "0x170000D7")]
		public bool valid
		{
			[Address(RVA = "0x28FAC80", Offset = "0x28FA080", Length = "0x64")]
			[Token(Token = "0x60002C5")]
			 get { } //Length: 100
		}

		[Address(RVA = "0x28FAA70", Offset = "0x28F9E70", Length = "0x42")]
		[Token(Token = "0x60002C8")]
		internal BindingSyntax(InputActionMap map, int bindingIndexInMap, InputAction action = null) { }

		[Address(RVA = "0x28F8B10", Offset = "0x28F7F10", Length = "0x20F")]
		[Token(Token = "0x60002DE")]
		public void Erase() { }

		[Address(RVA = "0x28FAB50", Offset = "0x28F9F50", Length = "0x127")]
		[Token(Token = "0x60002C7")]
		public InputBinding get_binding() { }

		[Address(RVA = "0x28FAAC0", Offset = "0x28F9EC0", Length = "0x84")]
		[Token(Token = "0x60002C6")]
		public int get_bindingIndex() { }

		[Address(RVA = "0x28FAC80", Offset = "0x28FA080", Length = "0x64")]
		[Token(Token = "0x60002C5")]
		public bool get_valid() { }

		[Address(RVA = "0x28F8D20", Offset = "0x28F8120", Length = "0x2E3")]
		[Token(Token = "0x60002DF")]
		public BindingSyntax InsertPartBinding(string partName, string path) { }

		[Address(RVA = "0x28F9390", Offset = "0x28F8790", Length = "0x148")]
		[Token(Token = "0x60002DB")]
		private BindingSyntax Iterate(bool next) { }

		[Address(RVA = "0x28F9010", Offset = "0x28F8410", Length = "0x18C")]
		[Token(Token = "0x60002DC")]
		private BindingSyntax IterateCompositeBinding(bool next, string compositeName) { }

		[Address(RVA = "0x28F91A0", Offset = "0x28F85A0", Length = "0x1E2")]
		[Token(Token = "0x60002DD")]
		private BindingSyntax IteratePartBinding(bool next, string partName) { }

		[Address(RVA = "0x28F94E0", Offset = "0x28F88E0", Length = "0x32")]
		[Token(Token = "0x60002D5")]
		public BindingSyntax NextBinding() { }

		[Address(RVA = "0x28F9520", Offset = "0x28F8920", Length = "0x3B")]
		[Token(Token = "0x60002D9")]
		public BindingSyntax NextCompositeBinding(string compositeName = null) { }

		[Address(RVA = "0x28F9560", Offset = "0x28F8960", Length = "0xAD")]
		[Token(Token = "0x60002D7")]
		public BindingSyntax NextPartBinding(string partName) { }

		[Address(RVA = "0x28F9610", Offset = "0x28F8A10", Length = "0x32")]
		[Token(Token = "0x60002D6")]
		public BindingSyntax PreviousBinding() { }

		[Address(RVA = "0x28F9650", Offset = "0x28F8A50", Length = "0x3B")]
		[Token(Token = "0x60002DA")]
		public BindingSyntax PreviousCompositeBinding(string compositeName = null) { }

		[Address(RVA = "0x28F9690", Offset = "0x28F8A90", Length = "0xAD")]
		[Token(Token = "0x60002D8")]
		public BindingSyntax PreviousPartBinding(string partName) { }

		[Address(RVA = "0x28F9740", Offset = "0x28F8B40", Length = "0x1B6")]
		[Token(Token = "0x60002D4")]
		public BindingSyntax To(InputBinding binding) { }

		[Address(RVA = "0x28F9900", Offset = "0x28F8D00", Length = "0x206")]
		[Token(Token = "0x60002D3")]
		public BindingSyntax Triggering(InputAction action) { }

		[Address(RVA = "0x28F9B10", Offset = "0x28F8F10", Length = "0x204")]
		[Token(Token = "0x60002CB")]
		public BindingSyntax WithGroup(string group) { }

		[Address(RVA = "0x28F9D20", Offset = "0x28F9120", Length = "0x234")]
		[Token(Token = "0x60002CC")]
		public BindingSyntax WithGroups(string groups) { }

		[Address(RVA = "0x9F06E0", Offset = "0x9EFAE0", Length = "0x1BC")]
		[Token(Token = "0x60002CF")]
		public BindingSyntax WithInteraction() { }

		[Address(RVA = "0x28F9F60", Offset = "0x28F9360", Length = "0x204")]
		[Token(Token = "0x60002CD")]
		public BindingSyntax WithInteraction(string interaction) { }

		[Address(RVA = "0x28FA170", Offset = "0x28F9570", Length = "0x234")]
		[Token(Token = "0x60002CE")]
		public BindingSyntax WithInteractions(string interactions) { }

		[Address(RVA = "0x28FA3B0", Offset = "0x28F97B0", Length = "0x12E")]
		[Token(Token = "0x60002C9")]
		public BindingSyntax WithName(string name) { }

		[Address(RVA = "0x28FA4E0", Offset = "0x28F98E0", Length = "0x130")]
		[Token(Token = "0x60002CA")]
		public BindingSyntax WithPath(string path) { }

		[Address(RVA = "0x28FA620", Offset = "0x28F9A20", Length = "0x204")]
		[Token(Token = "0x60002D0")]
		public BindingSyntax WithProcessor(string processor) { }

		[Address(RVA = "0x9F08A0", Offset = "0x9EFCA0", Length = "0x1BC")]
		[Token(Token = "0x60002D2")]
		public BindingSyntax WithProcessor() { }

		[Address(RVA = "0x28FA830", Offset = "0x28F9C30", Length = "0x234")]
		[Token(Token = "0x60002D1")]
		public BindingSyntax WithProcessors(string processors) { }

	}

	[Token(Token = "0x2000042")]
	internal struct CompositeSyntax
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000172")]
		private readonly InputAction m_Action; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000173")]
		private readonly InputActionMap m_ActionMap; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000174")]
		private int m_BindingIndexInMap; //Field offset: 0x10

		[Token(Token = "0x170000DA")]
		public int bindingIndex
		{
			[Address(RVA = "0x28FAF40", Offset = "0x28FA340", Length = "0x25")]
			[Token(Token = "0x60002E0")]
			 get { } //Length: 37
		}

		[Address(RVA = "0x28FAEF0", Offset = "0x28FA2F0", Length = "0x46")]
		[Token(Token = "0x60002E1")]
		internal CompositeSyntax(InputActionMap map, InputAction action, int compositeIndex) { }

		[Address(RVA = "0x28FAF40", Offset = "0x28FA340", Length = "0x25")]
		[Token(Token = "0x60002E0")]
		public int get_bindingIndex() { }

		[Address(RVA = "0x28FACF0", Offset = "0x28FA0F0", Length = "0x1F3")]
		[Token(Token = "0x60002E2")]
		public CompositeSyntax With(string name, string binding, string groups = null, string processors = null) { }

	}

	[Token(Token = "0x2000043")]
	internal struct ControlSchemeSyntax
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000175")]
		private readonly InputActionAsset m_Asset; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000176")]
		private readonly int m_ControlSchemeIndex; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000177")]
		private InputControlScheme m_ControlScheme; //Field offset: 0x10

		[Address(RVA = "0x28FB540", Offset = "0x28FA940", Length = "0x33")]
		[Token(Token = "0x60002E3")]
		internal ControlSchemeSyntax(InputActionAsset asset, int index) { }

		[Address(RVA = "0x28FB4F0", Offset = "0x28FA8F0", Length = "0x4B")]
		[Token(Token = "0x60002E4")]
		internal ControlSchemeSyntax(InputControlScheme controlScheme) { }

		[Address(RVA = "0x28FAF70", Offset = "0x28FA370", Length = "0x222")]
		[Token(Token = "0x60002F0")]
		private void AddDeviceEntry(string controlPath, Flags flags) { }

		[Address(RVA = "0x9F13F0", Offset = "0x9F07F0", Length = "0x13F")]
		[Token(Token = "0x60002EE")]
		private string DeviceTypeToControlPath() { }

		[Address(RVA = "0x28FB1A0", Offset = "0x28FA5A0", Length = "0xB7")]
		[Token(Token = "0x60002EF")]
		public InputControlScheme Done() { }

		[Address(RVA = "0x9F1530", Offset = "0x9F0930", Length = "0x74")]
		[Token(Token = "0x60002E9")]
		public ControlSchemeSyntax OrWithOptionalDevice() { }

		[Address(RVA = "0x28FB260", Offset = "0x28FA660", Length = "0x4D")]
		[Token(Token = "0x60002ED")]
		public ControlSchemeSyntax OrWithOptionalDevice(string controlPath) { }

		[Address(RVA = "0x9F15B0", Offset = "0x9F09B0", Length = "0x74")]
		[Token(Token = "0x60002E8")]
		public ControlSchemeSyntax OrWithRequiredDevice() { }

		[Address(RVA = "0x28FB2B0", Offset = "0x28FA6B0", Length = "0x4D")]
		[Token(Token = "0x60002EC")]
		public ControlSchemeSyntax OrWithRequiredDevice(string controlPath) { }

		[Address(RVA = "0x28FB300", Offset = "0x28FA700", Length = "0x141")]
		[Token(Token = "0x60002E5")]
		public ControlSchemeSyntax WithBindingGroup(string bindingGroup) { }

		[Address(RVA = "0x9F1630", Offset = "0x9F0A30", Length = "0x74")]
		[Token(Token = "0x60002E7")]
		public ControlSchemeSyntax WithOptionalDevice() { }

		[Address(RVA = "0x28FB450", Offset = "0x28FA850", Length = "0x4D")]
		[Token(Token = "0x60002EB")]
		public ControlSchemeSyntax WithOptionalDevice(string controlPath) { }

		[Address(RVA = "0x9F16B0", Offset = "0x9F0AB0", Length = "0x74")]
		[Token(Token = "0x60002E6")]
		public ControlSchemeSyntax WithRequiredDevice() { }

		[Address(RVA = "0x28FB4A0", Offset = "0x28FA8A0", Length = "0x4A")]
		[Token(Token = "0x60002EA")]
		public ControlSchemeSyntax WithRequiredDevice(string controlPath) { }

	}


	[Address(RVA = "0x28FCE20", Offset = "0x28FC220", Length = "0x3FA")]
	[Extension]
	[Token(Token = "0x60002A6")]
	public static InputAction AddAction(InputActionMap map, string name, InputActionType type = 0, string binding = null, string interactions = null, string processors = null, string groups = null, string expectedControlLayout = null) { }

	[Address(RVA = "0x28FCC20", Offset = "0x28FC020", Length = "0x1F0")]
	[Extension]
	[Token(Token = "0x60002A2")]
	public static InputActionMap AddActionMap(InputActionAsset asset, string name) { }

	[Address(RVA = "0x28FC920", Offset = "0x28FBD20", Length = "0x2FE")]
	[Extension]
	[Token(Token = "0x60002A3")]
	public static void AddActionMap(InputActionAsset asset, InputActionMap map) { }

	[Address(RVA = "0x28FD3E0", Offset = "0x28FC7E0", Length = "0x1E7")]
	[Extension]
	[Token(Token = "0x60002A9")]
	public static BindingSyntax AddBinding(InputAction action, string path, string interactions = null, string processors = null, string groups = null) { }

	[Address(RVA = "0x28FD960", Offset = "0x28FCD60", Length = "0xA9")]
	[Extension]
	[Token(Token = "0x60002AA")]
	public static BindingSyntax AddBinding(InputAction action, InputControl control) { }

	[Address(RVA = "0x28FD6C0", Offset = "0x28FCAC0", Length = "0x12E")]
	[Extension]
	[Token(Token = "0x60002AB")]
	public static BindingSyntax AddBinding(InputAction action, InputBinding binding = null) { }

	[Address(RVA = "0x28FDA10", Offset = "0x28FCE10", Length = "0x25E")]
	[Extension]
	[Token(Token = "0x60002AC")]
	public static BindingSyntax AddBinding(InputActionMap actionMap, string path, string interactions = null, string groups = null, string action = null, string processors = null) { }

	[Address(RVA = "0x28FDC70", Offset = "0x28FD070", Length = "0x1AF")]
	[Extension]
	[Token(Token = "0x60002AD")]
	public static BindingSyntax AddBinding(InputActionMap actionMap, string path, InputAction action, string interactions = null, string groups = null) { }

	[Address(RVA = "0x28FD5D0", Offset = "0x28FC9D0", Length = "0xED")]
	[Extension]
	[Token(Token = "0x60002AE")]
	public static BindingSyntax AddBinding(InputActionMap actionMap, string path, Guid action, string interactions = null, string groups = null) { }

	[Address(RVA = "0x28FD7F0", Offset = "0x28FCBF0", Length = "0x16A")]
	[Extension]
	[Token(Token = "0x60002AF")]
	public static BindingSyntax AddBinding(InputActionMap actionMap, InputBinding binding) { }

	[Address(RVA = "0x28FD220", Offset = "0x28FC620", Length = "0x1BD")]
	[Token(Token = "0x60002B1")]
	private static int AddBindingInternal(InputActionMap map, InputBinding binding, int bindingIndex = -1) { }

	[Address(RVA = "0x28FDE20", Offset = "0x28FD220", Length = "0x22E")]
	[Extension]
	[Token(Token = "0x60002B0")]
	public static CompositeSyntax AddCompositeBinding(InputAction action, string composite, string interactions = null, string processors = null) { }

	[Address(RVA = "0x28FE340", Offset = "0x28FD740", Length = "0x1E8")]
	[Extension]
	[Token(Token = "0x60002BD")]
	public static ControlSchemeSyntax AddControlScheme(InputActionAsset asset, string name) { }

	[Address(RVA = "0x28FE050", Offset = "0x28FD450", Length = "0x2E4")]
	[Extension]
	[Token(Token = "0x60002BC")]
	public static void AddControlScheme(InputActionAsset asset, InputControlScheme controlScheme) { }

	[Address(RVA = "0x28FEBF0", Offset = "0x28FDFF0", Length = "0x202")]
	[Extension]
	[Token(Token = "0x60002B9")]
	public static BindingSyntax ChangeBinding(InputAction action, InputBinding match) { }

	[Address(RVA = "0x28FE9E0", Offset = "0x28FDDE0", Length = "0x131")]
	[Extension]
	[Token(Token = "0x60002B4")]
	public static BindingSyntax ChangeBinding(InputActionMap actionMap, int index) { }

	[Address(RVA = "0x28FEB20", Offset = "0x28FDF20", Length = "0xD0")]
	[Extension]
	[Token(Token = "0x60002B3")]
	public static BindingSyntax ChangeBinding(InputAction action, string name) { }

	[Address(RVA = "0x28FEE00", Offset = "0x28FE200", Length = "0xBC")]
	[Extension]
	[Token(Token = "0x60002B2")]
	public static BindingSyntax ChangeBinding(InputAction action, int index) { }

	[Address(RVA = "0x28FE530", Offset = "0x28FD930", Length = "0x128")]
	[Extension]
	[Token(Token = "0x60002B7")]
	public static BindingSyntax ChangeBindingWithGroup(InputAction action, string group) { }

	[Address(RVA = "0x28FE660", Offset = "0x28FDA60", Length = "0x128")]
	[Extension]
	[Token(Token = "0x60002B5")]
	public static BindingSyntax ChangeBindingWithId(InputAction action, string id) { }

	[Address(RVA = "0x28FE790", Offset = "0x28FDB90", Length = "0x11F")]
	[Extension]
	[Token(Token = "0x60002B6")]
	public static BindingSyntax ChangeBindingWithId(InputAction action, Guid id) { }

	[Address(RVA = "0x28FE8B0", Offset = "0x28FDCB0", Length = "0x128")]
	[Extension]
	[Token(Token = "0x60002B8")]
	public static BindingSyntax ChangeBindingWithPath(InputAction action, string path) { }

	[Address(RVA = "0x28FEEC0", Offset = "0x28FE2C0", Length = "0x29C")]
	[Extension]
	[Token(Token = "0x60002BA")]
	public static BindingSyntax ChangeCompositeBinding(InputAction action, string compositeName) { }

	[Address(RVA = "0x28FF160", Offset = "0x28FE560", Length = "0x151")]
	[Extension]
	[Token(Token = "0x60002C4")]
	public static InputControlScheme OrWithOptionalDevice(InputControlScheme scheme, string controlPath) { }

	[Address(RVA = "0x28FF2C0", Offset = "0x28FE6C0", Length = "0x151")]
	[Extension]
	[Token(Token = "0x60002C3")]
	public static InputControlScheme OrWithRequiredDevice(InputControlScheme scheme, string controlPath) { }

	[Address(RVA = "0x28FFC00", Offset = "0x28FF000", Length = "0x11E")]
	[Extension]
	[Token(Token = "0x60002A8")]
	public static void RemoveAction(InputActionAsset asset, string nameOrId) { }

	[Address(RVA = "0x28FF7F0", Offset = "0x28FEBF0", Length = "0x404")]
	[Extension]
	[Token(Token = "0x60002A7")]
	public static void RemoveAction(InputAction action) { }

	[Address(RVA = "0x28FF5B0", Offset = "0x28FE9B0", Length = "0x23B")]
	[Extension]
	[Token(Token = "0x60002A5")]
	public static void RemoveActionMap(InputActionAsset asset, string nameOrId) { }

	[Address(RVA = "0x28FF420", Offset = "0x28FE820", Length = "0x18F")]
	[Extension]
	[Token(Token = "0x60002A4")]
	public static void RemoveActionMap(InputActionAsset asset, InputActionMap map) { }

	[Address(RVA = "0x28FFD20", Offset = "0x28FF120", Length = "0x149")]
	[Extension]
	[Token(Token = "0x60002BE")]
	public static void RemoveControlScheme(InputActionAsset asset, string name) { }

	[Address(RVA = "0x28FFE70", Offset = "0x28FF270", Length = "0x2E0")]
	[Extension]
	[Token(Token = "0x60002BB")]
	public static void Rename(InputAction action, string newName) { }

	[Address(RVA = "0x2900160", Offset = "0x28FF560", Length = "0x165")]
	[Extension]
	[Token(Token = "0x60002BF")]
	public static InputControlScheme WithBindingGroup(InputControlScheme scheme, string bindingGroup) { }

	[Address(RVA = "0x29002D0", Offset = "0x28FF6D0", Length = "0x225")]
	[Extension]
	[Token(Token = "0x60002C0")]
	public static InputControlScheme WithDevice(InputControlScheme scheme, string controlPath, bool required) { }

	[Address(RVA = "0x2900500", Offset = "0x28FF900", Length = "0x151")]
	[Extension]
	[Token(Token = "0x60002C2")]
	public static InputControlScheme WithOptionalDevice(InputControlScheme scheme, string controlPath) { }

	[Address(RVA = "0x2900660", Offset = "0x28FFA60", Length = "0x14E")]
	[Extension]
	[Token(Token = "0x60002C1")]
	public static InputControlScheme WithRequiredDevice(InputControlScheme scheme, string controlPath) { }

}

