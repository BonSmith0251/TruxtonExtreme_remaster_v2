namespace UnityEngine.Rendering;

[Token(Token = "0x200019B")]
public class RTHandle
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007DD")]
	internal RTHandleSystem m_Owner; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007DE")]
	internal RenderTexture m_RT; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007DF")]
	internal Texture m_ExternalTexture; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40007E0")]
	internal RenderTargetIdentifier m_NameID; //Field offset: 0x28
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40007E1")]
	internal bool m_EnableMSAA; //Field offset: 0x50
	[FieldOffset(Offset = "0x51")]
	[Token(Token = "0x40007E2")]
	internal bool m_EnableRandomWrite; //Field offset: 0x51
	[FieldOffset(Offset = "0x52")]
	[Token(Token = "0x40007E3")]
	internal bool m_EnableHWDynamicScale; //Field offset: 0x52
	[FieldOffset(Offset = "0x53")]
	[Token(Token = "0x40007E4")]
	internal bool m_RTHasOwnership; //Field offset: 0x53
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40007E5")]
	internal string m_Name; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40007E6")]
	internal bool m_UseCustomHandleScales; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40007E7")]
	internal RTHandleProperties m_CustomHandleProperties; //Field offset: 0x64
	[CompilerGenerated]
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x40007E8")]
	private Vector2 <scaleFactor>k__BackingField; //Field offset: 0x94
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40007E9")]
	internal ScaleFunc scaleFunc; //Field offset: 0xA0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40007EA")]
	private bool <useScaling>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x40007EB")]
	private Vector2Int <referenceSize>k__BackingField; //Field offset: 0xAC

	[Token(Token = "0x17000177")]
	public Texture externalTexture
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000BE5")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700017A")]
	public bool isMSAAEnabled
	{
		[Address(RVA = "0xF4F630", Offset = "0xF4EA30", Length = "0x5")]
		[Token(Token = "0x6000BE8")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000179")]
	public string name
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x6000BE7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000178")]
	public RenderTargetIdentifier nameID
	{
		[Address(RVA = "0x2827170", Offset = "0x2826570", Length = "0x1D")]
		[Token(Token = "0x6000BE6")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000174")]
	public internal Vector2Int referenceSize
	{
		[Address(RVA = "0x21401A0", Offset = "0x213F5A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000BE1")]
		 get { } //Length: 8
		[Address(RVA = "0x2140240", Offset = "0x213F640", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000BE2")]
		internal set { } //Length: 8
	}

	[Token(Token = "0x17000176")]
	public RenderTexture rt
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000BE4")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000175")]
	public RTHandleProperties rtHandleProperties
	{
		[Address(RVA = "0x2C4C590", Offset = "0x2C4B990", Length = "0x59")]
		[Token(Token = "0x6000BE3")]
		 get { } //Length: 89
	}

	[Token(Token = "0x17000172")]
	public internal Vector2 scaleFactor
	{
		[Address(RVA = "0x2C4C5F0", Offset = "0x2C4B9F0", Length = "0x19")]
		[CompilerGenerated]
		[Token(Token = "0x6000BDD")]
		 get { } //Length: 25
		[Address(RVA = "0x2C4C6F0", Offset = "0x2C4BAF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000BDE")]
		internal set { } //Length: 8
	}

	[Token(Token = "0x17000173")]
	public internal bool useScaling
	{
		[Address(RVA = "0x1D16D50", Offset = "0x1D16150", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000BDF")]
		 get { } //Length: 8
		[Address(RVA = "0x21AD640", Offset = "0x21ACA40", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000BE0")]
		internal set { } //Length: 7
	}

	[Address(RVA = "0x2C4C550", Offset = "0x2C4B950", Length = "0x35")]
	[Token(Token = "0x6000BE9")]
	internal RTHandle(RTHandleSystem owner) { }

	[Address(RVA = "0x2C4BDF0", Offset = "0x2C4B1F0", Length = "0x5")]
	[Token(Token = "0x6000BDC")]
	public void ClearCustomHandleProperties() { }

	[Address(RVA = "0x2C4BE00", Offset = "0x2C4B200", Length = "0xDF")]
	[Token(Token = "0x6000BF5")]
	public void CopyToFastMemory(CommandBuffer cmd, float residencyFraction = 1, FastMemoryFlags flags = 1) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000BE5")]
	public Texture get_externalTexture() { }

	[Address(RVA = "0xF4F630", Offset = "0xF4EA30", Length = "0x5")]
	[Token(Token = "0x6000BE8")]
	public bool get_isMSAAEnabled() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x6000BE7")]
	public string get_name() { }

	[Address(RVA = "0x2827170", Offset = "0x2826570", Length = "0x1D")]
	[Token(Token = "0x6000BE6")]
	public RenderTargetIdentifier get_nameID() { }

	[Address(RVA = "0x21401A0", Offset = "0x213F5A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000BE1")]
	public Vector2Int get_referenceSize() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000BE4")]
	public RenderTexture get_rt() { }

	[Address(RVA = "0x2C4C590", Offset = "0x2C4B990", Length = "0x59")]
	[Token(Token = "0x6000BE3")]
	public RTHandleProperties get_rtHandleProperties() { }

	[Address(RVA = "0x2C4C5F0", Offset = "0x2C4B9F0", Length = "0x19")]
	[CompilerGenerated]
	[Token(Token = "0x6000BDD")]
	public Vector2 get_scaleFactor() { }

	[Address(RVA = "0x1D16D50", Offset = "0x1D16150", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000BDF")]
	public bool get_useScaling() { }

	[Address(RVA = "0x2C4BEE0", Offset = "0x2C4B2E0", Length = "0xD8")]
	[Token(Token = "0x6000BF0")]
	public int GetInstanceID() { }

	[Address(RVA = "0x2C4BFC0", Offset = "0x2C4B3C0", Length = "0xA3")]
	[Token(Token = "0x6000BF3")]
	public Vector2Int GetScaledSize() { }

	[Address(RVA = "0x2C4C070", Offset = "0x2C4B470", Length = "0x8F")]
	[Token(Token = "0x6000BF2")]
	public Vector2Int GetScaledSize(Vector2Int refSize) { }

	[Address(RVA = "0x2C4C610", Offset = "0x2C4BA10", Length = "0x4E")]
	[Token(Token = "0x6000BEA")]
	public static RenderTargetIdentifier op_Implicit(RTHandle handle) { }

	[Address(RVA = "0x2C4C670", Offset = "0x2C4BA70", Length = "0x7A")]
	[Token(Token = "0x6000BEB")]
	public static Texture op_Implicit(RTHandle handle) { }

	[Address(RVA = "0x2C4C660", Offset = "0x2C4BA60", Length = "0xD")]
	[Token(Token = "0x6000BEC")]
	public static RenderTexture op_Implicit(RTHandle handle) { }

	[Address(RVA = "0x2C4C100", Offset = "0x2C4B500", Length = "0x114")]
	[Token(Token = "0x6000BF1")]
	public void Release() { }

	[Address(RVA = "0x2140240", Offset = "0x213F640", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000BE2")]
	internal void set_referenceSize(Vector2Int value) { }

	[Address(RVA = "0x2C4C6F0", Offset = "0x2C4BAF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000BDE")]
	internal void set_scaleFactor(Vector2 value) { }

	[Address(RVA = "0x21AD640", Offset = "0x21ACA40", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000BE0")]
	internal void set_useScaling(bool value) { }

	[Address(RVA = "0x2C4C220", Offset = "0x2C4B620", Length = "0x1F")]
	[Token(Token = "0x6000BDB")]
	public void SetCustomHandleProperties(in RTHandleProperties properties) { }

	[Address(RVA = "0x2C4C240", Offset = "0x2C4B640", Length = "0x8D")]
	[Token(Token = "0x6000BED")]
	internal void SetRenderTexture(RenderTexture rt, bool transferOwnership = true) { }

	[Address(RVA = "0x2C4C330", Offset = "0x2C4B730", Length = "0x7F")]
	[Token(Token = "0x6000BEE")]
	internal void SetTexture(Texture tex) { }

	[Address(RVA = "0x2C4C2D0", Offset = "0x2C4B6D0", Length = "0x5A")]
	[Token(Token = "0x6000BEF")]
	internal void SetTexture(RenderTargetIdentifier tex) { }

	[Address(RVA = "0x2C4C3B0", Offset = "0x2C4B7B0", Length = "0xA6")]
	[Token(Token = "0x6000BF6")]
	public void SwitchOutFastMemory(CommandBuffer cmd, bool copyContents = true) { }

	[Address(RVA = "0x2C4C460", Offset = "0x2C4B860", Length = "0xE6")]
	[Token(Token = "0x6000BF4")]
	public void SwitchToFastMemory(CommandBuffer cmd, float residencyFraction = 1, FastMemoryFlags flags = 1, bool copyContents = false) { }

}

