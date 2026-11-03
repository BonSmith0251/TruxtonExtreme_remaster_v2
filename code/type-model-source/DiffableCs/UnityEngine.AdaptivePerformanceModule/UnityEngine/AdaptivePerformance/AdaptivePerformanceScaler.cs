namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x200001F")]
public abstract class AdaptivePerformanceScaler : ScriptableObject
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000090")]
	private AdaptivePerformanceIndexer m_Indexer; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000091")]
	private int <CurrentLevel>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000092")]
	private int <GpuImpact>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000093")]
	private int <CpuImpact>k__BackingField; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000094")]
	private int m_OverrideLevel; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000095")]
	private AdaptivePerformanceScalerSettingsBase m_defaultSetting; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000096")]
	protected IAdaptivePerformanceSettings m_Settings; //Field offset: 0x38

	[Token(Token = "0x17000054")]
	public internal int CpuImpact
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60000FB")]
		 get { } //Length: 4
		[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60000FC")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000050")]
	public private int CurrentLevel
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60000F5")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60000F6")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000055")]
	public AdaptivePerformanceScalerSettingsBase DefaultSetting
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x60000FD")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x60000FE")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000049")]
	public override bool Enabled
	{
		[Address(RVA = "0x2F94E80", Offset = "0x2F94280", Length = "0x1B")]
		[Token(Token = "0x60000E7")]
		 get { } //Length: 27
		[Address(RVA = "0x2F94F80", Offset = "0x2F94380", Length = "0x1F")]
		[Token(Token = "0x60000E8")]
		 set { } //Length: 31
	}

	[Token(Token = "0x17000053")]
	public internal int GpuImpact
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60000F9")]
		 get { } //Length: 4
		[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60000FA")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000051")]
	public bool IsMaxLevel
	{
		[Address(RVA = "0x2F94EA0", Offset = "0x2F942A0", Length = "0x27")]
		[Token(Token = "0x60000F7")]
		 get { } //Length: 39
	}

	[Token(Token = "0x1700004F")]
	public override float MaxBound
	{
		[Address(RVA = "0x2F94ED0", Offset = "0x2F942D0", Length = "0x1C")]
		[Token(Token = "0x60000F3")]
		 get { } //Length: 28
		[Address(RVA = "0x2F94FA0", Offset = "0x2F943A0", Length = "0x28")]
		[Token(Token = "0x60000F4")]
		 set { } //Length: 40
	}

	[Token(Token = "0x1700004D")]
	public override int MaxLevel
	{
		[Address(RVA = "0x2F94EF0", Offset = "0x2F942F0", Length = "0x1A")]
		[Token(Token = "0x60000EF")]
		 get { } //Length: 26
		[Address(RVA = "0x2F94FD0", Offset = "0x2F943D0", Length = "0x1F")]
		[Token(Token = "0x60000F0")]
		 set { } //Length: 31
	}

	[Token(Token = "0x1700004E")]
	public override float MinBound
	{
		[Address(RVA = "0x2F94F10", Offset = "0x2F94310", Length = "0x1C")]
		[Token(Token = "0x60000F1")]
		 get { } //Length: 28
		[Address(RVA = "0x2F94FF0", Offset = "0x2F943F0", Length = "0x28")]
		[Token(Token = "0x60000F2")]
		 set { } //Length: 40
	}

	[Token(Token = "0x17000048")]
	public override string Name
	{
		[Address(RVA = "0x2525420", Offset = "0x2524820", Length = "0x1B")]
		[Token(Token = "0x60000E5")]
		 get { } //Length: 27
		[Address(RVA = "0x2F95020", Offset = "0x2F94420", Length = "0x52")]
		[Token(Token = "0x60000E6")]
		 set { } //Length: 82
	}

	[Token(Token = "0x17000052")]
	public bool NotLeveled
	{
		[Address(RVA = "0x2F94F30", Offset = "0x2F94330", Length = "0x8")]
		[Token(Token = "0x60000F8")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000056")]
	public int OverrideLevel
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[Token(Token = "0x60000FF")]
		 get { } //Length: 4
		[Address(RVA = "0x2F95080", Offset = "0x2F94480", Length = "0x60")]
		[Token(Token = "0x6000100")]
		 set { } //Length: 96
	}

	[Token(Token = "0x1700004A")]
	public override float Scale
	{
		[Address(RVA = "0x1CF29C0", Offset = "0x1CF1DC0", Length = "0x1C")]
		[Token(Token = "0x60000E9")]
		 get { } //Length: 28
		[Address(RVA = "0x2F950F0", Offset = "0x2F944F0", Length = "0x28")]
		[Token(Token = "0x60000EA")]
		 set { } //Length: 40
	}

	[Token(Token = "0x1700004C")]
	public override ScalerTarget Target
	{
		[Address(RVA = "0x2F94F40", Offset = "0x2F94340", Length = "0x1A")]
		[Token(Token = "0x60000ED")]
		 get { } //Length: 26
		[Address(RVA = "0x2F95120", Offset = "0x2F94520", Length = "0x1F")]
		[Token(Token = "0x60000EE")]
		 set { } //Length: 31
	}

	[Token(Token = "0x1700004B")]
	public override ScalerVisualImpact VisualImpact
	{
		[Address(RVA = "0x2F94F60", Offset = "0x2F94360", Length = "0x1A")]
		[Token(Token = "0x60000EB")]
		 get { } //Length: 26
		[Address(RVA = "0x2F95140", Offset = "0x2F94540", Length = "0x1F")]
		[Token(Token = "0x60000EC")]
		 set { } //Length: 31
	}

	[Address(RVA = "0x2F87890", Offset = "0x2F86C90", Length = "0x6D")]
	[Token(Token = "0x6000113")]
	protected AdaptivePerformanceScaler() { }

	[Address(RVA = "0x2F94730", Offset = "0x2F93B30", Length = "0x14")]
	[Token(Token = "0x600010A")]
	internal void Activate() { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x600010C")]
	public void ApplyDefaultSetting(AdaptivePerformanceScalerSettingsBase defaultSetting) { }

	[Address(RVA = "0x2F94750", Offset = "0x2F93B50", Length = "0x10D")]
	[Token(Token = "0x6000102")]
	protected override void Awake() { }

	[Address(RVA = "0x2F94860", Offset = "0x2F93C60", Length = "0x198")]
	[Token(Token = "0x6000101")]
	public int CalculateCost() { }

	[Address(RVA = "0x2F94A00", Offset = "0x2F93E00", Length = "0x14")]
	[Token(Token = "0x600010B")]
	internal void Deactivate() { }

	[Address(RVA = "0x2F94A20", Offset = "0x2F93E20", Length = "0x95")]
	[Token(Token = "0x6000109")]
	internal void DecreaseLevel() { }

	[Address(RVA = "0x2F94AC0", Offset = "0x2F93EC0", Length = "0x41")]
	[Token(Token = "0x6000105")]
	internal void EnableScaler() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60000FB")]
	public int get_CpuImpact() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60000F5")]
	public int get_CurrentLevel() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x60000FD")]
	public AdaptivePerformanceScalerSettingsBase get_DefaultSetting() { }

	[Address(RVA = "0x2F94E80", Offset = "0x2F94280", Length = "0x1B")]
	[Token(Token = "0x60000E7")]
	public override bool get_Enabled() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60000F9")]
	public int get_GpuImpact() { }

	[Address(RVA = "0x2F94EA0", Offset = "0x2F942A0", Length = "0x27")]
	[Token(Token = "0x60000F7")]
	public bool get_IsMaxLevel() { }

	[Address(RVA = "0x2F94ED0", Offset = "0x2F942D0", Length = "0x1C")]
	[Token(Token = "0x60000F3")]
	public override float get_MaxBound() { }

	[Address(RVA = "0x2F94EF0", Offset = "0x2F942F0", Length = "0x1A")]
	[Token(Token = "0x60000EF")]
	public override int get_MaxLevel() { }

	[Address(RVA = "0x2F94F10", Offset = "0x2F94310", Length = "0x1C")]
	[Token(Token = "0x60000F1")]
	public override float get_MinBound() { }

	[Address(RVA = "0x2525420", Offset = "0x2524820", Length = "0x1B")]
	[Token(Token = "0x60000E5")]
	public override string get_Name() { }

	[Address(RVA = "0x2F94F30", Offset = "0x2F94330", Length = "0x8")]
	[Token(Token = "0x60000F8")]
	public bool get_NotLeveled() { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[Token(Token = "0x60000FF")]
	public int get_OverrideLevel() { }

	[Address(RVA = "0x1CF29C0", Offset = "0x1CF1DC0", Length = "0x1C")]
	[Token(Token = "0x60000E9")]
	public override float get_Scale() { }

	[Address(RVA = "0x2F94F40", Offset = "0x2F94340", Length = "0x1A")]
	[Token(Token = "0x60000ED")]
	public override ScalerTarget get_Target() { }

	[Address(RVA = "0x2F94F60", Offset = "0x2F94360", Length = "0x1A")]
	[Token(Token = "0x60000EB")]
	public override ScalerVisualImpact get_VisualImpact() { }

	[Address(RVA = "0x2F94B10", Offset = "0x2F93F10", Length = "0xBA")]
	[Token(Token = "0x6000108")]
	internal void IncreaseLevel() { }

	[Address(RVA = "0x2F94BD0", Offset = "0x2F93FD0", Length = "0x13E")]
	[Token(Token = "0x6000103")]
	internal void InitializeScaler() { }

	[Address(RVA = "0x2F94D10", Offset = "0x2F94110", Length = "0x45")]
	[Token(Token = "0x6000107")]
	private void OnDisable() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000112")]
	protected override void OnDisabled() { }

	[Address(RVA = "0x2F94AC0", Offset = "0x2F93EC0", Length = "0x41")]
	[Token(Token = "0x6000104")]
	private void OnEnable() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000111")]
	protected override void OnEnabled() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000110")]
	protected override void OnLevel() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600010F")]
	protected override void OnLevelDecrease() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600010E")]
	protected override void OnLevelIncrease() { }

	[Address(RVA = "0x2F94D10", Offset = "0x2F94110", Length = "0x45")]
	[Token(Token = "0x6000106")]
	internal void RemoveScaler() { }

	[Address(RVA = "0x2F94D60", Offset = "0x2F94160", Length = "0x11F")]
	[Token(Token = "0x600010D")]
	protected bool ScaleChanged() { }

	[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60000FC")]
	internal void set_CpuImpact(int value) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60000F6")]
	private void set_CurrentLevel(int value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x60000FE")]
	public void set_DefaultSetting(AdaptivePerformanceScalerSettingsBase value) { }

	[Address(RVA = "0x2F94F80", Offset = "0x2F94380", Length = "0x1F")]
	[Token(Token = "0x60000E8")]
	public override void set_Enabled(bool value) { }

	[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60000FA")]
	internal void set_GpuImpact(int value) { }

	[Address(RVA = "0x2F94FA0", Offset = "0x2F943A0", Length = "0x28")]
	[Token(Token = "0x60000F4")]
	public override void set_MaxBound(float value) { }

	[Address(RVA = "0x2F94FD0", Offset = "0x2F943D0", Length = "0x1F")]
	[Token(Token = "0x60000F0")]
	public override void set_MaxLevel(int value) { }

	[Address(RVA = "0x2F94FF0", Offset = "0x2F943F0", Length = "0x28")]
	[Token(Token = "0x60000F2")]
	public override void set_MinBound(float value) { }

	[Address(RVA = "0x2F95020", Offset = "0x2F94420", Length = "0x52")]
	[Token(Token = "0x60000E6")]
	public override void set_Name(string value) { }

	[Address(RVA = "0x2F95080", Offset = "0x2F94480", Length = "0x60")]
	[Token(Token = "0x6000100")]
	public void set_OverrideLevel(int value) { }

	[Address(RVA = "0x2F950F0", Offset = "0x2F944F0", Length = "0x28")]
	[Token(Token = "0x60000EA")]
	public override void set_Scale(float value) { }

	[Address(RVA = "0x2F95120", Offset = "0x2F94520", Length = "0x1F")]
	[Token(Token = "0x60000EE")]
	public override void set_Target(ScalerTarget value) { }

	[Address(RVA = "0x2F95140", Offset = "0x2F94540", Length = "0x1F")]
	[Token(Token = "0x60000EC")]
	public override void set_VisualImpact(ScalerVisualImpact value) { }

}

