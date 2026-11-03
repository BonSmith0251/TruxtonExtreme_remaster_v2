namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x200001B")]
public class AdaptivePerformanceIndexer
{
	[Token(Token = "0x4000079")]
	private const string m_FeatureName = "Indexer"; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000072")]
	private List<AdaptivePerformanceScaler> m_UnappliedScalers; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000073")]
	private List<AdaptivePerformanceScaler> m_AppliedScalers; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000074")]
	private List<AdaptivePerformanceScaler> m_DisabledScalers; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000075")]
	private ThermalStateTracker m_ThermalStateTracker; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000076")]
	private PerformanceStateTracker m_PerformanceStateTracker; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000077")]
	private AdaptivePerformanceScalerEfficiencyTracker m_ScalerEfficiencyTracker; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000078")]
	private IAdaptivePerformanceSettings m_Settings; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400007A")]
	private float <TimeUntilNextAction>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400007B")]
	private StateAction <ThermalAction>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400007C")]
	private StateAction <PerformanceAction>k__BackingField; //Field offset: 0x50

	[Token(Token = "0x1700003C")]
	public private StateAction PerformanceAction
	{
		[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60000BB")]
		 get { } //Length: 4
		[Address(RVA = "0x1E07600", Offset = "0x1E06A00", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60000BC")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700003B")]
	private StateAction ThermalAction
	{
		[Address(RVA = "0xFE2A70", Offset = "0xFE1E70", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60000BA")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700003A")]
	public private float TimeUntilNextAction
	{
		[Address(RVA = "0x1E08940", Offset = "0x1E07D40", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60000B8")]
		 get { } //Length: 6
		[Address(RVA = "0x1DD4B70", Offset = "0x1DD3F70", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60000B9")]
		private set { } //Length: 6
	}

	[Address(RVA = "0x2F8B080", Offset = "0x2F8A480", Length = "0x1A0")]
	[Token(Token = "0x60000C4")]
	internal AdaptivePerformanceIndexer(ref IAdaptivePerformanceSettings settings, PerformanceStateTracker tracker) { }

	[Address(RVA = "0x2F89700", Offset = "0x2F88B00", Length = "0x17A")]
	[Token(Token = "0x60000C9")]
	private void ActivateEnabledScalers() { }

	[Address(RVA = "0x2F89880", Offset = "0x2F88C80", Length = "0x98")]
	[Token(Token = "0x60000C2")]
	internal void AddScaler(AdaptivePerformanceScaler scaler) { }

	[Address(RVA = "0x2F89920", Offset = "0x2F88D20", Length = "0x352")]
	[Token(Token = "0x60000CA")]
	private bool ApplyLowestCostScaler() { }

	[Address(RVA = "0x2F89C80", Offset = "0x2F89080", Length = "0x1E6")]
	[Token(Token = "0x60000CB")]
	private void ApplyScaler(AdaptivePerformanceScaler scaler) { }

	[Address(RVA = "0x2F89E70", Offset = "0x2F89270", Length = "0x1F6")]
	[Token(Token = "0x60000C7")]
	private void CollectProfilerStats() { }

	[Address(RVA = "0x2F8A070", Offset = "0x2F89470", Length = "0x2EE")]
	[Token(Token = "0x60000C8")]
	private void DeactivateDisabledScalers() { }

	[Address(RVA = "0x2F8A360", Offset = "0x2F89760", Length = "0x9")]
	[Token(Token = "0x60000C6")]
	protected override float DeltaTime() { }

	[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60000BB")]
	public StateAction get_PerformanceAction() { }

	[Address(RVA = "0x1E08940", Offset = "0x1E07D40", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x60000B8")]
	public float get_TimeUntilNextAction() { }

	[Address(RVA = "0x2F8A370", Offset = "0x2F89770", Length = "0x88")]
	[Token(Token = "0x60000BD")]
	public void GetAppliedScalers(ref List<AdaptivePerformanceScaler>& scalers) { }

	[Address(RVA = "0x2F8A400", Offset = "0x2F89800", Length = "0x88")]
	[Token(Token = "0x60000BF")]
	public void GetDisabledScalers(ref List<AdaptivePerformanceScaler>& scalers) { }

	[Address(RVA = "0x2F8A490", Offset = "0x2F89890", Length = "0x88")]
	[Token(Token = "0x60000BE")]
	public void GetUnappliedScalers(ref List<AdaptivePerformanceScaler>& scalers) { }

	[Address(RVA = "0x2F8A520", Offset = "0x2F89920", Length = "0x1B5")]
	[Token(Token = "0x60000C3")]
	internal bool RemoveScaler(AdaptivePerformanceScaler scaler) { }

	[Address(RVA = "0x1E07600", Offset = "0x1E06A00", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60000BC")]
	private void set_PerformanceAction(StateAction value) { }

	[Address(RVA = "0xFE2A70", Offset = "0xFE1E70", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60000BA")]
	private void set_ThermalAction(StateAction value) { }

	[Address(RVA = "0x1DD4B70", Offset = "0x1DD3F70", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x60000B9")]
	private void set_TimeUntilNextAction(float value) { }

	[Address(RVA = "0x2F8A6E0", Offset = "0x2F89AE0", Length = "0x93")]
	[Token(Token = "0x60000C0")]
	public void UnapplyAllScalers() { }

	[Address(RVA = "0x2F8A780", Offset = "0x2F89B80", Length = "0x1E2")]
	[Token(Token = "0x60000CC")]
	private bool UnapplyHighestCostScaler() { }

	[Address(RVA = "0x2F8A970", Offset = "0x2F89D70", Length = "0x14B")]
	[Token(Token = "0x60000CD")]
	private void UnapplyScaler(AdaptivePerformanceScaler scaler) { }

	[Address(RVA = "0x2F8AB30", Offset = "0x2F89F30", Length = "0x54C")]
	[Token(Token = "0x60000C5")]
	internal void Update() { }

	[Address(RVA = "0x2F8AAC0", Offset = "0x2F89EC0", Length = "0x60")]
	[Token(Token = "0x60000C1")]
	internal void UpdateOverrideLevel(AdaptivePerformanceScaler scaler) { }

}

