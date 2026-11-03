namespace UnityEngine.Rendering;

[Token(Token = "0x20003D6")]
public struct DrawingSettings : IEquatable<DrawingSettings>
{
	[CompilerGenerated]
	[Token(Token = "0x20003D7")]
	[UnsafeValueType]
	internal struct <shaderPassNames>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C85")]
		public int FixedElementField; //Field offset: 0x0

	}

	[Token(Token = "0x4000C78")]
	public static readonly int maxShaderPasses; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C79")]
	private SortingSettings m_SortingSettings; //Field offset: 0x0
	[FieldOffset(Offset = "0x60")]
	[FixedBuffer(typeof(int), 16)]
	[Token(Token = "0x4000C7A")]
	internal <shaderPassNames>e__FixedBuffer shaderPassNames; //Field offset: 0x60
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000C7B")]
	private PerObjectData m_PerObjectData; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4000C7C")]
	private DrawRendererFlags m_Flags; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000C7D")]
	private int m_OverrideShaderID; //Field offset: 0xA8
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x4000C7E")]
	private int m_OverrideShaderPassIndex; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000C7F")]
	private int m_OverrideMaterialInstanceId; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x4000C80")]
	private int m_OverrideMaterialPassIndex; //Field offset: 0xB4
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000C81")]
	private int m_fallbackMaterialInstanceId; //Field offset: 0xB8
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x4000C82")]
	private int m_MainLightIndex; //Field offset: 0xBC
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000C83")]
	private int m_UseSrpBatcher; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x4000C84")]
	private int m_LodCrossFadeStencilMask; //Field offset: 0xC4

	[Token(Token = "0x17000421")]
	public bool enableDynamicBatching
	{
		[Address(RVA = "0x30BE710", Offset = "0x30BDB10", Length = "0x1F")]
		[Token(Token = "0x6001D9E")]
		 set { } //Length: 31
	}

	[Token(Token = "0x17000422")]
	public bool enableInstancing
	{
		[Address(RVA = "0x30BE730", Offset = "0x30BDB30", Length = "0x1F")]
		[Token(Token = "0x6001D9F")]
		 set { } //Length: 31
	}

	[Token(Token = "0x17000428")]
	public int lodCrossFadeStencilMask
	{
		[Address(RVA = "0xE26C20", Offset = "0xE26020", Length = "0x7")]
		[Token(Token = "0x6001DA5")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000427")]
	public int mainLightIndex
	{
		[Address(RVA = "0x30BE750", Offset = "0x30BDB50", Length = "0x7")]
		[Token(Token = "0x6001DA4")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000423")]
	public Material overrideMaterial
	{
		[Address(RVA = "0x30BE760", Offset = "0x30BDB60", Length = "0x37")]
		[Token(Token = "0x6001DA0")]
		 set { } //Length: 55
	}

	[Token(Token = "0x17000425")]
	public int overrideMaterialPassIndex
	{
		[Address(RVA = "0x2D68640", Offset = "0x2D67A40", Length = "0x7")]
		[Token(Token = "0x6001DA2")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000424")]
	public Shader overrideShader
	{
		[Address(RVA = "0x30BE7A0", Offset = "0x30BDBA0", Length = "0x37")]
		[Token(Token = "0x6001DA1")]
		 set { } //Length: 55
	}

	[Token(Token = "0x17000426")]
	public int overrideShaderPassIndex
	{
		[Address(RVA = "0x21AD620", Offset = "0x21ACA20", Length = "0x7")]
		[Token(Token = "0x6001DA3")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000420")]
	public PerObjectData perObjectData
	{
		[Address(RVA = "0x1D639B0", Offset = "0x1D62DB0", Length = "0x7")]
		[Token(Token = "0x6001D9D")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700041F")]
	public SortingSettings sortingSettings
	{
		[Address(RVA = "0x30BE5E0", Offset = "0x30BD9E0", Length = "0x32")]
		[Token(Token = "0x6001D9B")]
		 get { } //Length: 50
		[Address(RVA = "0x30BE7E0", Offset = "0x30BDBE0", Length = "0x2F")]
		[Token(Token = "0x6001D9C")]
		 set { } //Length: 47
	}

	[Address(RVA = "0x30BE4A0", Offset = "0x30BD8A0", Length = "0x39")]
	[Token(Token = "0x6001DAC")]
	private static DrawingSettings() { }

	[Address(RVA = "0x30BE4E0", Offset = "0x30BD8E0", Length = "0xF3")]
	[Token(Token = "0x6001D9A")]
	public DrawingSettings(ShaderTagId shaderPassName, SortingSettings sortingSettings) { }

	[Address(RVA = "0x30BDAF0", Offset = "0x30BCEF0", Length = "0x13C")]
	[Token(Token = "0x6001DA9")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x30BDC30", Offset = "0x30BD030", Length = "0x590")]
	[Token(Token = "0x6001DA8")]
	public override bool Equals(DrawingSettings other) { }

	[Address(RVA = "0x30BE5E0", Offset = "0x30BD9E0", Length = "0x32")]
	[Token(Token = "0x6001D9B")]
	public SortingSettings get_sortingSettings() { }

	[Address(RVA = "0x30BE1C0", Offset = "0x30BD5C0", Length = "0x6A")]
	[Token(Token = "0x6001DAA")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x30BE230", Offset = "0x30BD630", Length = "0x12E")]
	[Token(Token = "0x6001DA6")]
	public ShaderTagId GetShaderPassName(int index) { }

	[Address(RVA = "0x30BE620", Offset = "0x30BDA20", Length = "0xE5")]
	[Token(Token = "0x6001DAB")]
	public static bool op_Equality(DrawingSettings left, DrawingSettings right) { }

	[Address(RVA = "0x30BE710", Offset = "0x30BDB10", Length = "0x1F")]
	[Token(Token = "0x6001D9E")]
	public void set_enableDynamicBatching(bool value) { }

	[Address(RVA = "0x30BE730", Offset = "0x30BDB30", Length = "0x1F")]
	[Token(Token = "0x6001D9F")]
	public void set_enableInstancing(bool value) { }

	[Address(RVA = "0xE26C20", Offset = "0xE26020", Length = "0x7")]
	[Token(Token = "0x6001DA5")]
	public void set_lodCrossFadeStencilMask(int value) { }

	[Address(RVA = "0x30BE750", Offset = "0x30BDB50", Length = "0x7")]
	[Token(Token = "0x6001DA4")]
	public void set_mainLightIndex(int value) { }

	[Address(RVA = "0x30BE760", Offset = "0x30BDB60", Length = "0x37")]
	[Token(Token = "0x6001DA0")]
	public void set_overrideMaterial(Material value) { }

	[Address(RVA = "0x2D68640", Offset = "0x2D67A40", Length = "0x7")]
	[Token(Token = "0x6001DA2")]
	public void set_overrideMaterialPassIndex(int value) { }

	[Address(RVA = "0x30BE7A0", Offset = "0x30BDBA0", Length = "0x37")]
	[Token(Token = "0x6001DA1")]
	public void set_overrideShader(Shader value) { }

	[Address(RVA = "0x21AD620", Offset = "0x21ACA20", Length = "0x7")]
	[Token(Token = "0x6001DA3")]
	public void set_overrideShaderPassIndex(int value) { }

	[Address(RVA = "0x1D639B0", Offset = "0x1D62DB0", Length = "0x7")]
	[Token(Token = "0x6001D9D")]
	public void set_perObjectData(PerObjectData value) { }

	[Address(RVA = "0x30BE7E0", Offset = "0x30BDBE0", Length = "0x2F")]
	[Token(Token = "0x6001D9C")]
	public void set_sortingSettings(SortingSettings value) { }

	[Address(RVA = "0x30BE360", Offset = "0x30BD760", Length = "0x13B")]
	[Token(Token = "0x6001DA7")]
	public void SetShaderPassName(int index, ShaderTagId shaderPassName) { }

}

