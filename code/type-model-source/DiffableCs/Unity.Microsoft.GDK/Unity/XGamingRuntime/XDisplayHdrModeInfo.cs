namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200020A")]
public class XDisplayHdrModeInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000582")]
	internal XDisplayHdrModeInfo interop; //Field offset: 0x10

	[Obsolete("Please use MaxFullFrameToneMapLuminance instead, (UnityUpgradable) -> MaxFullFrameToneMapLuminance", True)]
	[Token(Token = "0x170001F1")]
	public float maxFullFrameToneMapLuminance
	{
		[Address(RVA = "0xABF7A0", Offset = "0xABEBA0", Length = "0x6")]
		[Token(Token = "0x6000AC8")]
		 get { } //Length: 6
		[Address(RVA = "0x1412590", Offset = "0x1411990", Length = "0x6")]
		[Token(Token = "0x6000AC9")]
		 set { } //Length: 6
	}

	[Token(Token = "0x170001EE")]
	public float MaxFullFrameToneMapLuminance
	{
		[Address(RVA = "0xABF7A0", Offset = "0xABEBA0", Length = "0x6")]
		[Token(Token = "0x6000AC2")]
		 get { } //Length: 6
		[Address(RVA = "0x1412590", Offset = "0x1411990", Length = "0x6")]
		[Token(Token = "0x6000AC3")]
		 set { } //Length: 6
	}

	[Obsolete("Please use MaxToneMapLuminance instead, (UnityUpgradable) -> MaxToneMapLuminance", True)]
	[Token(Token = "0x170001F0")]
	public float maxToneMapLuminance
	{
		[Address(RVA = "0xFBEB10", Offset = "0xFBDF10", Length = "0x6")]
		[Token(Token = "0x6000AC6")]
		 get { } //Length: 6
		[Address(RVA = "0xFC02D0", Offset = "0xFBF6D0", Length = "0x6")]
		[Token(Token = "0x6000AC7")]
		 set { } //Length: 6
	}

	[Token(Token = "0x170001ED")]
	public float MaxToneMapLuminance
	{
		[Address(RVA = "0xFBEB10", Offset = "0xFBDF10", Length = "0x6")]
		[Token(Token = "0x6000AC0")]
		 get { } //Length: 6
		[Address(RVA = "0xFC02D0", Offset = "0xFBF6D0", Length = "0x6")]
		[Token(Token = "0x6000AC1")]
		 set { } //Length: 6
	}

	[Obsolete("Please use MinToneMapLuminance instead, (UnityUpgradable) -> MinToneMapLuminance", True)]
	[Token(Token = "0x170001EF")]
	public float minToneMapLuminance
	{
		[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
		[Token(Token = "0x6000AC4")]
		 get { } //Length: 6
		[Address(RVA = "0x661850", Offset = "0x660C50", Length = "0x6")]
		[Token(Token = "0x6000AC5")]
		 set { } //Length: 6
	}

	[Token(Token = "0x170001EC")]
	public float MinToneMapLuminance
	{
		[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
		[Token(Token = "0x6000ABE")]
		 get { } //Length: 6
		[Address(RVA = "0x661850", Offset = "0x660C50", Length = "0x6")]
		[Token(Token = "0x6000ABF")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x2B80B30", Offset = "0x2B7FF30", Length = "0x31")]
	[Token(Token = "0x6000ABC")]
	internal XDisplayHdrModeInfo(XDisplayHdrModeInfo interop) { }

	[Address(RVA = "0x2B80B70", Offset = "0x2B7FF70", Length = "0x1F")]
	[Token(Token = "0x6000ABD")]
	public XDisplayHdrModeInfo() { }

	[Address(RVA = "0xABF7A0", Offset = "0xABEBA0", Length = "0x6")]
	[Token(Token = "0x6000AC8")]
	public float get_maxFullFrameToneMapLuminance() { }

	[Address(RVA = "0xABF7A0", Offset = "0xABEBA0", Length = "0x6")]
	[Token(Token = "0x6000AC2")]
	public float get_MaxFullFrameToneMapLuminance() { }

	[Address(RVA = "0xFBEB10", Offset = "0xFBDF10", Length = "0x6")]
	[Token(Token = "0x6000AC6")]
	public float get_maxToneMapLuminance() { }

	[Address(RVA = "0xFBEB10", Offset = "0xFBDF10", Length = "0x6")]
	[Token(Token = "0x6000AC0")]
	public float get_MaxToneMapLuminance() { }

	[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
	[Token(Token = "0x6000AC4")]
	public float get_minToneMapLuminance() { }

	[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
	[Token(Token = "0x6000ABE")]
	public float get_MinToneMapLuminance() { }

	[Address(RVA = "0x1412590", Offset = "0x1411990", Length = "0x6")]
	[Token(Token = "0x6000AC9")]
	public void set_maxFullFrameToneMapLuminance(float value) { }

	[Address(RVA = "0x1412590", Offset = "0x1411990", Length = "0x6")]
	[Token(Token = "0x6000AC3")]
	public void set_MaxFullFrameToneMapLuminance(float value) { }

	[Address(RVA = "0xFC02D0", Offset = "0xFBF6D0", Length = "0x6")]
	[Token(Token = "0x6000AC7")]
	public void set_maxToneMapLuminance(float value) { }

	[Address(RVA = "0xFC02D0", Offset = "0xFBF6D0", Length = "0x6")]
	[Token(Token = "0x6000AC1")]
	public void set_MaxToneMapLuminance(float value) { }

	[Address(RVA = "0x661850", Offset = "0x660C50", Length = "0x6")]
	[Token(Token = "0x6000AC5")]
	public void set_minToneMapLuminance(float value) { }

	[Address(RVA = "0x661850", Offset = "0x660C50", Length = "0x6")]
	[Token(Token = "0x6000ABF")]
	public void set_MinToneMapLuminance(float value) { }

}

