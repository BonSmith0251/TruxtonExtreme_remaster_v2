namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000046")]
internal interface IPixelPerfectCamera
{

	[Token(Token = "0x17000060")]
	public int assetsPPU
	{
		[Token(Token = "0x60001DA")]
		 get { } //Length: 0
		[Token(Token = "0x60001DB")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000065")]
	public bool cropFrameX
	{
		[Token(Token = "0x60001E4")]
		 get { } //Length: 0
		[Token(Token = "0x60001E5")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000066")]
	public bool cropFrameY
	{
		[Token(Token = "0x60001E6")]
		 get { } //Length: 0
		[Token(Token = "0x60001E7")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000064")]
	public bool pixelSnapping
	{
		[Token(Token = "0x60001E2")]
		 get { } //Length: 0
		[Token(Token = "0x60001E3")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000061")]
	public int refResolutionX
	{
		[Token(Token = "0x60001DC")]
		 get { } //Length: 0
		[Token(Token = "0x60001DD")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000062")]
	public int refResolutionY
	{
		[Token(Token = "0x60001DE")]
		 get { } //Length: 0
		[Token(Token = "0x60001DF")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000067")]
	public bool stretchFill
	{
		[Token(Token = "0x60001E8")]
		 get { } //Length: 0
		[Token(Token = "0x60001E9")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000063")]
	public bool upscaleRT
	{
		[Token(Token = "0x60001E0")]
		 get { } //Length: 0
		[Token(Token = "0x60001E1")]
		 set { } //Length: 0
	}

	[Token(Token = "0x60001DA")]
	public int get_assetsPPU() { }

	[Token(Token = "0x60001E4")]
	public bool get_cropFrameX() { }

	[Token(Token = "0x60001E6")]
	public bool get_cropFrameY() { }

	[Token(Token = "0x60001E2")]
	public bool get_pixelSnapping() { }

	[Token(Token = "0x60001DC")]
	public int get_refResolutionX() { }

	[Token(Token = "0x60001DE")]
	public int get_refResolutionY() { }

	[Token(Token = "0x60001E8")]
	public bool get_stretchFill() { }

	[Token(Token = "0x60001E0")]
	public bool get_upscaleRT() { }

	[Token(Token = "0x60001DB")]
	public void set_assetsPPU(int value) { }

	[Token(Token = "0x60001E5")]
	public void set_cropFrameX(bool value) { }

	[Token(Token = "0x60001E7")]
	public void set_cropFrameY(bool value) { }

	[Token(Token = "0x60001E3")]
	public void set_pixelSnapping(bool value) { }

	[Token(Token = "0x60001DD")]
	public void set_refResolutionX(int value) { }

	[Token(Token = "0x60001DF")]
	public void set_refResolutionY(int value) { }

	[Token(Token = "0x60001E9")]
	public void set_stretchFill(bool value) { }

	[Token(Token = "0x60001E1")]
	public void set_upscaleRT(bool value) { }

}

