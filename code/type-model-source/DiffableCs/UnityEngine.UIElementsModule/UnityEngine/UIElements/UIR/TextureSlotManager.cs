namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005E2")]
internal class TextureSlotManager
{
	[Token(Token = "0x400156F")]
	internal static readonly int k_MaxSlotCount; //Field offset: 0x0
	[Token(Token = "0x4001570")]
	internal static readonly int k_SlotSize; //Field offset: 0x4
	[Token(Token = "0x4001571")]
	internal static Int32[] slotIds; //Field offset: 0x8
	[Token(Token = "0x4001572")]
	internal static readonly int textureTableId; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001573")]
	private TextureId[] m_Textures; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001574")]
	private Int32[] m_LastUseTime; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001575")]
	private int m_CurrentTime; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001576")]
	private int m_BatchTime; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001577")]
	private Vector4[] m_GpuTextures; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001578")]
	private int m_SlotCount; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4001579")]
	private int <FreeSlots>k__BackingField; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400157A")]
	internal TextureRegistry textureRegistry; //Field offset: 0x38

	[Token(Token = "0x17000A8E")]
	public private int FreeSlots
	{
		[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002A4F")]
		 get { } //Length: 4
		[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002A50")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x3329B90", Offset = "0x3328F90", Length = "0x17C")]
	[Token(Token = "0x6002A48")]
	private static TextureSlotManager() { }

	[Address(RVA = "0x3329D10", Offset = "0x3329110", Length = "0x1EA")]
	[Token(Token = "0x6002A49")]
	public TextureSlotManager() { }

	[Address(RVA = "0x3329330", Offset = "0x3328730", Length = "0x307")]
	[Token(Token = "0x6002A52")]
	public void Bind(TextureId id, float sdfScale, float sharpness, bool isPremultiplied, int slot, MaterialPropertyBlock mat, CommandList commandList = null) { }

	[Address(RVA = "0x3329640", Offset = "0x3328A40", Length = "0x6D")]
	[Token(Token = "0x6002A51")]
	public int FindOldestSlot() { }

	[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6002A4F")]
	public int get_FreeSlots() { }

	[Address(RVA = "0x33296B0", Offset = "0x3328AB0", Length = "0xB0")]
	[Token(Token = "0x6002A4D")]
	public int IndexOf(TextureId id) { }

	[Address(RVA = "0x3329770", Offset = "0x3328B70", Length = "0x54")]
	[Token(Token = "0x6002A4E")]
	public void MarkUsed(int slotIndex) { }

	[Address(RVA = "0x33297D0", Offset = "0x3328BD0", Length = "0x66")]
	[Token(Token = "0x6002A4A")]
	public void Reset() { }

	[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6002A50")]
	private void set_FreeSlots(int value) { }

	[Address(RVA = "0x3329840", Offset = "0x3328C40", Length = "0x1C0")]
	[Token(Token = "0x6002A53")]
	public void SetGpuData(int slotIndex, TextureId id, int textureWidth, int textureHeight, float sdfScale, float sharpness, bool isPremultiplied) { }

	[Address(RVA = "0x3329A10", Offset = "0x3328E10", Length = "0x3F")]
	[Token(Token = "0x6002A4C")]
	public void StartNewBatch(int slotCount) { }

	[Address(RVA = "0x3329A50", Offset = "0x3328E50", Length = "0x13D")]
	[Token(Token = "0x6002A4B")]
	private void Unbind(int first, int count = 1) { }

}

