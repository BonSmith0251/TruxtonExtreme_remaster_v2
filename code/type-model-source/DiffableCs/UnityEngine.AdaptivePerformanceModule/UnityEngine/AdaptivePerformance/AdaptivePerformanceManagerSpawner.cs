namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000007")]
internal class AdaptivePerformanceManagerSpawner : ScriptableObject
{
	[Token(Token = "0x4000027")]
	public const string AdaptivePerformanceManagerObjectName = "AdaptivePerformanceManager"; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000028")]
	private GameObject m_ManagerGameObject; //Field offset: 0x18

	[Token(Token = "0x17000019")]
	public GameObject ManagerGameObject
	{
		[Address(RVA = "0x198AF30", Offset = "0x198A330", Length = "0x7")]
		[Token(Token = "0x6000049")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x5B3AF0", Offset = "0x5B2EF0", Length = "0x7")]
	[Token(Token = "0x600004E")]
	public AdaptivePerformanceManagerSpawner() { }

	[Address(RVA = "0x2F8BD30", Offset = "0x2F8B130", Length = "0x94")]
	[Token(Token = "0x600004C")]
	public void Deinitialize() { }

	[Address(RVA = "0x198AF30", Offset = "0x198A330", Length = "0x7")]
	[Token(Token = "0x6000049")]
	public GameObject get_ManagerGameObject() { }

	[Address(RVA = "0x2F8BDD0", Offset = "0x2F8B1D0", Length = "0x306")]
	[Token(Token = "0x600004B")]
	public void Initialize(bool isCheckingProvider) { }

	[Address(RVA = "0x2F8C0E0", Offset = "0x2F8B4E0", Length = "0x210")]
	[Token(Token = "0x600004D")]
	private void InstallScalers(AdaptivePerformanceScalerProfile profile, IAdaptivePerformanceSettings settings) { }

	[Address(RVA = "0x2F8C300", Offset = "0x2F8B700", Length = "0x88")]
	[Token(Token = "0x600004A")]
	private void OnEnable() { }

}

