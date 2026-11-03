namespace UnityEngine.InputSystem;

[Token(Token = "0x200005E")]
public struct InputControlScheme : IEquatable<InputControlScheme>
{
	[Token(Token = "0x2000063")]
	internal struct DeviceRequirement : IEquatable<DeviceRequirement>
	{
		[Flags]
		[Token(Token = "0x2000064")]
		public enum Flags : int
		{
			None = 0,
			Optional = 1,
			Or = 2,
		}

		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Token(Token = "0x4000243")]
		internal string m_ControlPath; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		[Token(Token = "0x4000244")]
		internal Flags m_Flags; //Field offset: 0x8

		[Token(Token = "0x17000155")]
		public string controlPath
		{
			[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
			[Token(Token = "0x600046A")]
			 get { } //Length: 4
			[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
			[Token(Token = "0x600046B")]
			 set { } //Length: 8
		}

		[Token(Token = "0x17000157")]
		public bool isAND
		{
			[Address(RVA = "0x292D520", Offset = "0x292C920", Length = "0x8")]
			[Token(Token = "0x600046E")]
			 get { } //Length: 8
			[Address(RVA = "0x292D620", Offset = "0x292CA20", Length = "0x19")]
			[Token(Token = "0x600046F")]
			 set { } //Length: 25
		}

		[Token(Token = "0x17000156")]
		public bool isOptional
		{
			[Address(RVA = "0x292D540", Offset = "0x292C940", Length = "0x7")]
			[Token(Token = "0x600046C")]
			 get { } //Length: 7
			[Address(RVA = "0x292D660", Offset = "0x292CA60", Length = "0x19")]
			[Token(Token = "0x600046D")]
			 set { } //Length: 25
		}

		[Token(Token = "0x17000158")]
		public bool isOR
		{
			[Address(RVA = "0x292D530", Offset = "0x292C930", Length = "0x8")]
			[Token(Token = "0x6000470")]
			 get { } //Length: 8
			[Address(RVA = "0x292D640", Offset = "0x292CA40", Length = "0x19")]
			[Token(Token = "0x6000471")]
			 set { } //Length: 25
		}

		[Address(RVA = "0x292D280", Offset = "0x292C680", Length = "0x5F")]
		[Token(Token = "0x6000473")]
		public override bool Equals(DeviceRequirement other) { }

		[Address(RVA = "0x292D2E0", Offset = "0x292C6E0", Length = "0xCB")]
		[Token(Token = "0x6000474")]
		public virtual bool Equals(object obj) { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x600046A")]
		public string get_controlPath() { }

		[Address(RVA = "0x292D520", Offset = "0x292C920", Length = "0x8")]
		[Token(Token = "0x600046E")]
		public bool get_isAND() { }

		[Address(RVA = "0x292D540", Offset = "0x292C940", Length = "0x7")]
		[Token(Token = "0x600046C")]
		public bool get_isOptional() { }

		[Address(RVA = "0x292D530", Offset = "0x292C930", Length = "0x8")]
		[Token(Token = "0x6000470")]
		public bool get_isOR() { }

		[Address(RVA = "0x292D3B0", Offset = "0x292C7B0", Length = "0xC1")]
		[Token(Token = "0x6000475")]
		public virtual int GetHashCode() { }

		[Address(RVA = "0x292D550", Offset = "0x292C950", Length = "0x61")]
		[Token(Token = "0x6000476")]
		public static bool op_Equality(DeviceRequirement left, DeviceRequirement right) { }

		[Address(RVA = "0x292D5C0", Offset = "0x292C9C0", Length = "0x5D")]
		[Token(Token = "0x6000477")]
		public static bool op_Inequality(DeviceRequirement left, DeviceRequirement right) { }

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x600046B")]
		public void set_controlPath(string value) { }

		[Address(RVA = "0x292D620", Offset = "0x292CA20", Length = "0x19")]
		[Token(Token = "0x600046F")]
		public void set_isAND(bool value) { }

		[Address(RVA = "0x292D660", Offset = "0x292CA60", Length = "0x19")]
		[Token(Token = "0x600046D")]
		public void set_isOptional(bool value) { }

		[Address(RVA = "0x292D640", Offset = "0x292CA40", Length = "0x19")]
		[Token(Token = "0x6000471")]
		public void set_isOR(bool value) { }

		[Address(RVA = "0x292D480", Offset = "0x292C880", Length = "0x98")]
		[Token(Token = "0x6000472")]
		public virtual string ToString() { }

	}

	[DefaultMember("Item")]
	[Token(Token = "0x200005F")]
	internal struct MatchResult : IEnumerable<Match>, IEnumerable, IDisposable
	{
		[Token(Token = "0x2000062")]
		private struct Enumerator : IEnumerator<Match>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000240")]
			internal int m_Index; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4000241")]
			internal DeviceRequirement[] m_Requirements; //Field offset: 0x8
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000242")]
			internal InputControlList<InputControl> m_Controls; //Field offset: 0x10

			[Token(Token = "0x17000153")]
			public override Match Current
			{
				[Address(RVA = "0x292D720", Offset = "0x292CB20", Length = "0xB0")]
				[Token(Token = "0x6000467")]
				 get { } //Length: 176
			}

			[Token(Token = "0x17000154")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x292D6B0", Offset = "0x292CAB0", Length = "0x6C")]
				[Token(Token = "0x6000468")]
				private get { } //Length: 108
			}

			[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
			[Token(Token = "0x6000469")]
			public override void Dispose() { }

			[Address(RVA = "0x292D720", Offset = "0x292CB20", Length = "0xB0")]
			[Token(Token = "0x6000467")]
			public override Match get_Current() { }

			[Address(RVA = "0x292D680", Offset = "0x292CA80", Length = "0x19")]
			[Token(Token = "0x6000465")]
			public override bool MoveNext() { }

			[Address(RVA = "0x292D6A0", Offset = "0x292CAA0", Length = "0x7")]
			[Token(Token = "0x6000466")]
			public override void Reset() { }

			[Address(RVA = "0x292D6B0", Offset = "0x292CAB0", Length = "0x6C")]
			[Token(Token = "0x6000468")]
			private override object System.Collections.IEnumerator.get_Current() { }

		}

		[Token(Token = "0x2000061")]
		internal struct Match
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400023D")]
			internal int m_RequirementIndex; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x400023E")]
			internal DeviceRequirement[] m_Requirements; //Field offset: 0x8
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400023F")]
			internal InputControlList<InputControl> m_Controls; //Field offset: 0x10

			[Token(Token = "0x1700014E")]
			public InputControl control
			{
				[Address(RVA = "0x29415C0", Offset = "0x29409C0", Length = "0x3C")]
				[Token(Token = "0x6000460")]
				 get { } //Length: 60
			}

			[Token(Token = "0x1700014F")]
			public InputDevice device
			{
				[Address(RVA = "0x2941600", Offset = "0x2940A00", Length = "0x4C")]
				[Token(Token = "0x6000461")]
				 get { } //Length: 76
			}

			[Token(Token = "0x17000152")]
			public bool isOptional
			{
				[Address(RVA = "0x2941650", Offset = "0x2940A50", Length = "0x35")]
				[Token(Token = "0x6000464")]
				 get { } //Length: 53
			}

			[Token(Token = "0x17000151")]
			public DeviceRequirement requirement
			{
				[Address(RVA = "0x2941690", Offset = "0x2940A90", Length = "0x38")]
				[Token(Token = "0x6000463")]
				 get { } //Length: 56
			}

			[Token(Token = "0x17000150")]
			public int requirementIndex
			{
				[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
				[Token(Token = "0x6000462")]
				 get { } //Length: 3
			}

			[Address(RVA = "0x29415C0", Offset = "0x29409C0", Length = "0x3C")]
			[Token(Token = "0x6000460")]
			public InputControl get_control() { }

			[Address(RVA = "0x2941600", Offset = "0x2940A00", Length = "0x4C")]
			[Token(Token = "0x6000461")]
			public InputDevice get_device() { }

			[Address(RVA = "0x2941650", Offset = "0x2940A50", Length = "0x35")]
			[Token(Token = "0x6000464")]
			public bool get_isOptional() { }

			[Address(RVA = "0x2941690", Offset = "0x2940A90", Length = "0x38")]
			[Token(Token = "0x6000463")]
			public DeviceRequirement get_requirement() { }

			[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
			[Token(Token = "0x6000462")]
			public int get_requirementIndex() { }

		}

		[Token(Token = "0x2000060")]
		public enum Result : int
		{
			AllSatisfied = 0,
			MissingRequired = 1,
			MissingOptional = 2,
		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000234")]
		internal Result m_Result; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000235")]
		internal float m_Score; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000236")]
		internal InputControlList<InputDevice> m_Devices; //Field offset: 0x8
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000237")]
		internal InputControlList<InputControl> m_Controls; //Field offset: 0x28
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000238")]
		internal DeviceRequirement[] m_Requirements; //Field offset: 0x48

		[Token(Token = "0x1700014C")]
		public InputControlList<InputDevice> devices
		{
			[Address(RVA = "0x2941450", Offset = "0x2940850", Length = "0x140")]
			[Token(Token = "0x600045B")]
			 get { } //Length: 320
		}

		[Token(Token = "0x1700014B")]
		public bool hasMissingOptionalDevices
		{
			[Address(RVA = "0x2941590", Offset = "0x2940990", Length = "0x7")]
			[Token(Token = "0x600045A")]
			 get { } //Length: 7
		}

		[Token(Token = "0x1700014A")]
		public bool hasMissingRequiredDevices
		{
			[Address(RVA = "0x29415A0", Offset = "0x29409A0", Length = "0x7")]
			[Token(Token = "0x6000459")]
			 get { } //Length: 7
		}

		[Token(Token = "0x17000149")]
		public bool isSuccessfulMatch
		{
			[Address(RVA = "0x29415B0", Offset = "0x29409B0", Length = "0x7")]
			[Token(Token = "0x6000458")]
			 get { } //Length: 7
		}

		[Token(Token = "0x1700014D")]
		public Match Item
		{
			[Address(RVA = "0x29413A0", Offset = "0x29407A0", Length = "0xAE")]
			[Token(Token = "0x600045C")]
			 get { } //Length: 174
		}

		[Token(Token = "0x17000148")]
		public float score
		{
			[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
			[Token(Token = "0x6000457")]
			 get { } //Length: 388
		}

		[Address(RVA = "0x2941290", Offset = "0x2940690", Length = "0x56")]
		[Token(Token = "0x600045F")]
		public override void Dispose() { }

		[Address(RVA = "0x2941450", Offset = "0x2940850", Length = "0x140")]
		[Token(Token = "0x600045B")]
		public InputControlList<InputDevice> get_devices() { }

		[Address(RVA = "0x2941590", Offset = "0x2940990", Length = "0x7")]
		[Token(Token = "0x600045A")]
		public bool get_hasMissingOptionalDevices() { }

		[Address(RVA = "0x29415A0", Offset = "0x29409A0", Length = "0x7")]
		[Token(Token = "0x6000459")]
		public bool get_hasMissingRequiredDevices() { }

		[Address(RVA = "0x29415B0", Offset = "0x29409B0", Length = "0x7")]
		[Token(Token = "0x6000458")]
		public bool get_isSuccessfulMatch() { }

		[Address(RVA = "0x29413A0", Offset = "0x29407A0", Length = "0xAE")]
		[Token(Token = "0x600045C")]
		public Match get_Item(int index) { }

		[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
		[Token(Token = "0x6000457")]
		public float get_score() { }

		[Address(RVA = "0x29412F0", Offset = "0x29406F0", Length = "0x9F")]
		[Token(Token = "0x600045D")]
		public override IEnumerator<Match> GetEnumerator() { }

		[Address(RVA = "0x2941390", Offset = "0x2940790", Length = "0x7")]
		[Token(Token = "0x600045E")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[Token(Token = "0x2000065")]
	public struct SchemeJson
	{
		[Token(Token = "0x2000066")]
		internal struct DeviceJson
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400024C")]
			public string devicePath; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x400024D")]
			public bool isOptional; //Field offset: 0x8
			[FieldOffset(Offset = "0x9")]
			[Token(Token = "0x400024E")]
			public bool isOR; //Field offset: 0x9

			[Address(RVA = "0x292D1D0", Offset = "0x292C5D0", Length = "0x45")]
			[Token(Token = "0x600047D")]
			public static DeviceJson From(DeviceRequirement requirement) { }

			[Address(RVA = "0x292D220", Offset = "0x292C620", Length = "0x58")]
			[Token(Token = "0x600047C")]
			public DeviceRequirement ToDeviceEntry() { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000249")]
		public string name; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400024A")]
		public string bindingGroup; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400024B")]
		public DeviceJson[] devices; //Field offset: 0x10

		[Address(RVA = "0x2942EC0", Offset = "0x29422C0", Length = "0x1F9")]
		[Token(Token = "0x6000479")]
		public static SchemeJson ToJson(InputControlScheme scheme) { }

		[Address(RVA = "0x29430C0", Offset = "0x29424C0", Length = "0x30B")]
		[Token(Token = "0x600047A")]
		public static SchemeJson[] ToJson(InputControlScheme[] schemes) { }

		[Address(RVA = "0x29433D0", Offset = "0x29427D0", Length = "0x1D3")]
		[Token(Token = "0x6000478")]
		public InputControlScheme ToScheme() { }

		[Address(RVA = "0x29435B0", Offset = "0x29429B0", Length = "0x116")]
		[Token(Token = "0x600047B")]
		public static InputControlScheme[] ToSchemes(SchemeJson[] schemes) { }

	}

	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000231")]
	internal string m_Name; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x4000232")]
	internal string m_BindingGroup; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000233")]
	internal DeviceRequirement[] m_DeviceRequirements; //Field offset: 0x10

	[Token(Token = "0x17000146")]
	public string bindingGroup
	{
		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[Token(Token = "0x6000447")]
		 get { } //Length: 5
		[Address(RVA = "0x17CB540", Offset = "0x17CA940", Length = "0xD")]
		[Token(Token = "0x6000448")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000147")]
	public ReadOnlyArray<DeviceRequirement> deviceRequirements
	{
		[Address(RVA = "0x29366B0", Offset = "0x2935AB0", Length = "0x53")]
		[Token(Token = "0x6000449")]
		 get { } //Length: 83
	}

	[Token(Token = "0x17000145")]
	public string name
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x6000446")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2936590", Offset = "0x2935990", Length = "0x11D")]
	[Token(Token = "0x600044A")]
	public InputControlScheme(string name, IEnumerable<DeviceRequirement> devices = null, string bindingGroup = null) { }

	[Address(RVA = "0x29360C0", Offset = "0x29354C0", Length = "0x9B")]
	[Token(Token = "0x6000452")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2935E40", Offset = "0x2935240", Length = "0x27C")]
	[Token(Token = "0x6000451")]
	public override bool Equals(InputControlScheme other) { }

	[Address(RVA = "0x83D600", Offset = "0x83CA00", Length = "0x21E")]
	[Token(Token = "0x600044E")]
	public static Nullable<InputControlScheme> FindControlSchemeForDevice(InputDevice device, TSchemes schemes) { }

	[Address(RVA = "0x83E410", Offset = "0x83D810", Length = "0x137")]
	[Token(Token = "0x600044C")]
	public static Nullable<InputControlScheme> FindControlSchemeForDevices(TDevices devices, TSchemes schemes, InputDevice mustIncludeDevice = null, bool allowUnsuccesfulMatch = false) { }

	[Address(RVA = "0x83E550", Offset = "0x83D950", Length = "0x70B")]
	[Token(Token = "0x600044D")]
	public static bool FindControlSchemeForDevices(TDevices devices, TSchemes schemes, out InputControlScheme controlScheme, out MatchResult matchResult, InputDevice mustIncludeDevice = null, bool allowUnsuccessfulMatch = false) { }

	[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
	[Token(Token = "0x6000447")]
	public string get_bindingGroup() { }

	[Address(RVA = "0x29366B0", Offset = "0x2935AB0", Length = "0x53")]
	[Token(Token = "0x6000449")]
	public ReadOnlyArray<DeviceRequirement> get_deviceRequirements() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6000446")]
	public string get_name() { }

	[Address(RVA = "0x2936160", Offset = "0x2935560", Length = "0xA1")]
	[Token(Token = "0x6000453")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2936710", Offset = "0x2935B10", Length = "0x29")]
	[Token(Token = "0x6000455")]
	public static bool op_Equality(InputControlScheme left, InputControlScheme right) { }

	[Address(RVA = "0x2936740", Offset = "0x2935B40", Length = "0x2B")]
	[Token(Token = "0x6000456")]
	public static bool op_Inequality(InputControlScheme left, InputControlScheme right) { }

	[Address(RVA = "0x840540", Offset = "0x83F940", Length = "0x79E")]
	[Token(Token = "0x6000450")]
	public MatchResult PickDevicesFrom(TDevices devices, InputDevice favorDevice = null) { }

	[Address(RVA = "0x17CB540", Offset = "0x17CA940", Length = "0xD")]
	[Token(Token = "0x6000448")]
	public void set_bindingGroup(string value) { }

	[Address(RVA = "0x2936210", Offset = "0x2935610", Length = "0xBE")]
	[Token(Token = "0x600044B")]
	internal void SetNameAndBindingGroup(string name, string bindingGroup = null) { }

	[Address(RVA = "0x29362D0", Offset = "0x29356D0", Length = "0x123")]
	[Token(Token = "0x600044F")]
	public bool SupportsDevice(InputDevice device) { }

	[Address(RVA = "0x2936400", Offset = "0x2935800", Length = "0x183")]
	[Token(Token = "0x6000454")]
	public virtual string ToString() { }

}

