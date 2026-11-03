namespace UnityEngine.Rendering;

[Token(Token = "0x20001F2")]
internal class VolumeCollection
{
	[Token(Token = "0x400096F")]
	internal const int k_MaxLayerCount = 32; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000970")]
	private readonly Dictionary<Int32, List`1<Volume>> m_SortedVolumes; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000971")]
	private readonly List<Volume> m_Volumes; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000972")]
	private readonly Dictionary<Int32, Boolean> m_SortNeeded; //Field offset: 0x20

	[Token(Token = "0x170001E5")]
	public int count
	{
		[Address(RVA = "0x2C69150", Offset = "0x2C68550", Length = "0x3C")]
		[Token(Token = "0x6000ED2")]
		 get { } //Length: 60
	}

	[Address(RVA = "0x2C69040", Offset = "0x2C68440", Length = "0x103")]
	[Token(Token = "0x6000EDA")]
	public VolumeCollection() { }

	[Address(RVA = "0x2C68430", Offset = "0x2C67830", Length = "0xF2")]
	[Token(Token = "0x6000ED5")]
	public bool ChangeLayer(Volume volume, int previousLayerIndex, int currentLayerIndex) { }

	[Address(RVA = "0x2C69150", Offset = "0x2C68550", Length = "0x3C")]
	[Token(Token = "0x6000ED2")]
	public int get_count() { }

	[Address(RVA = "0x2C68530", Offset = "0x2C67930", Length = "0x34C")]
	[Token(Token = "0x6000ED7")]
	public List<Volume> GrabVolumes(LayerMask mask) { }

	[Address(RVA = "0x9E59C0", Offset = "0x9E4DC0", Length = "0x35E")]
	[Token(Token = "0x6000ED9")]
	public bool IsComponentActiveInMask(LayerMask layerMask) { }

	[Address(RVA = "0x2C68880", Offset = "0x2C67C80", Length = "0x2CA")]
	[Token(Token = "0x6000ED3")]
	public bool Register(Volume volume, int layer) { }

	[Address(RVA = "0x2C68B50", Offset = "0x2C67F50", Length = "0x16F")]
	[Token(Token = "0x6000ED8")]
	public void SetLayerIndexDirty(int layerIndex) { }

	[Address(RVA = "0x2C68CC0", Offset = "0x2C680C0", Length = "0x119")]
	[Token(Token = "0x6000ED6")]
	internal static void SortByPriority(List<Volume> volumes) { }

	[Address(RVA = "0x2C68DE0", Offset = "0x2C681E0", Length = "0x250")]
	[Token(Token = "0x6000ED4")]
	public bool Unregister(Volume volume, int layer) { }

}

