namespace UnityEngine.UIElements;

[Token(Token = "0x20002DF")]
internal interface IPanelRenderer
{

	[Token(Token = "0x170003E4")]
	public bool forceGammaRendering
	{
		[Token(Token = "0x60013EE")]
		 get { } //Length: 0
		[Token(Token = "0x60013EF")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170003E6")]
	public TextureSlotCount textureSlotCount
	{
		[Token(Token = "0x60013F2")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170003E5")]
	public uint vertexBudget
	{
		[Token(Token = "0x60013F0")]
		 get { } //Length: 0
		[Token(Token = "0x60013F1")]
		 set { } //Length: 0
	}

	[Token(Token = "0x60013EE")]
	public bool get_forceGammaRendering() { }

	[Token(Token = "0x60013F0")]
	public uint get_vertexBudget() { }

	[Token(Token = "0x60013F4")]
	public void Render() { }

	[Token(Token = "0x60013F3")]
	public void Reset() { }

	[Token(Token = "0x60013EF")]
	public void set_forceGammaRendering(bool value) { }

	[Token(Token = "0x60013F2")]
	public void set_textureSlotCount(TextureSlotCount value) { }

	[Token(Token = "0x60013F1")]
	public void set_vertexBudget(uint value) { }

}

