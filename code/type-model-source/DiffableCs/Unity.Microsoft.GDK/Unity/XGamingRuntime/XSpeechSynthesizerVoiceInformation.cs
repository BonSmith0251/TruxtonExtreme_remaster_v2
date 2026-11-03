namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200025C")]
public class XSpeechSynthesizerVoiceInformation
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000663")]
	internal XSpeechSynthesizerVoiceInformation interop; //Field offset: 0x10

	[Token(Token = "0x1700026D")]
	public string Description
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000C38")]
		 get { } //Length: 5
		[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
		[Token(Token = "0x6000C39")]
		 set { } //Length: 12
	}

	[Token(Token = "0x1700026E")]
	public string DisplayName
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000C3A")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6000C3B")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700026F")]
	public XSpeechSynthesizerVoiceGender Gender
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000C3C")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[Token(Token = "0x6000C3D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000271")]
	public string Language
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000C40")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x6000C41")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000270")]
	public string VoiceId
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000C3E")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x6000C3F")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2B82600", Offset = "0x2B81A00", Length = "0x45")]
	[Token(Token = "0x6000C36")]
	internal XSpeechSynthesizerVoiceInformation(XSpeechSynthesizerVoiceInformation interop) { }

	[Address(RVA = "0x2B81C20", Offset = "0x2B81020", Length = "0x27")]
	[Token(Token = "0x6000C37")]
	public XSpeechSynthesizerVoiceInformation() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000C38")]
	public string get_Description() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000C3A")]
	public string get_DisplayName() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000C3C")]
	public XSpeechSynthesizerVoiceGender get_Gender() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000C40")]
	public string get_Language() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000C3E")]
	public string get_VoiceId() { }

	[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
	[Token(Token = "0x6000C39")]
	public void set_Description(string value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000C3B")]
	public void set_DisplayName(string value) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[Token(Token = "0x6000C3D")]
	public void set_Gender(XSpeechSynthesizerVoiceGender value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x6000C41")]
	public void set_Language(string value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x6000C3F")]
	public void set_VoiceId(string value) { }

}

