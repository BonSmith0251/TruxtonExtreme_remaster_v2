namespace UnityEngine.InputSystem;

[Token(Token = "0x200001C")]
public sealed class InputAction : ICloneable, IDisposable
{
	[Flags]
	[Token(Token = "0x200001D")]
	public enum ActionFlags : int
	{
		WantsInitialStateCheck = 1,
	}

	[Token(Token = "0x200001E")]
	internal struct CallbackContext
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400009B")]
		internal InputActionState m_State; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400009C")]
		internal int m_ActionIndex; //Field offset: 0x8

		[Token(Token = "0x1700009F")]
		public InputAction action
		{
			[Address(RVA = "0x28D9120", Offset = "0x28D8520", Length = "0x4F")]
			[Token(Token = "0x6000179")]
			 get { } //Length: 79
		}

		[Token(Token = "0x17000097")]
		private int actionIndex
		{
			[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
			[Token(Token = "0x6000171")]
			private get { } //Length: 4
		}

		[Token(Token = "0x17000098")]
		private int bindingIndex
		{
			[Address(RVA = "0x28D9170", Offset = "0x28D8570", Length = "0x30")]
			[Token(Token = "0x6000172")]
			private get { } //Length: 48
		}

		[Token(Token = "0x1700009E")]
		public bool canceled
		{
			[Address(RVA = "0x28D91B0", Offset = "0x28D85B0", Length = "0x3F")]
			[Token(Token = "0x6000178")]
			 get { } //Length: 63
		}

		[Token(Token = "0x170000A0")]
		public InputControl control
		{
			[Address(RVA = "0x28D9230", Offset = "0x28D8630", Length = "0x6C")]
			[Token(Token = "0x600017A")]
			 get { } //Length: 108
		}

		[Token(Token = "0x17000099")]
		private int controlIndex
		{
			[Address(RVA = "0x28D91F0", Offset = "0x28D85F0", Length = "0x34")]
			[Token(Token = "0x6000173")]
			private get { } //Length: 52
		}

		[Token(Token = "0x170000A4")]
		public double duration
		{
			[Address(RVA = "0x28D92A0", Offset = "0x28D86A0", Length = "0x6F")]
			[Token(Token = "0x600017E")]
			 get { } //Length: 111
		}

		[Token(Token = "0x170000A1")]
		public IInputInteraction interaction
		{
			[Address(RVA = "0x28D9350", Offset = "0x28D8750", Length = "0x66")]
			[Token(Token = "0x600017B")]
			 get { } //Length: 102
		}

		[Token(Token = "0x1700009A")]
		private int interactionIndex
		{
			[Address(RVA = "0x28D9310", Offset = "0x28D8710", Length = "0x34")]
			[Token(Token = "0x6000174")]
			private get { } //Length: 52
		}

		[Token(Token = "0x1700009D")]
		public bool performed
		{
			[Address(RVA = "0x28D93C0", Offset = "0x28D87C0", Length = "0x3F")]
			[Token(Token = "0x6000177")]
			 get { } //Length: 63
		}

		[Token(Token = "0x1700009B")]
		public InputActionPhase phase
		{
			[Address(RVA = "0x28D9400", Offset = "0x28D8800", Length = "0x33")]
			[Token(Token = "0x6000175")]
			 get { } //Length: 51
		}

		[Token(Token = "0x1700009C")]
		public bool started
		{
			[Address(RVA = "0x28D9480", Offset = "0x28D8880", Length = "0x3F")]
			[Token(Token = "0x6000176")]
			 get { } //Length: 63
		}

		[Token(Token = "0x170000A3")]
		public double startTime
		{
			[Address(RVA = "0x28D9440", Offset = "0x28D8840", Length = "0x36")]
			[Token(Token = "0x600017D")]
			 get { } //Length: 54
		}

		[Token(Token = "0x170000A2")]
		public double time
		{
			[Address(RVA = "0x28D94C0", Offset = "0x28D88C0", Length = "0x36")]
			[Token(Token = "0x600017C")]
			 get { } //Length: 54
		}

		[Token(Token = "0x170000A6")]
		public int valueSizeInBytes
		{
			[Address(RVA = "0x28D9500", Offset = "0x28D8900", Length = "0x81")]
			[Token(Token = "0x6000180")]
			 get { } //Length: 129
		}

		[Token(Token = "0x170000A5")]
		public Type valueType
		{
			[Address(RVA = "0x28D9590", Offset = "0x28D8990", Length = "0x84")]
			[Token(Token = "0x600017F")]
			 get { } //Length: 132
		}

		[Address(RVA = "0x28D9120", Offset = "0x28D8520", Length = "0x4F")]
		[Token(Token = "0x6000179")]
		public InputAction get_action() { }

		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x6000171")]
		private int get_actionIndex() { }

		[Address(RVA = "0x28D9170", Offset = "0x28D8570", Length = "0x30")]
		[Token(Token = "0x6000172")]
		private int get_bindingIndex() { }

		[Address(RVA = "0x28D91B0", Offset = "0x28D85B0", Length = "0x3F")]
		[Token(Token = "0x6000178")]
		public bool get_canceled() { }

		[Address(RVA = "0x28D9230", Offset = "0x28D8630", Length = "0x6C")]
		[Token(Token = "0x600017A")]
		public InputControl get_control() { }

		[Address(RVA = "0x28D91F0", Offset = "0x28D85F0", Length = "0x34")]
		[Token(Token = "0x6000173")]
		private int get_controlIndex() { }

		[Address(RVA = "0x28D92A0", Offset = "0x28D86A0", Length = "0x6F")]
		[Token(Token = "0x600017E")]
		public double get_duration() { }

		[Address(RVA = "0x28D9350", Offset = "0x28D8750", Length = "0x66")]
		[Token(Token = "0x600017B")]
		public IInputInteraction get_interaction() { }

		[Address(RVA = "0x28D9310", Offset = "0x28D8710", Length = "0x34")]
		[Token(Token = "0x6000174")]
		private int get_interactionIndex() { }

		[Address(RVA = "0x28D93C0", Offset = "0x28D87C0", Length = "0x3F")]
		[Token(Token = "0x6000177")]
		public bool get_performed() { }

		[Address(RVA = "0x28D9400", Offset = "0x28D8800", Length = "0x33")]
		[Token(Token = "0x6000175")]
		public InputActionPhase get_phase() { }

		[Address(RVA = "0x28D9480", Offset = "0x28D8880", Length = "0x3F")]
		[Token(Token = "0x6000176")]
		public bool get_started() { }

		[Address(RVA = "0x28D9440", Offset = "0x28D8840", Length = "0x36")]
		[Token(Token = "0x600017D")]
		public double get_startTime() { }

		[Address(RVA = "0x28D94C0", Offset = "0x28D88C0", Length = "0x36")]
		[Token(Token = "0x600017C")]
		public double get_time() { }

		[Address(RVA = "0x28D9500", Offset = "0x28D8900", Length = "0x81")]
		[Token(Token = "0x6000180")]
		public int get_valueSizeInBytes() { }

		[Address(RVA = "0x28D9590", Offset = "0x28D8990", Length = "0x84")]
		[Token(Token = "0x600017F")]
		public Type get_valueType() { }

		[Address(RVA = "0x28D8BB0", Offset = "0x28D7FB0", Length = "0x1EE")]
		[Token(Token = "0x6000181")]
		public void ReadValue(Void* buffer, int bufferSize) { }

		[Address(RVA = "0x9F0D10", Offset = "0x9F0110", Length = "0xC5")]
		[Token(Token = "0x6000182")]
		public TValue ReadValue() { }

		[Address(RVA = "0x28D8A30", Offset = "0x28D7E30", Length = "0xB2")]
		[Token(Token = "0x6000183")]
		public bool ReadValueAsButton() { }

		[Address(RVA = "0x28D8AF0", Offset = "0x28D7EF0", Length = "0xB5")]
		[Token(Token = "0x6000184")]
		public object ReadValueAsObject() { }

		[Address(RVA = "0x28D8DA0", Offset = "0x28D81A0", Length = "0x375")]
		[Token(Token = "0x6000185")]
		public virtual string ToString() { }

	}

