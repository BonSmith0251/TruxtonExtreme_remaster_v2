namespace UnityEngine.Rendering;

[Obsolete("This is not longer supported Please use DebugDisplaySettingsVolume. #from(6000.2)")]
[Token(Token = "0x20000E0")]
public abstract class VolumeDebugSettings : IVolumeDebugSettings
{
	[CompilerGenerated]
	[Token(Token = "0x20000E1")]
	private sealed class <>c
	{
		[Token(Token = "0x40002DE")]
		public static readonly <>c<T> <>9; //Field offset: 0x0
		[Token(Token = "0x40002DF")]
		public static Func<Volume, Boolean> <>9__34_0; //Field offset: 0x0
		[Token(Token = "0x40002E0")]
		public static Func<FieldInfo, Boolean> <>9__36_0; //Field offset: 0x0
		[Token(Token = "0x40002E1")]
		public static Func<Type, Boolean> <>9__43_0; //Field offset: 0x0
		[Token(Token = "0x40002E2")]
		public static Func<Type, Boolean> <>9__43_1; //Field offset: 0x0
		[Token(Token = "0x40002E3")]
		public static Func<Type, String> <>9__43_2; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x6000801")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000802")]
		public <>c() { }

		[Address(RVA = "0xA50410", Offset = "0xA4F810", Length = "0x86")]
		[Token(Token = "0x6000805")]
		internal bool <get_componentTypes>b__43_0(Type t) { }

		[Address(RVA = "0xA504A0", Offset = "0xA4F8A0", Length = "0x86")]
		[Token(Token = "0x6000806")]
		internal bool <get_componentTypes>b__43_1(Type t) { }

		[Address(RVA = "0xA50530", Offset = "0xA4F930", Length = "0x62")]
		[Token(Token = "0x6000807")]
		internal string <get_componentTypes>b__43_2(Type t) { }

		[Address(RVA = "0xA351D0", Offset = "0xA345D0", Length = "0x9C")]
		[Token(Token = "0x6000804")]
		internal bool <GetStates>b__36_0(FieldInfo t) { }

		[Address(RVA = "0xA35380", Offset = "0xA34780", Length = "0x5A")]
		[Token(Token = "0x6000803")]
		internal bool <GetVolumes>b__34_0(Volume v) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000E2")]
	private sealed class <>c__DisplayClass22_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002E4")]
		public Type value; //Field offset: 0x0

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000808")]
		public <>c__DisplayClass22_0() { }

		[Address(RVA = "0xA54940", Offset = "0xA53D40", Length = "0x3F")]
		[Token(Token = "0x6000809")]
		internal bool <set_selectedComponentType>b__0(ValueTuple<String, Type> t) { }

	}

	[Token(Token = "0x40002DC")]
	private static List<Type> s_ComponentTypes; //Field offset: 0x0
	[CompilerGenerated]
	[Token(Token = "0x40002DD")]
	private static List<T> <additionalCameraDatas>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002D4")]
	private int <selectedComponent>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002D5")]
	protected int m_SelectedCameraIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002D6")]
	private Camera[] m_CamerasArray; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002D7")]
	private List<Camera> m_Cameras; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002D8")]
	private readonly Type <targetRenderPipeline>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002D9")]
	private Single[] weights; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002DA")]
	private Volume[] volumes; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002DB")]
	private VolumeParameter[2] savedStates; //Field offset: 0x0

	[Obsolete("Cameras are auto registered/unregistered, use property cameras #from(2022.2)")]
	[Token(Token = "0x170000D9")]
	protected private static List<T> additionalCameraDatas
	{
		[Address(RVA = "0x140A0A0", Offset = "0x14094A0", Length = "0xA1")]
		[CompilerGenerated]
		[Token(Token = "0x60007FB")]
		 get { } //Length: 161
		[Address(RVA = "0x140AE70", Offset = "0x140A270", Length = "0xE5")]
		[CompilerGenerated]
		[Token(Token = "0x60007FC")]
		private set { } //Length: 229
	}

	[Token(Token = "0x170000D1")]
	public override IEnumerable<Camera> cameras
	{
		[Address(RVA = "0x140A150", Offset = "0x1409550", Length = "0x230")]
		[Token(Token = "0x60007E7")]
		 get { } //Length: 560
	}

	[Obsolete("Please use volumeComponentsPathAndType instead, and get the second element of the tuple #from(2022.2)")]
	[Token(Token = "0x170000D8")]
	public static List<Type> componentTypes
	{
		[Address(RVA = "0x140A390", Offset = "0x1409790", Length = "0x85F")]
		[Token(Token = "0x60007F9")]
		 get { } //Length: 2143
	}

	[Token(Token = "0x170000CF")]
	public override Camera selectedCamera
	{
		[Address(RVA = "0x140ACA0", Offset = "0x140A0A0", Length = "0xAA")]
		[Token(Token = "0x60007E4")]
		 get { } //Length: 170
	}

	[Token(Token = "0x170000D0")]
	public override int selectedCameraIndex
	{
		[Address(RVA = "0x140ABF0", Offset = "0x1409FF0", Length = "0xA6")]
		[Token(Token = "0x60007E5")]
		 get { } //Length: 166
		[Address(RVA = "0x140AF60", Offset = "0x140A360", Length = "0x9F")]
		[Token(Token = "0x60007E6")]
		 set { } //Length: 159
	}

	[Token(Token = "0x170000D3")]
	public abstract LayerMask selectedCameraLayerMask
	{
		[Token(Token = "0x60007E9")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000D4")]
	public abstract Vector3 selectedCameraPosition
	{
		[Token(Token = "0x60007EA")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000D2")]
	public abstract VolumeStack selectedCameraVolumeStack
	{
		[Token(Token = "0x60007E8")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000CE")]
	public override int selectedComponent
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x60007E2")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60007E3")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000D5")]
	public override Type selectedComponentType
	{
		[Address(RVA = "0x140AD50", Offset = "0x140A150", Length = "0x8B")]
		[Token(Token = "0x60007EB")]
		 get { } //Length: 139
		[Address(RVA = "0x140B000", Offset = "0x140A400", Length = "0x12B")]
		[Token(Token = "0x60007EC")]
		 set { } //Length: 299
	}

	[Obsolete("This property is obsolete and kept only for not breaking user code. VolumeDebugSettings will use current pipeline when it needs to gather volume component types and paths. #from(2023.2)")]
	[Token(Token = "0x170000D7")]
	public override Type targetRenderPipeline
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007EE")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000D6")]
	public List<ValueTuple`2<String, Type>> volumeComponentsPathAndType
	{
		[Address(RVA = "0x140ADE0", Offset = "0x140A1E0", Length = "0x86")]
		[Token(Token = "0x60007ED")]
		 get { } //Length: 134
	}

	[Address(RVA = "0x1409F10", Offset = "0x1409310", Length = "0x107")]
	[Token(Token = "0x6000800")]
	private static VolumeDebugSettings`1() { }

	[Address(RVA = "0x140A020", Offset = "0x1409420", Length = "0x7E")]
	[Token(Token = "0x60007FF")]
	protected VolumeDebugSettings`1() { }

	[Address(RVA = "0x1408740", Offset = "0x1407B40", Length = "0x153")]
	[Token(Token = "0x60007F5")]
	private bool ChangedStates(VolumeParameter[2] newStates) { }

	[Address(RVA = "0x14088A0", Offset = "0x1407CA0", Length = "0x14B")]
	[Obsolete("Please use componentPathAndType instead, and get the first element of the tuple #from(2022.2)")]
	[Token(Token = "0x60007FA")]
	public static string ComponentDisplayName(Type component) { }

	[Address(RVA = "0x14089F0", Offset = "0x1407DF0", Length = "0x3C8")]
	[Token(Token = "0x60007F2")]
	private float ComputeWeight(Volume volume, Vector3 triggerPos) { }

	[Address(RVA = "0x140A0A0", Offset = "0x14094A0", Length = "0xA1")]
	[CompilerGenerated]
	[Token(Token = "0x60007FB")]
	protected static List<T> get_additionalCameraDatas() { }

	[Address(RVA = "0x140A150", Offset = "0x1409550", Length = "0x230")]
	[Token(Token = "0x60007E7")]
	public override IEnumerable<Camera> get_cameras() { }

	[Address(RVA = "0x140A390", Offset = "0x1409790", Length = "0x85F")]
	[Token(Token = "0x60007F9")]
	public static List<Type> get_componentTypes() { }

	[Address(RVA = "0x140ACA0", Offset = "0x140A0A0", Length = "0xAA")]
	[Token(Token = "0x60007E4")]
	public override Camera get_selectedCamera() { }

	[Address(RVA = "0x140ABF0", Offset = "0x1409FF0", Length = "0xA6")]
	[Token(Token = "0x60007E5")]
	public override int get_selectedCameraIndex() { }

	[Token(Token = "0x60007E9")]
	public abstract LayerMask get_selectedCameraLayerMask() { }

	[Token(Token = "0x60007EA")]
	public abstract Vector3 get_selectedCameraPosition() { }

	[Token(Token = "0x60007E8")]
	public abstract VolumeStack get_selectedCameraVolumeStack() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x60007E2")]
	public override int get_selectedComponent() { }

	[Address(RVA = "0x140AD50", Offset = "0x140A150", Length = "0x8B")]
	[Token(Token = "0x60007EB")]
	public override Type get_selectedComponentType() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007EE")]
	public override Type get_targetRenderPipeline() { }

	[Address(RVA = "0x140ADE0", Offset = "0x140A1E0", Length = "0x86")]
	[Token(Token = "0x60007ED")]
	public List<ValueTuple`2<String, Type>> get_volumeComponentsPathAndType() { }

	[Address(RVA = "0x1408F30", Offset = "0x1408330", Length = "0xFD")]
	[Token(Token = "0x60007F0")]
	internal VolumeParameter GetParameter(FieldInfo field) { }

	[Address(RVA = "0x1409030", Offset = "0x1408430", Length = "0x99")]
	[Token(Token = "0x60007EF")]
	internal VolumeParameter GetParameter(VolumeComponent component, FieldInfo field) { }

	[Address(RVA = "0x1408DC0", Offset = "0x14081C0", Length = "0x166")]
	[Token(Token = "0x60007F1")]
	internal VolumeParameter GetParameter(Volume volume, FieldInfo field) { }

	[Address(RVA = "0x14090D0", Offset = "0x14084D0", Length = "0x43E")]
	[Token(Token = "0x60007F4")]
	private VolumeParameter[2] GetStates() { }

	[Address(RVA = "0x1409590", Offset = "0x1408990", Length = "0x25D")]
	[Token(Token = "0x60007F3")]
	public override Volume[] GetVolumes() { }

	[Address(RVA = "0x1409510", Offset = "0x1408910", Length = "0x76")]
	[Token(Token = "0x60007F7")]
	public override float GetVolumeWeight(Volume volume) { }

	[Address(RVA = "0x14097F0", Offset = "0x1408BF0", Length = "0x396")]
	[Token(Token = "0x60007F6")]
	public override bool RefreshVolumes(Volume[] newVolumes) { }

	[Address(RVA = "0x1409B90", Offset = "0x1408F90", Length = "0x17C")]
	[Obsolete("Cameras are auto registered/unregistered #from(2022.2)")]
	[Token(Token = "0x60007FD")]
	public static void RegisterCamera(T additionalCamera) { }

	[Address(RVA = "0x140AE70", Offset = "0x140A270", Length = "0xE5")]
	[CompilerGenerated]
	[Token(Token = "0x60007FC")]
	private static void set_additionalCameraDatas(List<T> value) { }

	[Address(RVA = "0x140AF60", Offset = "0x140A360", Length = "0x9F")]
	[Token(Token = "0x60007E6")]
	public override void set_selectedCameraIndex(int value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60007E3")]
	public override void set_selectedComponent(int value) { }

	[Address(RVA = "0x140B000", Offset = "0x140A400", Length = "0x12B")]
	[Token(Token = "0x60007EC")]
	public override void set_selectedComponentType(Type value) { }

	[Address(RVA = "0x1409D10", Offset = "0x1409110", Length = "0x17C")]
	[Obsolete("Cameras are auto registered/unregistered #from(2022.2)")]
	[Token(Token = "0x60007FE")]
	public static void UnRegisterCamera(T additionalCamera) { }

	[Address(RVA = "0x1409E90", Offset = "0x1409290", Length = "0x7F")]
	[Token(Token = "0x60007F8")]
	public override bool VolumeHasInfluence(Volume volume) { }

}

