namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200003F")]
internal class LightBatch
{
	[Token(Token = "0x400013C")]
	private static readonly ProfilingSampler profilingDrawBatched; //Field offset: 0x0
	[Token(Token = "0x400013D")]
	private static readonly int k_BufferOffset; //Field offset: 0x8
	[Token(Token = "0x400013E")]
	private static int sBatchIndexCounter; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400013F")]
	private Int32[] subsets; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000140")]
	private Mesh[] lightMeshes; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000141")]
	private Matrix4x4[] matrices; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000142")]
	private LightBuffer[] lightBuffer; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000143")]
	private Light2D cachedLight; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000144")]
	private Material cachedMaterial; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000145")]
	private int hashCode; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000146")]
	private int lightCount; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000147")]
	private int maxIndex; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000148")]
	private int batchCount; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000149")]
	private int activeCount; //Field offset: 0x50

	[Token(Token = "0x17000049")]
	private static int batchLightMod
	{
		[Address(RVA = "0x2D27280", Offset = "0x2D26680", Length = "0x4E")]
		[Token(Token = "0x600018B")]
		private get { } //Length: 78
	}

	[Token(Token = "0x1700004A")]
	private static float batchRunningIndex
	{
		[Address(RVA = "0x2D272D0", Offset = "0x2D266D0", Length = "0xA0")]
		[Token(Token = "0x600018C")]
		private get { } //Length: 160
	}

	[Token(Token = "0x1700004F")]
	internal static int batchSlotIndex
	{
		[Address(RVA = "0x2D27370", Offset = "0x2D26770", Length = "0x118")]
		[Token(Token = "0x6000192")]
		internal get { } //Length: 280
	}

	[Token(Token = "0x1700004D")]
	internal GraphicsBuffer graphicsBuffer
	{
		[Address(RVA = "0x2D27490", Offset = "0x2D26890", Length = "0x1AE")]
		[Token(Token = "0x600018F")]
		internal get { } //Length: 430
	}

	[Token(Token = "0x1700004B")]
	public static bool isBatchingSupported
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600018D")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700004E")]
	internal NativeArray<Int32> lightMarker
	{
		[Address(RVA = "0x2D27640", Offset = "0x2D26A40", Length = "0x10E")]
		[Token(Token = "0x6000190")]
		internal get { } //Length: 270
	}

	[Token(Token = "0x1700004C")]
	internal NativeArray<PerLight2D> nativeBuffer
	{
		[Address(RVA = "0x2D27750", Offset = "0x2D26B50", Length = "0x10E")]
		[Token(Token = "0x600018E")]
		internal get { } //Length: 270
	}

	[Address(RVA = "0x2D27080", Offset = "0x2D26480", Length = "0xC8")]
	[Token(Token = "0x60001A1")]
	private static LightBatch() { }

	[Address(RVA = "0x2D27150", Offset = "0x2D26550", Length = "0x12D")]
	[Token(Token = "0x60001A0")]
	public LightBatch() { }

	[Address(RVA = "0x2D26390", Offset = "0x2D25790", Length = "0x108")]
	[Token(Token = "0x600019E")]
	internal bool AddBatch(Light2D light, Material material, Matrix4x4 mat, Mesh mesh, int subset, int lightHash, int index) { }

	[Address(RVA = "0x2D264A0", Offset = "0x2D258A0", Length = "0x1C4")]
	[Token(Token = "0x600019D")]
	internal bool CanBatch(Light2D light, Material material, int index, out int lightHash) { }

	[Address(RVA = "0x2D26670", Offset = "0x2D25A70", Length = "0x325")]
	[Token(Token = "0x600019F")]
	internal void Flush(RasterCommandBuffer cmd) { }

	[Address(RVA = "0x2D27280", Offset = "0x2D26680", Length = "0x4E")]
	[Token(Token = "0x600018B")]
	private static int get_batchLightMod() { }

	[Address(RVA = "0x2D272D0", Offset = "0x2D266D0", Length = "0xA0")]
	[Token(Token = "0x600018C")]
	private static float get_batchRunningIndex() { }

	[Address(RVA = "0x2D27370", Offset = "0x2D26770", Length = "0x118")]
	[Token(Token = "0x6000192")]
	internal static int get_batchSlotIndex() { }

	[Address(RVA = "0x2D27490", Offset = "0x2D26890", Length = "0x1AE")]
	[Token(Token = "0x600018F")]
	internal GraphicsBuffer get_graphicsBuffer() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600018D")]
	public static bool get_isBatchingSupported() { }

	[Address(RVA = "0x2D27640", Offset = "0x2D26A40", Length = "0x10E")]
	[Token(Token = "0x6000190")]
	internal NativeArray<Int32> get_lightMarker() { }

	[Address(RVA = "0x2D27750", Offset = "0x2D26B50", Length = "0x10E")]
	[Token(Token = "0x600018E")]
	internal NativeArray<PerLight2D> get_nativeBuffer() { }

	[Address(RVA = "0x2D269A0", Offset = "0x2D25DA0", Length = "0x19E")]
	[Token(Token = "0x6000194")]
	internal static float GetBatchColor() { }

	[Address(RVA = "0x2D26B40", Offset = "0x2D25F40", Length = "0x68")]
	[Token(Token = "0x6000195")]
	internal static int GetBatchSlotIndex(float channelColor) { }

	[Address(RVA = "0x2D26BB0", Offset = "0x2D25FB0", Length = "0x7B")]
	[Token(Token = "0x6000191")]
	internal PerLight2D GetLight(int index) { }

	[Address(RVA = "0x2D26C30", Offset = "0x2D26030", Length = "0xFB")]
	[Token(Token = "0x6000196")]
	private static int Hash(Light2D light, Material material) { }

	[Address(RVA = "0x2D26D30", Offset = "0x2D26130", Length = "0xC9")]
	[Token(Token = "0x6000198")]
	private void OnAssemblyReload() { }

	[Address(RVA = "0x2D26EB0", Offset = "0x2D262B0", Length = "0x46")]
	[Token(Token = "0x600019C")]
	internal void Reset() { }

	[Address(RVA = "0x2D26E00", Offset = "0x2D26200", Length = "0xAB")]
	[Token(Token = "0x6000199")]
	private void ResetInternals() { }

	[Address(RVA = "0x2D26F00", Offset = "0x2D26300", Length = "0xE4")]
	[Token(Token = "0x600019A")]
	private void SetBuffer() { }

	[Address(RVA = "0x2D26FF0", Offset = "0x2D263F0", Length = "0x7B")]
	[Token(Token = "0x6000193")]
	internal void SetLight(int index, PerLight2D light) { }

	[Address(RVA = "0x2D27070", Offset = "0x2D26470", Length = "0x6")]
	[Token(Token = "0x600019B")]
	internal int SlotIndex(int x) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000197")]
	private void Validate() { }

}

