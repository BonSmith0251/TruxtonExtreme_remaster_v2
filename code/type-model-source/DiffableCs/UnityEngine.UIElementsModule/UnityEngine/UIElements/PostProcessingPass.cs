namespace UnityEngine.UIElements;

[Token(Token = "0x2000252")]
public struct PostProcessingPass
{
	[Token(Token = "0x2000254")]
	internal sealed class ApplyFilterPassSettingsDelegate : MulticastDelegate
	{

		[Address(RVA = "0x33C61E0", Offset = "0x33C55E0", Length = "0xB5")]
		[Token(Token = "0x6001002")]
		public ApplyFilterPassSettingsDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x33C6170", Offset = "0x33C5570", Length = "0x6F")]
		[Token(Token = "0x6001003")]
		public override void Invoke(MaterialPropertyBlock mpb, FilterPassContext context) { }

	}

	[Token(Token = "0x2000255")]
	internal sealed class ComputeRequiredMarginsDelegate : MulticastDelegate
	{

		[Address(RVA = "0x33C6980", Offset = "0x33C5D80", Length = "0xA6")]
		[Token(Token = "0x6001004")]
		public ComputeRequiredMarginsDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x33C6900", Offset = "0x33C5D00", Length = "0x76")]
		[Token(Token = "0x6001005")]
		public override PostProcessingMargins Invoke(FilterFunction func) { }

	}

	[Obsolete("This delegate will be removed. Use ApplyFilterPassSettingsDelegate instead.")]
	[Token(Token = "0x2000253")]
	internal sealed class PrepareMaterialPropertyBlockDelegate : MulticastDelegate
	{

		[Address(RVA = "0x33DB040", Offset = "0x33DA440", Length = "0xB5")]
		[Token(Token = "0x6001000")]
		public PrepareMaterialPropertyBlockDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x33DAFD0", Offset = "0x33DA3D0", Length = "0x63")]
		[Token(Token = "0x6001001")]
		public override void Invoke(MaterialPropertyBlock mpb, FilterFunction func) { }

	}

	[DontCreateProperty]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000905")]
	private Material m_Material; //Field offset: 0x0
	[DontCreateProperty]
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x4000906")]
	private int m_PassIndex; //Field offset: 0x8
	[DontCreateProperty]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000907")]
	private ParameterBinding[] m_ParameterBindings; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000908")]
	private PostProcessingMargins m_ReadMargins; //Field offset: 0x18
	[DontCreateProperty]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000909")]
	private PostProcessingMargins m_WriteMargins; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400090A")]
	private PrepareMaterialPropertyBlockDelegate <prepareMaterialPropertyBlockCallback>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400090B")]
	private ApplyFilterPassSettingsDelegate <applySettingsCallback>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400090C")]
	private ComputeRequiredMarginsDelegate <computeRequiredReadMarginsCallback>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400090D")]
	private ComputeRequiredMarginsDelegate <computeRequiredWriteMarginsCallback>k__BackingField; //Field offset: 0x50

	[Token(Token = "0x170002EF")]
	public ApplyFilterPassSettingsDelegate applySettingsCallback
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000FFA")]
		 get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000FFB")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170002F0")]
	public ComputeRequiredMarginsDelegate computeRequiredReadMarginsCallback
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000FFC")]
		 get { } //Length: 5
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000FFD")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170002F1")]
	public ComputeRequiredMarginsDelegate computeRequiredWriteMarginsCallback
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000FFE")]
		 get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000FFF")]
		 set { } //Length: 13
	}

	[CreateProperty]
	[Token(Token = "0x170002E9")]
	public Material material
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x6000FEF")]
		 get { } //Length: 4
		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x6000FF0")]
		 set { } //Length: 8
	}

	[CreateProperty]
	[Token(Token = "0x170002EB")]
	public ParameterBinding[] parameterBindings
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000FF3")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6000FF4")]
		 set { } //Length: 13
	}

	[CreateProperty]
	[Token(Token = "0x170002EA")]
	public int passIndex
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x6000FF1")]
		 get { } //Length: 4
		[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
		[Token(Token = "0x6000FF2")]
		 set { } //Length: 4
	}

	[Obsolete("This property will be removed. Use applySettingsCallback instead, which provides additional contextual information.")]
	[Token(Token = "0x170002EE")]
	public PrepareMaterialPropertyBlockDelegate prepareMaterialPropertyBlockCallback
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000FF9")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002EC")]
	internal PostProcessingMargins readMargins
	{
		[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
		[Token(Token = "0x6000FF5")]
		internal get { } //Length: 11
		[Address(RVA = "0x14125B0", Offset = "0x14119B0", Length = "0x8")]
		[Token(Token = "0x6000FF6")]
		internal set { } //Length: 8
	}

	[CreateProperty]
	[Token(Token = "0x170002ED")]
	public PostProcessingMargins writeMargins
	{
		[Address(RVA = "0xB00180", Offset = "0xAFF580", Length = "0xB")]
		[Token(Token = "0x6000FF7")]
		 get { } //Length: 11
		[Address(RVA = "0x1FF5900", Offset = "0x1FF4D00", Length = "0x8")]
		[Token(Token = "0x6000FF8")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000FFA")]
	public ApplyFilterPassSettingsDelegate get_applySettingsCallback() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000FFC")]
	public ComputeRequiredMarginsDelegate get_computeRequiredReadMarginsCallback() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000FFE")]
	public ComputeRequiredMarginsDelegate get_computeRequiredWriteMarginsCallback() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6000FEF")]
	public Material get_material() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000FF3")]
	public ParameterBinding[] get_parameterBindings() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[Token(Token = "0x6000FF1")]
	public int get_passIndex() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000FF9")]
	public PrepareMaterialPropertyBlockDelegate get_prepareMaterialPropertyBlockCallback() { }

	[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
	[Token(Token = "0x6000FF5")]
	internal PostProcessingMargins get_readMargins() { }

	[Address(RVA = "0xB00180", Offset = "0xAFF580", Length = "0xB")]
	[Token(Token = "0x6000FF7")]
	public PostProcessingMargins get_writeMargins() { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000FFB")]
	public void set_applySettingsCallback(ApplyFilterPassSettingsDelegate value) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000FFD")]
	public void set_computeRequiredReadMarginsCallback(ComputeRequiredMarginsDelegate value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000FFF")]
	public void set_computeRequiredWriteMarginsCallback(ComputeRequiredMarginsDelegate value) { }

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[Token(Token = "0x6000FF0")]
	public void set_material(Material value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6000FF4")]
	public void set_parameterBindings(ParameterBinding[] value) { }

	[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
	[Token(Token = "0x6000FF2")]
	public void set_passIndex(int value) { }

	[Address(RVA = "0x14125B0", Offset = "0x14119B0", Length = "0x8")]
	[Token(Token = "0x6000FF6")]
	internal void set_readMargins(PostProcessingMargins value) { }

	[Address(RVA = "0x1FF5900", Offset = "0x1FF4D00", Length = "0x8")]
	[Token(Token = "0x6000FF8")]
	public void set_writeMargins(PostProcessingMargins value) { }

}