	[Token(Token = "0x4000085")]
	private static readonly ProfilerMarker k_InputActionEnableProfilerMarker; //Field offset: 0x0
	[Token(Token = "0x4000086")]
	private static readonly ProfilerMarker k_InputActionDisableProfilerMarker; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000087")]
	[Tooltip("Human readable name of the action. Must be unique within its action map (case is ignored). Can be changed without breaking references to the action.")]
	internal string m_Name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000088")]
	[Tooltip("Determines how the action triggers.\n\nA Value action will start and perform when a control moves from its default value and then perform on every value change. It will cancel when controls go back to default value. Also, when enabled, a Value action will respond right away to a control's current value.\n\nA Button action will start when a button is pressed and perform when the press threshold (see 'Default Button Press Point' in settings) is reached. It will cancel when the button is going below the release threshold (see 'Button Release Threshold' in settings). Also, if a button is already pressed when the action is enabled, the button has to be released first.\n\nA Pass-Through action will not explicitly start and will never cancel. Instead, for every value change on any bound control, the action will perform.")]
	internal InputActionType m_Type; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("m_ExpectedControlLayout")]
	[SerializeField]
	[Token(Token = "0x4000089")]
	[Tooltip("The type of control expected by the action (e.g. \"Digital\" for buttons, \"Vector2\" for sticks). This will limit the controls shown when setting up bindings in the UI and will also limit which controls can be bound interactively to the action.")]
	internal string m_ExpectedControlType; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400008A")]
	[Tooltip("Unique ID of the action (GUID). Used to reference the action from bindings such that actions can be renamed without breaking references.")]
	internal string m_Id; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400008B")]
	internal string m_Processors; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x400008C")]
	internal string m_Interactions; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400008D")]
	internal InputBinding[] m_SingletonActionBindings; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x400008E")]
	internal ActionFlags m_Flags; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400008F")]
	internal Nullable<InputBinding> m_BindingMask; //Field offset: 0x50
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000090")]
	internal int m_BindingsStartIndex; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x4000091")]
	internal int m_BindingsCount; //Field offset: 0xB4
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000092")]
	internal int m_ControlStartIndex; //Field offset: 0xB8
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x4000093")]
	internal int m_ControlCount; //Field offset: 0xBC
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000094")]
	internal int m_ActionIndexInState; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000095")]
	internal InputActionMap m_ActionMap; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000096")]
	internal CallbackArray<Action`1<CallbackContext>> m_OnStarted; //Field offset: 0xD0
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000097")]
	internal CallbackArray<Action`1<CallbackContext>> m_OnCanceled; //Field offset: 0x120
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x4000098")]
	internal CallbackArray<Action`1<CallbackContext>> m_OnPerformed; //Field offset: 0x170

	[Token(Token = "0x14000002")]
	public event Action<CallbackContext> canceled
	{
		[Address(RVA = "0x28E9610", Offset = "0x28E8A10", Length = "0x4C")]
		[Token(Token = "0x6000144")]
		 add { } //Length: 76
		[Address(RVA = "0x28E9D40", Offset = "0x28E9140", Length = "0x4C")]
		[Token(Token = "0x6000145")]
		 remove { } //Length: 76
	}

	[Token(Token = "0x14000003")]
	public event Action<CallbackContext> performed
	{
		[Address(RVA = "0x28E9660", Offset = "0x28E8A60", Length = "0x4C")]
		[Token(Token = "0x6000146")]
		 add { } //Length: 76
		[Address(RVA = "0x28E9D90", Offset = "0x28E9190", Length = "0x4C")]
		[Token(Token = "0x6000147")]
		 remove { } //Length: 76
	}

	[Token(Token = "0x14000001")]
	public event Action<CallbackContext> started
	{
		[Address(RVA = "0x28E96B0", Offset = "0x28E8AB0", Length = "0x4C")]
		[Token(Token = "0x6000142")]
		 add { } //Length: 76
		[Address(RVA = "0x28E9DE0", Offset = "0x28E91E0", Length = "0x4C")]
		[Token(Token = "0x6000143")]
		 remove { } //Length: 76
	}

	[Token(Token = "0x1700008A")]
	public InputActionMap actionMap
	{
		[Address(RVA = "0x28E9700", Offset = "0x28E8B00", Length = "0x1A")]
		[Token(Token = "0x600013A")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000092")]
	public InputControl activeControl
	{
		[Address(RVA = "0x28E9720", Offset = "0x28E8B20", Length = "0x7E")]
		[Token(Token = "0x6000149")]
		 get { } //Length: 126
	}

	[Token(Token = "0x17000093")]
	public Type activeValueType
	{
		[Address(RVA = "0x28E97A0", Offset = "0x28E8BA0", Length = "0x78")]
		[Token(Token = "0x600014A")]
		 get { } //Length: 120
	}

	[Token(Token = "0x1700008B")]
	public Nullable<InputBinding> bindingMask
	{
		[Address(RVA = "0x28E9820", Offset = "0x28E8C20", Length = "0x3C")]
		[Token(Token = "0x600013B")]
		 get { } //Length: 60
		[Address(RVA = "0x28E9E30", Offset = "0x28E9230", Length = "0x2C1")]
		[Token(Token = "0x600013C")]
		 set { } //Length: 705
	}

	[Token(Token = "0x1700008C")]
	public ReadOnlyArray<InputBinding> bindings
	{
		[Address(RVA = "0x28E9860", Offset = "0x28E8C60", Length = "0xB1")]
		[Token(Token = "0x600013D")]
		 get { } //Length: 177
	}

	[Token(Token = "0x1700008D")]
	public ReadOnlyArray<InputControl> controls
	{
		[Address(RVA = "0x28E9920", Offset = "0x28E8D20", Length = "0xDC")]
		[Token(Token = "0x600013E")]
		 get { } //Length: 220
	}

	[Token(Token = "0x17000096")]
	private TriggerState currentState
	{
		[Address(RVA = "0x28E9A00", Offset = "0x28E8E00", Length = "0x81")]
		[Token(Token = "0x6000166")]
		private get { } //Length: 129
	}

	[Token(Token = "0x17000090")]
	public bool enabled
	{
		[Address(RVA = "0x28E9A90", Offset = "0x28E8E90", Length = "0x57")]
		[Token(Token = "0x6000141")]
		 get { } //Length: 87
	}

	[Token(Token = "0x17000087")]
	public string expectedControlType
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000136")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x6000137")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000085")]
	public Guid id
	{
		[Address(RVA = "0x28E9B40", Offset = "0x28E8F40", Length = "0x7A")]
		[Token(Token = "0x6000134")]
		 get { } //Length: 122
	}

	[Token(Token = "0x17000086")]
	internal Guid idDontGenerate
	{
		[Address(RVA = "0x28E9AF0", Offset = "0x28E8EF0", Length = "0x4E")]
		[Token(Token = "0x6000135")]
		internal get { } //Length: 78
	}

	[Token(Token = "0x1700008F")]
	public bool inProgress
	{
		[Address(RVA = "0x28E9BC0", Offset = "0x28E8FC0", Length = "0x5F")]
		[Token(Token = "0x6000140")]
		 get { } //Length: 95
	}

	[Token(Token = "0x17000089")]
	public string interactions
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000139")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000095")]
	internal bool isSingletonAction
	{
		[Address(RVA = "0x28E9C20", Offset = "0x28E9020", Length = "0x1C")]
		[Token(Token = "0x6000165")]
		internal get { } //Length: 28
	}

	[Token(Token = "0x17000083")]
	public string name
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000132")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700008E")]
	public InputActionPhase phase
	{
		[Address(RVA = "0x28E9C40", Offset = "0x28E9040", Length = "0x53")]
		[Token(Token = "0x600013F")]
		 get { } //Length: 83
	}

	[Token(Token = "0x17000088")]
	public string processors
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000138")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000091")]
	public bool triggered
	{
		[Address(RVA = "0x28E9CA0", Offset = "0x28E90A0", Length = "0x89")]
		[Token(Token = "0x6000148")]
		 get { } //Length: 137
	}

	[Token(Token = "0x17000084")]
	public InputActionType type
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000133")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000094")]
	public bool wantsInitialStateCheck
	{
		[Address(RVA = "0x28E9D30", Offset = "0x28E9130", Length = "0x10")]
		[Token(Token = "0x600014B")]
		 get { } //Length: 16
		[Address(RVA = "0x28EA100", Offset = "0x28E9500", Length = "0x19")]
		[Token(Token = "0x600014C")]
		 set { } //Length: 25
	}

	[Address(RVA = "0x28E92D0", Offset = "0x28E86D0", Length = "0x98")]
	[Token(Token = "0x6000170")]
	private static InputAction() { }

	[Address(RVA = "0x28E93D0", Offset = "0x28E87D0", Length = "0x237")]
	[Token(Token = "0x600014E")]
	public InputAction(string name = null, InputActionType type = 0, string binding = null, string interactions = null, string processors = null, string expectedControlType = null) { }

	[Address(RVA = "0x28E9370", Offset = "0x28E8770", Length = "0x58")]
	[Token(Token = "0x600014D")]
	public InputAction() { }

	[Address(RVA = "0x28E7A90", Offset = "0x28E6E90", Length = "0x18D")]
	[Token(Token = "0x600016C")]
	internal bool ActiveControlIsValid(InputControl control) { }

	[Address(RVA = "0x28E9610", Offset = "0x28E8A10", Length = "0x4C")]
	[Token(Token = "0x6000144")]
	public void add_canceled(Action<CallbackContext> value) { }

	[Address(RVA = "0x28E9660", Offset = "0x28E8A60", Length = "0x4C")]
	[Token(Token = "0x6000146")]
	public void add_performed(Action<CallbackContext> value) { }

	[Address(RVA = "0x28E96B0", Offset = "0x28E8AB0", Length = "0x4C")]
	[Token(Token = "0x6000142")]
	public void add_started(Action<CallbackContext> value) { }

	[Address(RVA = "0x28E7C20", Offset = "0x28E7020", Length = "0x188")]
	[Token(Token = "0x600016E")]
	internal int BindingIndexOnActionToBindingIndexOnMap(int indexOfBindingOnAction) { }

	[Address(RVA = "0x28E7DB0", Offset = "0x28E71B0", Length = "0xCB")]
	[Token(Token = "0x600016F")]
	internal int BindingIndexOnMapToBindingIndexOnAction(int indexOfBindingOnMap) { }

	[Address(RVA = "0x28E7E80", Offset = "0x28E7280", Length = "0x18F")]
	[Token(Token = "0x6000153")]
	public InputAction Clone() { }

	[Address(RVA = "0x28E8010", Offset = "0x28E7410", Length = "0xE8")]
	[Token(Token = "0x600016A")]
	private void CreateInternalActionMapForSingletonAction() { }

	[Address(RVA = "0x28E8100", Offset = "0x28E7500", Length = "0x16B")]
	[Token(Token = "0x6000152")]
	public void Disable() { }

	[Address(RVA = "0x28E8270", Offset = "0x28E7670", Length = "0x1D")]
	[Token(Token = "0x600014F")]
	public override void Dispose() { }

	[Address(RVA = "0x28E8290", Offset = "0x28E7690", Length = "0x197")]
	[Token(Token = "0x6000151")]
	public void Enable() { }

	[Address(RVA = "0x28E8430", Offset = "0x28E7830", Length = "0x69")]
	[Token(Token = "0x600015B")]
	private int ExpectedFrame() { }

	[Address(RVA = "0x28E84A0", Offset = "0x28E78A0", Length = "0x123")]
	[Token(Token = "0x600016D")]
	internal Nullable<InputBinding> FindEffectiveBindingMask() { }

	[Address(RVA = "0x28E85D0", Offset = "0x28E79D0", Length = "0x47")]
	[Token(Token = "0x6000168")]
	internal void GenerateId() { }

	[Address(RVA = "0x28E9700", Offset = "0x28E8B00", Length = "0x1A")]
	[Token(Token = "0x600013A")]
	public InputActionMap get_actionMap() { }

	[Address(RVA = "0x28E9720", Offset = "0x28E8B20", Length = "0x7E")]
	[Token(Token = "0x6000149")]
	public InputControl get_activeControl() { }

	[Address(RVA = "0x28E97A0", Offset = "0x28E8BA0", Length = "0x78")]
	[Token(Token = "0x600014A")]
	public Type get_activeValueType() { }

	[Address(RVA = "0x28E9820", Offset = "0x28E8C20", Length = "0x3C")]
	[Token(Token = "0x600013B")]
	public Nullable<InputBinding> get_bindingMask() { }

	[Address(RVA = "0x28E9860", Offset = "0x28E8C60", Length = "0xB1")]
	[Token(Token = "0x600013D")]
	public ReadOnlyArray<InputBinding> get_bindings() { }

	[Address(RVA = "0x28E9920", Offset = "0x28E8D20", Length = "0xDC")]
	[Token(Token = "0x600013E")]
	public ReadOnlyArray<InputControl> get_controls() { }

	[Address(RVA = "0x28E9A00", Offset = "0x28E8E00", Length = "0x81")]
	[Token(Token = "0x6000166")]
	private TriggerState get_currentState() { }

	[Address(RVA = "0x28E9A90", Offset = "0x28E8E90", Length = "0x57")]
	[Token(Token = "0x6000141")]
	public bool get_enabled() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000136")]
	public string get_expectedControlType() { }

	[Address(RVA = "0x28E9B40", Offset = "0x28E8F40", Length = "0x7A")]
	[Token(Token = "0x6000134")]
	public Guid get_id() { }

	[Address(RVA = "0x28E9AF0", Offset = "0x28E8EF0", Length = "0x4E")]
	[Token(Token = "0x6000135")]
	internal Guid get_idDontGenerate() { }

	[Address(RVA = "0x28E9BC0", Offset = "0x28E8FC0", Length = "0x5F")]
	[Token(Token = "0x6000140")]
	public bool get_inProgress() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000139")]
	public string get_interactions() { }

	[Address(RVA = "0x28E9C20", Offset = "0x28E9020", Length = "0x1C")]
	[Token(Token = "0x6000165")]
	internal bool get_isSingletonAction() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000132")]
	public string get_name() { }

	[Address(RVA = "0x28E9C40", Offset = "0x28E9040", Length = "0x53")]
	[Token(Token = "0x600013F")]
	public InputActionPhase get_phase() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000138")]
	public string get_processors() { }

	[Address(RVA = "0x28E9CA0", Offset = "0x28E90A0", Length = "0x89")]
	[Token(Token = "0x6000148")]
	public bool get_triggered() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000133")]
	public InputActionType get_type() { }

	[Address(RVA = "0x28E9D30", Offset = "0x28E9130", Length = "0x10")]
	[Token(Token = "0x600014B")]
	public bool get_wantsInitialStateCheck() { }

	[Address(RVA = "0x28E8620", Offset = "0x28E7A20", Length = "0x5A")]
	[Token(Token = "0x6000157")]
	public float GetControlMagnitude() { }

	[Address(RVA = "0x28E8680", Offset = "0x28E7A80", Length = "0xFE")]
	[Token(Token = "0x6000169")]
	internal InputActionMap GetOrCreateActionMap() { }

	[Address(RVA = "0x28E8780", Offset = "0x28E7B80", Length = "0x188")]
	[Token(Token = "0x6000164")]
	public float GetTimeoutCompletionPercentage() { }

	[Address(RVA = "0x28E8910", Offset = "0x28E7D10", Length = "0x4D")]
	[Token(Token = "0x600015A")]
	public bool IsInProgress() { }

	[Address(RVA = "0x28E8960", Offset = "0x28E7D60", Length = "0x4C")]
	[Token(Token = "0x6000159")]
	public bool IsPressed() { }

	[Address(RVA = "0x28E89B0", Offset = "0x28E7DB0", Length = "0x5A")]
	[Token(Token = "0x6000167")]
	internal string MakeSureIdIsInPlace() { }

	[Address(RVA = "0x8381F0", Offset = "0x8375F0", Length = "0xE6")]
	[Token(Token = "0x6000155")]
	public TValue ReadValue() { }

	[Address(RVA = "0x28E8A10", Offset = "0x28E7E10", Length = "0x90")]
	[Token(Token = "0x6000156")]
	public object ReadValueAsObject() { }

	[Address(RVA = "0x28E9D40", Offset = "0x28E9140", Length = "0x4C")]
	[Token(Token = "0x6000145")]
	public void remove_canceled(Action<CallbackContext> value) { }

	[Address(RVA = "0x28E9D90", Offset = "0x28E9190", Length = "0x4C")]
	[Token(Token = "0x6000147")]
	public void remove_performed(Action<CallbackContext> value) { }

	[Address(RVA = "0x28E9DE0", Offset = "0x28E91E0", Length = "0x4C")]
	[Token(Token = "0x6000143")]
	public void remove_started(Action<CallbackContext> value) { }

	[Address(RVA = "0x28E8AB0", Offset = "0x28E7EB0", Length = "0x39")]
	[Token(Token = "0x600016B")]
	internal void RequestInitialStateCheckOnEnabledAction() { }

	[Address(RVA = "0x28E8AF0", Offset = "0x28E7EF0", Length = "0x9A")]
	[Token(Token = "0x6000158")]
	public void Reset() { }

	[Address(RVA = "0x28E9E30", Offset = "0x28E9230", Length = "0x2C1")]
	[Token(Token = "0x600013C")]
	public void set_bindingMask(Nullable<InputBinding> value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6000137")]
	public void set_expectedControlType(string value) { }

	[Address(RVA = "0x28EA100", Offset = "0x28E9500", Length = "0x19")]
	[Token(Token = "0x600014C")]
	public void set_wantsInitialStateCheck(bool value) { }

	[Address(RVA = "0x28E7E80", Offset = "0x28E7280", Length = "0x18F")]
	[Token(Token = "0x6000154")]
	private override object System.ICloneable.Clone() { }

	[Address(RVA = "0x28E8B90", Offset = "0x28E7F90", Length = "0x333")]
	[Token(Token = "0x6000150")]
	public virtual string ToString() { }

	[Address(RVA = "0x28E8ED0", Offset = "0x28E82D0", Length = "0x60")]
	[Token(Token = "0x6000163")]
	public bool WasCompletedThisDynamicUpdate() { }

	[Address(RVA = "0x28E8F40", Offset = "0x28E8340", Length = "0x80")]
	[Token(Token = "0x6000162")]
	public bool WasCompletedThisFrame() { }

	[Address(RVA = "0x28E8FD0", Offset = "0x28E83D0", Length = "0x60")]
	[Token(Token = "0x6000161")]
	public bool WasPerformedThisDynamicUpdate() { }

	[Address(RVA = "0x28E9040", Offset = "0x28E8440", Length = "0x89")]
	[Token(Token = "0x6000160")]
	public bool WasPerformedThisFrame() { }

	[Address(RVA = "0x28E90D0", Offset = "0x28E84D0", Length = "0x60")]
	[Token(Token = "0x600015D")]
	public bool WasPressedThisDynamicUpdate() { }

	[Address(RVA = "0x28E9140", Offset = "0x28E8540", Length = "0x89")]
	[Token(Token = "0x600015C")]
	public bool WasPressedThisFrame() { }

	[Address(RVA = "0x28E91D0", Offset = "0x28E85D0", Length = "0x60")]
	[Token(Token = "0x600015F")]
	public bool WasReleasedThisDynamicUpdate() { }

	[Address(RVA = "0x28E9240", Offset = "0x28E8640", Length = "0x80")]
	[Token(Token = "0x600015E")]
	public bool WasReleasedThisFrame() { }

}

