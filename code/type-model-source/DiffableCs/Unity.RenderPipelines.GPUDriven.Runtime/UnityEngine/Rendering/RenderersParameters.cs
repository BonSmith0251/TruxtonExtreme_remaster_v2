namespace UnityEngine.Rendering;

[Token(Token = "0x20000E5")]
internal struct RenderersParameters
{
	[Flags]
	[Token(Token = "0x20000E6")]
	internal enum Flags : int
	{
		None = 0,
		UseBoundingSphereParameter = 1,
	}

	[Token(Token = "0x20000E8")]
	internal struct ParamInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000444")]
		public int index; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000445")]
		public int gpuAddress; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000446")]
		public int uintOffset; //Field offset: 0x8

		[Token(Token = "0x17000074")]
		public bool valid
		{
			[Address(RVA = "0x2CFE680", Offset = "0x2CFDA80", Length = "0x7")]
			[Token(Token = "0x60003BC")]
			 get { } //Length: 7
		}

		[Address(RVA = "0x2CFE680", Offset = "0x2CFDA80", Length = "0x7")]
		[Token(Token = "0x60003BC")]
		public bool get_valid() { }

	}

	[Token(Token = "0x20000E7")]
	internal static class ParamNames
	{
		[Token(Token = "0x4000438")]
		public static readonly int _BaseColor; //Field offset: 0x0
		[Token(Token = "0x4000439")]
		public static readonly int unity_SpecCube0_HDR; //Field offset: 0x4
		[Token(Token = "0x400043A")]
		public static readonly int unity_SHCoefficients; //Field offset: 0x8
		[Token(Token = "0x400043B")]
		public static readonly int unity_LightmapST; //Field offset: 0xC
		[Token(Token = "0x400043C")]
		public static readonly int unity_ObjectToWorld; //Field offset: 0x10
		[Token(Token = "0x400043D")]
		public static readonly int unity_WorldToObject; //Field offset: 0x14
		[Token(Token = "0x400043E")]
		public static readonly int unity_MatrixPreviousM; //Field offset: 0x18
		[Token(Token = "0x400043F")]
		public static readonly int unity_MatrixPreviousMI; //Field offset: 0x1C
		[Token(Token = "0x4000440")]
		public static readonly int unity_WorldBoundingSphere; //Field offset: 0x20
		[Token(Token = "0x4000441")]
		public static readonly int unity_RendererUserValuesPropertyEntry; //Field offset: 0x24
		[Token(Token = "0x4000442")]
		public static readonly Int32[] DOTS_ST_WindParams; //Field offset: 0x28
		[Token(Token = "0x4000443")]
		public static readonly Int32[] DOTS_ST_WindHistoryParams; //Field offset: 0x30

		[Address(RVA = "0x2CFE690", Offset = "0x2CFDA90", Length = "0x34B")]
		[Token(Token = "0x60003BB")]
		private static ParamNames() { }

	}

	[Token(Token = "0x400042A")]
	private static int s_uintSize; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400042B")]
	public ParamInfo lightmapScale; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400042C")]
	public ParamInfo localToWorld; //Field offset: 0xC
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400042D")]
	public ParamInfo worldToLocal; //Field offset: 0x18
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400042E")]
	public ParamInfo matrixPreviousM; //Field offset: 0x24
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400042F")]
	public ParamInfo matrixPreviousMI; //Field offset: 0x30
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000430")]
	public ParamInfo shCoefficients; //Field offset: 0x3C
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000431")]
	public ParamInfo rendererUserValues; //Field offset: 0x48
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000432")]
	public ParamInfo boundingSphere; //Field offset: 0x54
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000433")]
	public ParamInfo[] windParams; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000434")]
	public ParamInfo[] windHistoryParams; //Field offset: 0x68

	[Address(RVA = "0x2D02030", Offset = "0x2D01430", Length = "0x45")]
	[Token(Token = "0x60003B9")]
	private static RenderersParameters() { }

	[Address(RVA = "0x2D02080", Offset = "0x2D01480", Length = "0x6B4")]
	[Token(Token = "0x60003B8")]
	public RenderersParameters(in GPUInstanceDataBuffer instanceDataBuffer) { }

	[Address(RVA = "0x2D01F50", Offset = "0x2D01350", Length = "0xD4")]
	[CompilerGenerated]
	[Token(Token = "0x60003BA")]
	internal static ParamInfo <.ctor>g__GetParamInfo|15_0(in GPUInstanceDataBuffer instanceDataBuffer, int paramNameIdx, bool assertOnFail = true) { }

	[Address(RVA = "0x2D01AB0", Offset = "0x2D00EB0", Length = "0x495")]
	[Token(Token = "0x60003B7")]
	public static GPUInstanceDataBuffer CreateInstanceDataBuffer(Flags flags, in InstanceNumInfo instanceNumInfo) { }

}

