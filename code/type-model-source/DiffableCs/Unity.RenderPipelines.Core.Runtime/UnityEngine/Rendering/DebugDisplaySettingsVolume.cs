namespace UnityEngine.Rendering;

[Token(Token = "0x2000076")]
public class DebugDisplaySettingsVolume : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
{
	[CompilerGenerated]
	[Token(Token = "0x2000082")]
	private sealed class <>c__DisplayClass10_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001A3")]
		public Type value; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60005F5")]
		public <>c__DisplayClass10_0() { }

		[Address(RVA = "0xA54940", Offset = "0xA53D40", Length = "0x3F")]
		[Token(Token = "0x60005F6")]
		internal bool <set_selectedComponentType>b__0(ValueTuple<String, Type> t) { }

	}

	[DisplayInfo(name = "Volume", order = 2147483647)]
	[Token(Token = "0x2000080")]
	public class SettingsPanel : DebugDisplaySettingsPanel<DebugDisplaySettingsVolume>
	{
		[CompilerGenerated]
		[Token(Token = "0x2000081")]
		private sealed class <>c__DisplayClass3_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40001A1")]
			public SettingsPanel <>4__this; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x40001A2")]
			public DebugDisplaySettingsVolume data; //Field offset: 0x18

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60005F1")]
			public <>c__DisplayClass3_0() { }

			[Address(RVA = "0x2BEB4B0", Offset = "0x2BEA8B0", Length = "0x1D")]
			[Token(Token = "0x60005F2")]
			internal void <.ctor>b__0(Field<Object> _, object __) { }

			[Address(RVA = "0x2BEB4B0", Offset = "0x2BEA8B0", Length = "0x1D")]
			[Token(Token = "0x60005F3")]
			internal void <.ctor>b__1(Field<Int32> _, int __) { }

			[Address(RVA = "0x2BEB4D0", Offset = "0x2BEA8D0", Length = "0x85")]
			[Token(Token = "0x60005F4")]
			internal bool <.ctor>b__2() { }

		}

		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001A0")]
		private Table m_VolumeTable; //Field offset: 0x28

		[Token(Token = "0x1700005C")]
		public virtual Flags Flags
		{
			[Address(RVA = "0x9DCBA0", Offset = "0x9DBFA0", Length = "0x6")]
			[Token(Token = "0x60005EC")]
			 get { } //Length: 6
		}

		[Address(RVA = "0x2BE78B0", Offset = "0x2BE6CB0", Length = "0x5BD")]
		[Token(Token = "0x60005EE")]
		public SettingsPanel(DebugDisplaySettingsVolume data) { }

		[Address(RVA = "0x2BE73D0", Offset = "0x2BE67D0", Length = "0x151")]
		[Token(Token = "0x60005ED")]
		public virtual void Dispose() { }

		[Address(RVA = "0x9DCBA0", Offset = "0x9DBFA0", Length = "0x6")]
		[Token(Token = "0x60005EC")]
		public virtual Flags get_Flags() { }

		[Address(RVA = "0x2BE7530", Offset = "0x2BE6930", Length = "0x81")]
		[Token(Token = "0x60005EF")]
		private void OnVolumeInfluenceChanged(ObservableList<Volume> sender, ListChangedEventArgs<Volume> e) { }

		[Address(RVA = "0x2BE75C0", Offset = "0x2BE69C0", Length = "0x2E4")]
		[Token(Token = "0x60005F0")]
		private void Refresh() { }

	}

	[Token(Token = "0x2000078")]
	private static class Strings
	{
		[Token(Token = "0x4000180")]
		public static readonly string cameraNeedsRendering; //Field offset: 0x0
		[Token(Token = "0x4000181")]
		public static readonly string none; //Field offset: 0x8
		[Token(Token = "0x4000182")]
		public static readonly string parameter; //Field offset: 0x10
		[Token(Token = "0x4000183")]
		public static readonly string component; //Field offset: 0x18
		[Token(Token = "0x4000184")]
		public static readonly string debugViewNotSupported; //Field offset: 0x20
		[Token(Token = "0x4000185")]
		public static readonly string volumeInfo; //Field offset: 0x28
		[Token(Token = "0x4000186")]
		public static readonly string gameObject; //Field offset: 0x30
		[Token(Token = "0x4000187")]
		public static readonly string priority; //Field offset: 0x38
		[Token(Token = "0x4000188")]
		public static readonly string resultValue; //Field offset: 0x40
		[Token(Token = "0x4000189")]
		public static readonly string resultValueTooltip; //Field offset: 0x48
		[Token(Token = "0x400018A")]
		public static readonly string globalDefaultValue; //Field offset: 0x50
		[Token(Token = "0x400018B")]
		public static readonly string globalDefaultValueTooltip; //Field offset: 0x58
		[Token(Token = "0x400018C")]
		public static readonly string qualityLevelValue; //Field offset: 0x60
		[Token(Token = "0x400018D")]
		public static readonly string qualityLevelValueTooltip; //Field offset: 0x68
		[Token(Token = "0x400018E")]
		public static readonly string global; //Field offset: 0x70
		[Token(Token = "0x400018F")]
		public static readonly string local; //Field offset: 0x78
		[Token(Token = "0x4000190")]
		public static readonly string volumeProfile; //Field offset: 0x80
		[Token(Token = "0x4000191")]
		public static readonly string parameterNotCalculated; //Field offset: 0x88

		[Address(RVA = "0x2BE96E0", Offset = "0x2BE8AE0", Length = "0x4D6")]
		[Token(Token = "0x60005CE")]
		private static Strings() { }

	}

	[Token(Token = "0x2000077")]
	private static class Styles
	{
		[Token(Token = "0x400017F")]
		public static readonly GUIContent none; //Field offset: 0x0

		[Address(RVA = "0x2BE9F90", Offset = "0x2BE9390", Length = "0x87")]
		[Token(Token = "0x60005CD")]
		private static Styles() { }

	}

	[Token(Token = "0x2000079")]
	public static class WidgetFactory
	{
		[CompilerGenerated]
		[Token(Token = "0x200007B")]
		private sealed class <>c
		{
			[Token(Token = "0x4000197")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x4000198")]
			public static Func<Object> <>9__2_0; //Field offset: 0x8
			[Token(Token = "0x4000199")]
			public static Func<Boolean> <>9__7_0; //Field offset: 0x10
			[Token(Token = "0x400019A")]
			public static Func<Object> <>9__8_3; //Field offset: 0x18

			[Address(RVA = "0x2BEB7E0", Offset = "0x2BEABE0", Length = "0x67")]
			[Token(Token = "0x60005D8")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60005D9")]
			public <>c() { }

			[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
			[Token(Token = "0x60005DD")]
			internal object <.cctor>b__10_0() { }

			[Address(RVA = "0x2BEA790", Offset = "0x2BE9B90", Length = "0x52")]
			[Token(Token = "0x60005DA")]
			internal object <CreateVolumeParameterWidget>b__2_0() { }

			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x60005DB")]
			internal bool <CreateVolumeTable>b__7_0() { }

			[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
			[Token(Token = "0x60005DC")]
			internal object <GenerateTableColumns>b__8_3() { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200007C")]
		private sealed class <>c__DisplayClass0_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400019B")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60005DE")]
			public <>c__DisplayClass0_0() { }

			[Address(RVA = "0x2BEAA70", Offset = "0x2BE9E70", Length = "0x45")]
			[Token(Token = "0x60005DF")]
			internal int <CreateComponentSelector>b__0() { }

			[Address(RVA = "0x2BEAAC0", Offset = "0x2BE9EC0", Length = "0x56")]
			[Token(Token = "0x60005E0")]
			internal void <CreateComponentSelector>b__1(int value) { }

			[Address(RVA = "0x2BEAB20", Offset = "0x2BE9F20", Length = "0x45")]
			[Token(Token = "0x60005E1")]
			internal int <CreateComponentSelector>b__2() { }

			[Address(RVA = "0x2BEAB70", Offset = "0x2BE9F70", Length = "0x50")]
			[Token(Token = "0x60005E2")]
			internal void <CreateComponentSelector>b__3(int value) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200007D")]
		private sealed class <>c__DisplayClass1_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400019C")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60005E3")]
			public <>c__DisplayClass1_0() { }

			[Address(RVA = "0x2BEABD0", Offset = "0x2BE9FD0", Length = "0x46")]
			[Token(Token = "0x60005E4")]
			internal object <CreateCameraSelector>b__0() { }

			[Address(RVA = "0x2BEAC20", Offset = "0x2BEA020", Length = "0x76")]
			[Token(Token = "0x60005E5")]
			internal void <CreateCameraSelector>b__1(object value) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200007E")]
		private sealed class <>c__DisplayClass8_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400019D")]
			public DebugDisplaySettingsVolume data; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60005E6")]
			public <>c__DisplayClass8_0() { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200007F")]
		private sealed class <>c__DisplayClass8_1
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400019E")]
			public VolumeParameterChain chain; //Field offset: 0x10
			[FieldOffset(Offset = "0x38")]
			[Token(Token = "0x400019F")]
			public <>c__DisplayClass8_0 CS$<>8__locals1; //Field offset: 0x38

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60005E7")]
			public <>c__DisplayClass8_1() { }

			[Address(RVA = "0x2BEB660", Offset = "0x2BEAA60", Length = "0x131")]
			[Token(Token = "0x60005E8")]
			internal object <GenerateTableColumns>b__0() { }

			[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
			[Token(Token = "0x60005E9")]
			internal object <GenerateTableColumns>b__1() { }

			[Address(RVA = "0x2BEB7A0", Offset = "0x2BEABA0", Length = "0x33")]
			[Token(Token = "0x60005EA")]
			internal object <GenerateTableColumns>b__2() { }

			[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
			[Token(Token = "0x60005EB")]
			internal object <GenerateTableColumns>b__4() { }

		}

		[Token(Token = "0x200007A")]
		private struct VolumeParameterChain
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000193")]
			public NameAndTooltip nameAndTooltip; //Field offset: 0x0
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000194")]
			public VolumeProfile volumeProfile; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000195")]
			public VolumeComponent volumeComponent; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000196")]
			public Volume volume; //Field offset: 0x20

		}

		[Token(Token = "0x4000192")]
		private static Value s_EmptyDebugUIValue; //Field offset: 0x0

		[Address(RVA = "0x2BEE720", Offset = "0x2BEDB20", Length = "0x13E")]
		[Token(Token = "0x60005D7")]
		private static WidgetFactory() { }

		[Address(RVA = "0x2BEBDC0", Offset = "0x2BEB1C0", Length = "0x24D")]
		[Token(Token = "0x60005D0")]
		public static CameraSelector CreateCameraSelector(SettingsPanel panel, Action<Field`1<Object>, Object> refresh) { }

		[Address(RVA = "0x2BEC010", Offset = "0x2BEB410", Length = "0x6CE")]
		[Token(Token = "0x60005CF")]
		public static EnumField CreateComponentSelector(SettingsPanel panel, Action<Field`1<Int32>, Int32> refresh) { }

		[Address(RVA = "0x2BEC6E0", Offset = "0x2BEBAE0", Length = "0x16F")]
		[Token(Token = "0x60005D1")]
		internal static Widget CreateVolumeParameterWidget(string name, bool isResultParameter, VolumeParameter param) { }

		[Address(RVA = "0x2BEC850", Offset = "0x2BEBC50", Length = "0x21D")]
		[Token(Token = "0x60005D4")]
		public static Table CreateVolumeTable(DebugDisplaySettingsVolume data) { }

		[Address(RVA = "0x2BECA70", Offset = "0x2BEBE70", Length = "0xB82")]
		[Token(Token = "0x60005D5")]
		private static void GenerateTableColumns(Table table, DebugDisplaySettingsVolume data, List<VolumeParameterChain> resolutionChain) { }

		[Address(RVA = "0x2BED600", Offset = "0x2BECA00", Length = "0x42A")]
		[Token(Token = "0x60005D6")]
		private static void GenerateTableRows(Table table, List<VolumeParameterChain> resolutionChain) { }

		[Address(RVA = "0x2BEDA30", Offset = "0x2BECE30", Length = "0xB2D")]
		[Token(Token = "0x60005D3")]
		private static List<VolumeParameterChain> GetResolutionChain(DebugDisplaySettingsVolume data) { }

		[Address(RVA = "0x2BEE560", Offset = "0x2BED960", Length = "0x1B3")]
		[Token(Token = "0x60005D2")]
		private static VolumeComponent GetSelectedVolumeComponent(VolumeProfile profile, Type selectedType) { }

	}

	[Token(Token = "0x400017E")]
	private const string k_PanelTitle = "Volume"; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000176")]
	private readonly IVolumeDebugSettings <volumeDebugSettings>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000177")]
	private int m_SelectedComponentIndex; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000178")]
	private Camera m_SelectedCamera; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000179")]
	private VolumeComponent m_VolumeInterpolatedResults; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400017A")]
	private bool m_StoreStackInterpolatedValues; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400017B")]
	private ObservableList<Volume> m_InfluenceVolumes; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400017C")]
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"volume", "weight"})]
	private List<ValueTuple`2<Volume, Single>> m_VolumesWeights; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400017D")]
	internal int volumeComponentEnumIndex; //Field offset: 0x48

	[Token(Token = "0x1700005B")]
	public override bool AreAnySettingsActive
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60005CB")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700005A")]
	internal VolumeComponent resultVolumeComponent
	{
		[Address(RVA = "0x2BD7840", Offset = "0x2BD6C40", Length = "0x119")]
		[Token(Token = "0x60005C9")]
		internal get { } //Length: 281
	}

	[Token(Token = "0x17000059")]
	public Camera selectedCamera
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60005BC")]
		 get { } //Length: 5
		[Address(RVA = "0x2BD7A60", Offset = "0x2BD6E60", Length = "0xD1")]
		[Token(Token = "0x60005BD")]
		 set { } //Length: 209
	}

	[Token(Token = "0x17000056")]
	public int selectedComponent
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x60005B6")]
		 get { } //Length: 4
		[Address(RVA = "0x2BD7C50", Offset = "0x2BD7050", Length = "0x71")]
		[Token(Token = "0x60005B7")]
		 set { } //Length: 113
	}

	[Token(Token = "0x17000057")]
	public Type selectedComponentType
	{
		[Address(RVA = "0x2BD7960", Offset = "0x2BD6D60", Length = "0x6D")]
		[Token(Token = "0x60005B9")]
		 get { } //Length: 109
		[Address(RVA = "0x2BD7B40", Offset = "0x2BD6F40", Length = "0x101")]
		[Token(Token = "0x60005BA")]
		 set { } //Length: 257
	}

	[Token(Token = "0x17000058")]
	public List<ValueTuple`2<String, Type>> volumeComponentsPathAndType
	{
		[Address(RVA = "0x2BD79D0", Offset = "0x2BD6DD0", Length = "0x86")]
		[Token(Token = "0x60005BB")]
		 get { } //Length: 134
	}

	[Obsolete("This property has been obsoleted and will be removed in a future version. #from(6000.2)")]
	[Token(Token = "0x17000055")]
	public IVolumeDebugSettings volumeDebugSettings
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60005B5")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2BD7680", Offset = "0x2BD6A80", Length = "0xC4")]
	[Token(Token = "0x60005C8")]
	public DebugDisplaySettingsVolume() { }

	[Address(RVA = "0x2BD7750", Offset = "0x2BD6B50", Length = "0xE1")]
	[Obsolete("This constructor has been obsoleted and will be removed in a future version. #from(6000.2)")]
	[Token(Token = "0x60005C7")]
	public DebugDisplaySettingsVolume(IVolumeDebugSettings volumeDebugSettings) { }

	[Address(RVA = "0x2BD67E0", Offset = "0x2BD5BE0", Length = "0x12B")]
	[Token(Token = "0x60005C0")]
	private static bool AreVolumesChanged(ObservableList<Volume> influenceVolumes, List<ValueTuple`2<Volume, Single>> volumesWeights) { }

	[Address(RVA = "0x2BD6910", Offset = "0x2BD5D10", Length = "0x5F")]
	[Token(Token = "0x60005BF")]
	private void ClearInterpolationData() { }

	[Address(RVA = "0x2BD6970", Offset = "0x2BD5D70", Length = "0x54")]
	[Token(Token = "0x60005CC")]
	public override IDebugDisplaySettingsPanelDisposable CreatePanel() { }

	[Address(RVA = "0x2BD69D0", Offset = "0x2BD5DD0", Length = "0x81")]
	[Token(Token = "0x60005B8")]
	private void DestroyVolumeInterpolatedResults() { }

	[Address(RVA = "0x2BD6A60", Offset = "0x2BD5E60", Length = "0x3FD")]
	[Token(Token = "0x60005CA")]
	internal static string ExtractResult(VolumeParameter param) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60005CB")]
	public override bool get_AreAnySettingsActive() { }

	[Address(RVA = "0x2BD7840", Offset = "0x2BD6C40", Length = "0x119")]
	[Token(Token = "0x60005C9")]
	internal VolumeComponent get_resultVolumeComponent() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60005BC")]
	public Camera get_selectedCamera() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x60005B6")]
	public int get_selectedComponent() { }

	[Address(RVA = "0x2BD7960", Offset = "0x2BD6D60", Length = "0x6D")]
	[Token(Token = "0x60005B9")]
	public Type get_selectedComponentType() { }

	[Address(RVA = "0x2BD79D0", Offset = "0x2BD6DD0", Length = "0x86")]
	[Token(Token = "0x60005BB")]
	public List<ValueTuple`2<String, Type>> get_volumeComponentsPathAndType() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60005B5")]
	public IVolumeDebugSettings get_volumeDebugSettings() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x60005C5")]
	public ObservableList<Volume> GetVolumesList() { }

	[Address(RVA = "0x2BD6E60", Offset = "0x2BD6260", Length = "0x195")]
	[Token(Token = "0x60005C4")]
	public float GetVolumeWeight(Volume volume) { }

	[Address(RVA = "0x2BD7000", Offset = "0x2BD6400", Length = "0x12E")]
	[Token(Token = "0x60005C1")]
	private void OnBeginVolumeStackUpdate(VolumeStack stack, Camera camera) { }

	[Address(RVA = "0x2BD7130", Offset = "0x2BD6530", Length = "0x3C6")]
	[Token(Token = "0x60005C2")]
	private void OnEndVolumeStackUpdate(VolumeStack stack, Camera camera) { }

	[Address(RVA = "0x2BD7500", Offset = "0x2BD6900", Length = "0x63")]
	[Token(Token = "0x60005BE")]
	private void OnSelectionChanged() { }

	[Address(RVA = "0x2BD7570", Offset = "0x2BD6970", Length = "0x108")]
	[Token(Token = "0x60005C3")]
	private void OnVolumeStackInterpolated(VolumeStack stack, Volume volume, float interpolationFactor) { }

	[Address(RVA = "0x2BD7A60", Offset = "0x2BD6E60", Length = "0xD1")]
	[Token(Token = "0x60005BD")]
	public void set_selectedCamera(Camera value) { }

	[Address(RVA = "0x2BD7C50", Offset = "0x2BD7050", Length = "0x71")]
	[Token(Token = "0x60005B7")]
	public void set_selectedComponent(int value) { }

	[Address(RVA = "0x2BD7B40", Offset = "0x2BD6F40", Length = "0x101")]
	[Token(Token = "0x60005BA")]
	public void set_selectedComponentType(Type value) { }

	[Address(RVA = "0x2BD7500", Offset = "0x2BD6900", Length = "0x63")]
	[Token(Token = "0x60005C6")]
	private override void UnityEngine.Rendering.IDebugDisplaySettingsData.Reset() { }

}

